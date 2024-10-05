using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Storage
    {
        public string Model { get; }
        public Storage(string model)
        {
            Model = model;
        }
    }
}
