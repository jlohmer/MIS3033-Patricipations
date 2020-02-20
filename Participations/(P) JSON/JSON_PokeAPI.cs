using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__JSON
{
    class AllPokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<AllPokemonResult> results { get; set; }
    }

    public class AllPokemonResult
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
    public class pokieInfo
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public Sprite image { get; set; }

        public override string ToString()
        {
            return image;
        }
    }

    public class Sprite
    {
        string front_default { get; set; }
    }
}
