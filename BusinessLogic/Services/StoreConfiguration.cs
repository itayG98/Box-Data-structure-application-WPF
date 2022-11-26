using Newtonsoft.Json;

namespace BusinessLogic.Services
{
    /// <summary>
    /// Configuration data loader from local jason file
    /// </summary>
    public class StoreConfiguration
    {
        public ConfigData ConfigData { get; private set; }

        public StoreConfiguration()
        {
            var currentDir = Environment.CurrentDirectory;
            var fileName = "StoreConfig.json";
            var configPath = Path.Combine(currentDir, fileName);
            var raw = File.ReadAllText(configPath);
            ConfigData = JsonConvert.DeserializeObject<ConfigData>(raw);
        }
    }

    /// <summary>
    /// Object represeting the propeties to load from the cinfiguration jason file
    /// </summary>
    public class ConfigData
    {
        public double LIMIT_PERCENTAGE { get; set; }
        public int MAX_BOXES_PER_SIZE { get; set; }
        public int MIN_BOXES_PER_SIZE { get; set; }
        public int MAX_DAYS { get; set; }

    }
}