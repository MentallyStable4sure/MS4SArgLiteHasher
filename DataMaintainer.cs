using Microsoft.Win32;

namespace MS4SArgHasher.Data
{
    internal class DataMaintainer
    {
        public const string USER_ROOT_REGISTRY = "HKEY_CURRENT_USER";
        public const string REGISTRY_KEY = "MS4S";


        public string RegistryKey { get; private set; }

        public DataMaintainer() => RegistryKey = $"{USER_ROOT_REGISTRY}\\{REGISTRY_KEY}";

        public void Save(string key, string value)
        {
            Registry.SetValue(RegistryKey, key, value);
        }

        public string Load(string key)
        {
            string value = (string)Registry.GetValue(RegistryKey, key, string.Empty);
            if (value == null) value = string.Empty;
            return value;
        }

        public void Delete(string key)
        {
            Registry.CurrentUser.DeleteSubKey(key);
        }
    }
}
