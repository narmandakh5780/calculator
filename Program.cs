using System;
using System.Collections.Generic;
using System.Linq;
namespace Calculator_Lab2
{
    class CalculatorBase
    {
        private static List<Memory> memory = new List<Memory>(15);
        public static Memory _memory = new Memory();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Нэмэх үйлдэл: add,  Хасах үйлдэл: minus, Тэнцүү: equal, MC: mc, MR: mr, M+: mPlus, M-: mMinus, MS: ms, C: clear, CE: ce\n ");
                string command = Console.ReadLine();
                inputCommand(command);
            }
        }

        public static double[] readNumber()
        {
            Console.WriteLine("A тоог оруулна уу: \n");
            double a = Convert.inputCommand(Console.ReadLine());
            Console.WriteLine("Б тоог оруулна уу: \n");
            double b = Convert.inputCommand(Console.ReadLine());
            double[] arr = { a, b };
            return arr;
        }
        public static void inputCommand(string command)
        {
            switch (command)
            {
                case "add":
                    addNumbers();
                    break;
                case "minus":
                    minusNumbers();
                    break;
                    /*
                case "equal":
                    equalNumbers();
                    break;
                    */
                case "clear":
                    clearNumbers();
                    break;
                case "mc":
                    mcMemory();
                    break;
                case "mr":
                    mrMemory();
                    break;
                case "mPlus":
                    mPlusMemory();
                    break;
                case "mMinus":
                    mMinusMemory();
                    break;
                case "ms":
                    msMemory();
                    break;
                case "ce":
                    ceMemory();
                    break;
                default: break;
            }
        }
        public static void addNumbers()
        {
            var array = readNumber();
            Console.WriteLine("Нийлбэр дүн : \n", array.Sum());
        }
        public static void minusNumbers()
        {
            var array = readNumber();
            Console.WriteLine("Ялгавар: \n", array[0] - array[1]);

        }
        /*
        public static void equalNumbers()
        {
            var array = readNumber();
            Console.WriteLine("Тэнцүү");
        }
        */
        public static void clearNumbers()
        {
            var array = readNumber();
            Console.WriteLine("Нэг тоо устгах", array.Length-1);
        }
        public static void mcMemory()
        {
            var array = readNumber();
            Console.WriteLine("Санах ой цэвэрлэх", array.<Memory>Empty<Memory>);
        }
        public static void mrMemory()
        {
            Memory.mr();
        }
        public static void mPlusMemory()
        {
            Memory.mPlus();
        }
        public static void mMinusMemory()
        {
            Memory.mMinus();
        }
        public static void msMemory()
        {
            Memory.ms();
        }
        public static void ceMemory()
        {
            Memory.ce();
        }

    }
}
