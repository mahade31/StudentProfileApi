using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentProfileApi.Models
{
    //[BsonIgnoreExtraElements]  //use this if there are any extra elements in the database
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("id")]
        public int StudentId { get; set; }

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("dept")]
        public string Dept { get; set; } = String.Empty;

        [BsonElement("uniName")]
        public string UniName { get; set; } = String.Empty;

        [BsonElement("contactNo")]
        public string ContactNo { get; set; } = String.Empty;

    }
}
