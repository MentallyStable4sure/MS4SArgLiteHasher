
namespace MS4SArgHasher.Actions
{
    internal interface IAction
    {
        public void Start();

        public string[] GetData();
        public void SetData(params string[] datas);
    }
}
