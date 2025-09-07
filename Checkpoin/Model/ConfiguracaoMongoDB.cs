namespace Checkpoint.Model
{
    public class ConfiguracaoMongoDB
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string BookCollectionName { get; set; } = null!;
    }
}