using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_LABA
{
    interface IStrategy
    {
        List<Scientist> Search(Scientist scientist, string path);
    }

    class Strategy
    {
        public Scientist scientist;
        public string path;
        
        public Strategy(IStrategy strategy, Scientist scientist, string path)
        {
            this.scientist = scientist;
            this.Strateg = strategy;
            this.path = path;
        }

        public IStrategy Strateg { private get; set; }

        public List<Scientist> SearchAlgorithm()
        {
            return Strateg.Search(scientist, path);
        }
    }
}
