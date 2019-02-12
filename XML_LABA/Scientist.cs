using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_LABA
{
    class Scientist
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; }

        public Scientist()
        {
            Name = string.Empty;
            Faculty = string.Empty;
            Department = string.Empty;
            Degree = string.Empty;
            Status = string.Empty;
        }
    }

}
