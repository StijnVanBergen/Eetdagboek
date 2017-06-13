using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EetDagboek.Models
{
    public class Maaltijd
    {
        [BsonId]
        public string ID { get; set; }

        [BsonElement("Titel")]
        public string Titel { get; set; }

        [BsonElement("Voedsel")]
        public List<string> Voedsel { get; set; }

        [BsonElement("Gevoel")]
        public string Gevoel { get; set; }

        [BsonElement("Datum")]
        public DateTime Datum { get; set; }
    }


    public class DeSerializeMaaltijd
    {
        public string Titel { get; set; }

        public List<string> Voedsel { get; set; }

        public string Gevoel { get; set; }

        public long Datum { get; set; }
    }
}