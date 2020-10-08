using System;

namespace Jaba1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TTringle triangle1 = new TTringle(5, 4, 1 );
            triangle1.SideC = 1;
            triangle1.SideB = 2;
            Console.WriteLine(triangle1.SideA + " " + triangle1.SideB + " " + triangle1.SideC);
            Console.WriteLine("P = " + triangle1.CalculatePerimeter());
            Console.WriteLine("S = " + triangle1.CalculateArea());
        }
    }

    class TTringle
    {
        protected double lengthA;
        protected double lengthB; //Поля(protected) повинні містити дані про довжини сторін(для кожної з трьох сторін своє поле).
        protected double lengthC;

        public TTringle(double a, double b, double c)
        {
            if (a + b >= c && b + c >= a && a + c >= b)
            {
                lengthA = a;
                lengthB = b;
                lengthC = c;
            }
            else
            {
                Console.WriteLine("Не існує");
            }
        }  //перевіряємо чи існує трикутник

       
        public double SideA
        {
            get
            {
                return lengthA; //оторимання довжини сторони 
            }
            set
            {
                if (value > 0 && value + lengthB >= lengthC && value + lengthC >= lengthB && lengthB + lengthC >= value) // перевірка чи існує трикутник
                {
                    lengthA = value; // задання довжини
                }
            }
        }
        public double SideB
        {
            get
            {
                return lengthB;
            }
            set
            {
                if (value > 0 && lengthA + value >= lengthC && lengthA + lengthC >= value && value + lengthC >= lengthA)
                {
                    lengthB = value;
                }
            }
        } /* конструктор, який заповнює всі три довжини (перевіряючи можливість існування такого трикутника), 
           * отримання(get) довжини сторони(три окремі методи, для кожної сторони свій) задання(set) довжини сторони(три окремі методи, для кожної сторони свій;
           * перевіряти можливість існування такого трикутника, де ця одна сторона змінена, а решта дві лишаються, які були);
           */
        public double SideC
        {
            get
            {
                return lengthC;
            }
            set
            {
              
                if (value > 0 && lengthA + lengthB >= value && lengthA + value >= lengthB && lengthB + value >= lengthA)
                {
                    lengthC = value;
                }
            }
        }
        public double CalculatePerimeter()
        {
            return (lengthA + lengthB + lengthC);
        } //знаходимо периметр a + b + c
        public double CalculateArea()
        {
            
            return (lengthA + lengthB + lengthC) /2  ;
        } //знаходимо площу за формулою Герона P = (a + b + c)/2
    } //клас TTriangle для подання трикутника
}
