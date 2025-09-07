using MongoDB.Bson.Serialization.Attributes;

namespace Checkpoint.Model
{
    public class Autor
    {
        [BsonElement("Nome")]
        public string Nome { get; set; }

        [BsonElement("Nacionanlidade")]
        public string Nacionalidade { get; set; }

    }
}
