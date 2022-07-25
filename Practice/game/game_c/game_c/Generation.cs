using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_c
{
    class Generator
    {
        Random rand;
        public Generator()
        {
            rand = new Random();
        }
        public int random()
        {
            int res = rand.Next(1, 10);
            return (res);
        }
    }
}
