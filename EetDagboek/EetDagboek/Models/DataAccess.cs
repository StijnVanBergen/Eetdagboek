using MongoDB.Driver;
using MongoDB.Driver.Core;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EetDagboek.Models
{
    public class DataAccess
    {
        private readonly IMongoDatabase _database = null;

        public DataAccess()
        {
            var client = new MongoClient(new MongoUrl("mongodb://136.144.132.108:27017"));
            if (client != null)
            {
                _database = client.GetDatabase("EetDagboek");
            }
        }

        
        public IMongoCollection<Dag> Dag
        {
            get
            {
                return _database.GetCollection<Dag>("Dag");
            }
        }

        public IMongoCollection<Maaltijd> Maaltijd
        {
            get
            {
                return _database.GetCollection<Maaltijd>("Maaltijd");
            }
        }

    }
}