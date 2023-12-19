
using System.Text;

namespace MS4SArgHasher.Actions
{
    internal class CompareAction : IAction
    {
        private string pathDataFirstFile = string.Empty;
        private string pathDataSecondFile = string.Empty;
        private string separatorFirstFile = string.Empty;
        private string separatorSecondFile = string.Empty;

        public const string DATA_MAINTAINER_KEY = "COMPARE_HASH_ACTION_RESULT";

        public string[] GetData() => new string[5] { "--compare", pathDataFirstFile, pathDataSecondFile, separatorFirstFile, separatorSecondFile };

        public void SetData(params string[] data)
        {
            pathDataFirstFile = data[1];
            pathDataSecondFile = data[2];
            separatorFirstFile = data.Length > 3 ? data[3] : ":";
            separatorSecondFile = data.Length > 4 ? data[4] : ":";
        }

        public void Start() => Compare(pathDataFirstFile, pathDataSecondFile, separatorFirstFile, separatorSecondFile);

        public bool Compare()
        {
            string[] data = GetData();
            return Compare(data[1], data[2], data[3], data[4]);
        }

        public bool Compare(string pathDataFirstFile, string pathDataSecondFile, string separatorFirstFile, string separatorSecondFile)
        {
            string[] firstFileLines = File.ReadAllLines(pathDataFirstFile);
            string[] secondFileLines = File.ReadAllLines(pathDataSecondFile);

            StringBuilder info = new StringBuilder();
            bool isEqualLength = firstFileLines.Length == secondFileLines.Length;

            info.AppendLine($"[INFO] LINE LENGTH MATCH: {isEqualLength}");

            if (!isEqualLength)
            {
                info.AppendLine("[ERROR] No need to check further since length arent matching, they are NOT equal");
                return false;
            }

            for (int i = 0; i < firstFileLines.Length; i++)
            {
                if (firstFileLines[i].Length <= 2) continue; //prob empty line we dont care about that
                string[] split = firstFileLines[i].Split(separatorFirstFile);
                if (split == null || split.Length < 2)
                {
                    info.AppendLine($"[ERROR] We tried to split hash with path in half but we couldn't, double check separator, you gave us: '{separatorFirstFile}', but looks like they separated between with other symbol");
                    return false;
                }
                string firstHash = split[1]; //first file separator TODO: custom player separator

                if (!CheckPair(firstHash, secondFileLines, separatorSecondFile))
                {
                    info.AppendLine($"[ERROR] We tried our best my dudes, but nothing with this hash: {firstHash} was found in second file, you might wanna double check your separator or second file just doesnt have this hash..");
                    return false;
                }
            }

            info.AppendLine($"\n[SUCCESS] They purrfectly matched each other, 100%");
            return true;
        }

        private bool CheckPair(string firstHash, string[] whereToCheck, string separator = ":")
        {
            foreach (string secondLine in whereToCheck)
            {
                string[] split = secondLine.Split(separator);
                if (split == null || split.Length < 2) return false; //wrong separator we couldnt cut

                string secondHash = secondLine.Split(separator)[1]; //second file separator TODO: custom player separator
                if (secondHash != firstHash) continue; //didnt find match, check next

                return true; //we did it boys, we found the pair
            }

            return false; //sadge, we did our best iterating entire stack but nothing was found :C
        }


    }
}
