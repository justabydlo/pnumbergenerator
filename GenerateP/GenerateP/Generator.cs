using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateP
{
    class Generator
    {
        public long dots { get; set; }
        public bool with_logs { get; set; }

        private Random rand = new Random();
        private float PloatPnumber()
        {
            double x, y = 0;
            float equation = 0;
            float in_circle = 0;

            for(int i = 0; i <= dots; i++)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();
                equation = (float)(Math.Pow(x, 2) + Math.Pow(y, 2));
                if(equation <= 1)
                {
                    in_circle++;
                }
            }

            return 4 * in_circle / dots;
        }

        public float GetPnumber()
        {
            return PloatPnumber();
        }
    }
}
