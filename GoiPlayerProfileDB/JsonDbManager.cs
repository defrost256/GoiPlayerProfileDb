using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GoiPlayerProfileDB
{
    public class JsonDbManager
    {
        string path;
        private JObject root;
        private JArray players;
        private List<string> names;
        private int nameCount;

        public JsonDbManager(string path)
        {
            this.path = path;
            StreamReader reader = File.OpenText(path);
            root = JToken.ReadFrom(new JsonTextReader(reader)) as JObject;
            players = root["players"] as JArray;

            names = (from p in players
                            select (string)p["name"]).ToList();
            nameCount = names.Count;
        }

        public List<string> GetClosestNames(string name, int maxDistance = 5, int maxNum = int.MaxValue)
        {
            Dictionary<string, int> distances = new Dictionary<string, int>();
            foreach(string n in names)
            {
                distances.Add(n, StingDistanceComparer.Levenshtein(n, name));
            }
            return (from n in names
                    where distances[n] < maxDistance
                    orderby distances[n] descending, n
                    select n).Take(maxNum).ToList();
        }

        public bool HasName(string name)
        {
            return names.Contains(name);
        }
    }
}
