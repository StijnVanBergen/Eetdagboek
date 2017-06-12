﻿using MongoDB.Bson;
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
        public DateTime Datum { get; set; }

        [BsonElement("Titel")]
        public string Titel { get; set; }

        [BsonElement("Voedsel")]
        public List<string> Voedsel { get; set; }

        [BsonElement("Gevoel")]
        public string Gevoel { get; set; }
    }
}