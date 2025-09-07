using MongoDB.Bson.Serialization.Attributes;

namespace Checkpoint.Model
{
    public class Livro
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Titulo")]
        public string Titulo { get; set; }

        [BsonElement("AnoPublicacao")]
        public int AnoPublicacao { get; set; }
        [BsonElement("Autor")]
        public Autor Autor { get; set; }
    }
}
