using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EetDagboek.Models
{
    public class Dag
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("Maaltijd")]
        public List<Maaltijd> Maaltijden { get; set; }

        [BsonElement("Gevoel")]
        public string Gevoel { get; set; }

        [BsonElement("Datum")]
        public DateTime Datum { get; set; }
    }

    public class Maaltijd
    {
        [BsonId]
        public int ID { get; set; }

        public List<string> Voedsel { get; set; }

        public Dag Dag { get; set; }
    }
}