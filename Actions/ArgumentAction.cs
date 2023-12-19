using MS4SArgHasher.Data;

namespace MS4SArgHasher.Actions
{
    internal class ArgumentAction : IAction
    {
        private string[] arguments;
        private DataMaintainer dataMaintainer = new DataMaintainer();

        public string[] GetData()
        {
            throw new NotImplementedException();
        }

        public void SetData(params string[] datas) => arguments = datas;

        /// <summary>
        /// Check for --compare or --compute args and does the action, 
        /// results in Registry.CurrentUser inside "MS4S" Folder
        /// </summary>
        /// <param name="command">argument, either --compare or --compute</param>
        private void RunArg(string command)
        {
            switch (command)
            {
                case "--compare":
                    var comparer = new CompareAction();
                    comparer.SetData(arguments);
                    dataMaintainer.Save(CompareAction.DATA_MAINTAINER_KEY, comparer.Compare().ToString());
                    break;

                case "--compute":
                    var hash = new HashAction();
                    hash.SetData(arguments);
                    dataMaintainer.Save(HashAction.DATA_MAINTAINER_KEY, hash.FilePath);
                    break;

                default:
                    Console.WriteLine("[ERROR] Nothing to do, either use --compute or --compare args");
                    Console.ReadKey();
                    break;

            }
        }

        public void Start() => RunArg(arguments[0]);
    }
}
