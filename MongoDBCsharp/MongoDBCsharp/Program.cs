using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace MongoDBCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostUrl = "Here_goes_url";
            string dbName = "cresory";
            var client = new MongoClient(hostUrl);
            var db = client.GetDatabase(dbName);
            var collection = db.GetCollection<players>("players");
            //insert
            //collection.InsertOne(new players { name = "Alex", userName = "itty12", password = "1234", age = 9 });

            //findOne
            collection.Find(p => p.userName == "ity");

            //update
            collection.UpdateOne(p => p.userName == "ity", Builders<players>.Update.Set(p=>p.age, 15));
            //delete

            //select

            var players = collection.Find(_ => true);
            foreach(var player in players.ToList())
            {
                Console.WriteLine($"Name={player.name}, userName={player.userName}, Age={player.age}, Parent={player.parent}");
            }
            Console.ReadKey();
        }
    }

        [BsonIgnoreExtraElements]
    public class players
    {
        [BsonId]

        public BsonValue? id { get; set; }
        public string? name { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }    
        public int? age { get; set; }
        public int? cresoCoins { get; set; }

        public bool?[] bRewards0 { get; set; }

        public bool?[] bRewards1 { get; set; }

        public bool?[] bRewards2 { get; set; }

        public bool?[] bRewards3 { get; set; }

        public bool?[] bRewards4 { get; set; }

        public int?[] iRewardsEquippedIndex { get; set; }

        public int?[] iStarsVideo { get; set; }
        
        public int?[] iStarsGame { get; set; }

        public int?[] iStarsQuiz { get; set; }

        public int?[] iScoreGame { get; set; }

        public int?[] iScoreGameMax { get; set; }

        public int?[] iScoreQuiz { get; set; }

        public int?[] iScoreQuizMax { get; set; }

        public float? fProgressValorar { get; set; }

        public float? fProgressAhorrar { get; set; }

        public float? fProgressInvertir { get; set; }

        public float? fProgressGestionar { get; set; }

        public BsonValue parent { get; set; }


    }
}

