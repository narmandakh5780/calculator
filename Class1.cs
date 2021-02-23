using System;

namespace Calculator_Lab2
{
    public class Memory
    {
        private double n = 0;
        public double GetSetValue
        {
            get { return n; }
            set { n = value; }
        }
        public void mc()
        {
            n = 0;
            Console.WriteLine("Санамжийг цэвэрлэх");
        }
        public void mPlus(double value)
        {
            n = n + value;
        }
        public void mMinus(double value)
        {
            n = n - value;
        }
    }
}
