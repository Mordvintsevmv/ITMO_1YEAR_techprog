using System;
namespace Progression
{
    public class ArithmeticProgression: Progression
    {
        public int a1 { get; set; }
        public int d { get; set; }

        public ArithmeticProgression(int a1, int d)
        {
            this.a1 = a1;
            this.d = d;
        }

        public override double GetElement(int k)
        {
            double element = this.a1 + this.d * (k - 1);
            return element;
        }
    }
}
