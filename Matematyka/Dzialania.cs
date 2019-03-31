using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyka
{
    class Dzialania
    {
         public int DanaEasyDodawanie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 10;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int DanaNormalDodawanie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 20;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int DanaHardDodawanie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 50;
            return number1.Next(rangeFrom, rangeTo);
        }


        public int Dana1EasyOdejmowanie()
        {
            Random number1 = new Random();
            int rangeFrom = 10;
            int rangeTo = 20;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int Dana2EasyOdejmowanie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 10;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int Dana1NormalOdejmowanie()
        {
            Random number1 = new Random();
            int rangeFrom = 20;
            int rangeTo = 30;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int Dana2NormalOdejmowanie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 20;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int Dana1HardOdejmowanie()
        {
            Random number1 = new Random();
            int rangeFrom = 30;
            int rangeTo = 50;
            return number1.Next(rangeFrom, rangeTo);
        }
        public int Dana2HardOdejmowanie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 30;
            return number1.Next(rangeFrom, rangeTo);
        }
        public int DanaEasyMnozenie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 4;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int DanaNormalMnozenie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 8;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int DanaHardMnozenie()
        {
            Random number1 = new Random();
            int rangeFrom = 0;
            int rangeTo = 12;
            return number1.Next(rangeFrom, rangeTo);
        }
        public int Dana1EasyDzielenie()
        {
            Random number1 = new Random();
            int rangeFrom = 10;
            int rangeTo = 20;
            return number1.Next(rangeFrom, rangeTo);
        }
        public int Dana2EasyDzielenie()
        {
            Random number1 = new Random();
            int rangeFrom = 1;
            int rangeTo = 10;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int Dana1NormalDzielenie()
        {
            Random number1 = new Random();
            int rangeFrom = 20;
            int rangeTo = 30;
            return number1.Next(rangeFrom, rangeTo);
        }
        public int Dana2NormalDzielenie()
        {
            Random number1 = new Random();
            int rangeFrom = 1;
            int rangeTo = 20;
            return number1.Next(rangeFrom, rangeTo);
        }
        
        public int Dana1HardDzielenie()
        {
            Random number1 = new Random();
            int rangeFrom = 30;
            int rangeTo = 100;
            return number1.Next(rangeFrom, rangeTo);
        }

        public int Dana2HardDzielenie()
        {
            Random number1 = new Random();
            int rangeFrom = 1;
            int rangeTo = 50;
            return number1.Next(rangeFrom, rangeTo);
        }

    }
}
