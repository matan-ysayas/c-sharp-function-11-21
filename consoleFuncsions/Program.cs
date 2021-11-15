using System;
namespace consoleFuncsions
{
    class Progrem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //printMyName(printName());

            //PrintHello(); //1

            //PrintMyName(); //2


            //GetName("ashakhskah");//3

            //GetNumber(55); //4

            //PrintUserNum(); //5

            //PrintHiOrBye(); //6

            //PrintSomeName(int.Parse(Console.ReadLine())); //7

            //PrintMyNum(int.Parse(Console.ReadLine())); //8

            //static void printMyName(string name ) //9

            //{
            //    Console.WriteLine(name);
            //}
            // static string printName()
            //{
            //    Console.WriteLine("enter a name");
            //    return Console.ReadLine();

            //}


            //int num1 = 8;     //10
            //int num2 = 8;
            //int num3 = 5;
            //int num4 = 5; 
            //Console.WriteLine(getSAvg( num1,num2,num3,num4));

            //Console.WriteLine(GetSum(num1, num2, num3, num4));


            //int width = 20;     //11
            //int height = 20;
            //Areya(height, width);


            //swich(10, 20); //12


            //GetMulti(); //13

            //GetNumbers();//14

            //Console.WriteLine(PlusOne()); //15

            //Triple();//16

            //Console.WriteLine(GetArea(5)); //17

            //Print100();//18

            //Print50();//19

            //Print49();//20

            //GetSumAndAvg();//21

            //GetMaxAndMin(); //22

            // getNum();//23

            // Model();//24

            //Random();//25

            //Rect(); //26
        }


        //*1*
        static void PrintHello()
        {
            Console.WriteLine("hello world");
        }

        //*2*
        static void PrintMyName()
        {
            Console.WriteLine("matan");
        }

        //*3*

        static void GetName(string name)
        {
            Console.WriteLine(name);
        }

        //*4*

        static void GetNumber(int num)
        {
            Console.WriteLine(num);
        }

        //*5*

        static void PrintUserNum()
        {
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine(userNum);
        }

        //*6*

        static void PrintHiOrBye()
        {
            int userNum = int.Parse(Console.ReadLine());
            if (userNum > 25) { Console.WriteLine("hi"); }
            if (userNum < 25) { Console.WriteLine("bye"); }


        }

        //*7*

        static void PrintSomeName(int num)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(num);
            }


        }

        //*8*

        static void PrintMyNum(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(num);
            }
        }


        //*9*

        static void PrintNameByNum(string name, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name);
            }
        }
        //*10*


        static float getSAvg(float num1, float num2, float num3, float num4)
        {
            float avg = (num1 + num2 + num3 + num4) / 4;
            return avg;
        }


        static int GetSum(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2 + num3 + num4;
            return sum;
        }


        //*11*

        static void Areya(int wid, int hig)
        {
            int are = wid * hig;
            Console.WriteLine(are);

        }

        //*12*

        static void swich(int num1, int num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        //*13*

        static void GetMulti()
        {
            int i = 0;
            int total = 1;
            while (i < 3)
            {
                int num = int.Parse(Console.ReadLine());
                total *= num;
                i++;
            }
            Console.WriteLine(total);

        }

        //*14*
        static void GetNumbers()
        {
            double first = int.Parse(Console.ReadLine());
            double second = int.Parse(Console.ReadLine());
            double result = first / second;
            Console.WriteLine(result);

        }

        //*15*

        static double PlusOne()
        {
            double userNum = double.Parse(Console.ReadLine());
            userNum++;
            return userNum;


        }

        //*16*
        static void Triple()
        {
            double num = double.Parse(Console.ReadLine());
            num *= 3;
            Console.WriteLine(num);
        }
        //*17*
        static string GetArea(double radius)
        {
            double area = (radius * radius) * 3.14;
            double round = (radius * 2) * 3.14;
            return ($" area:{area} round:{round}");
        }
        //*18*

        static void Print100()
        {
            int i = 0;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        //*19*

        static void Print50()
        {
            int i = 0;
            while (i <= 50)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }

        //*20*

        static void Print49()
        {
            int i = 1;
            while (i <= 49)
            {
                Console.WriteLine(i);
                i += 3;
            }
        }

        //*21*

        static void GetSumAndAvg()
        {
            int sum = 0;
            int i = 0;
            while (i < 5)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                i++;
            }
            int avg = sum / 5;

            Console.WriteLine($"avg:{avg} sum:{sum} ");
        }
        //*22*
        static void GetMaxAndMin()
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int i = 0;
            while (i < 5)
            {
                int someNum = int.Parse(Console.ReadLine());
                if (someNum < min) { min = someNum; }
                if (someNum > max) { max = someNum; }
                i++;

            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
        //*23*
        static void getNum()
        {

            Console.WriteLine("Enter 5 numbers");
            int userNum = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            while (userNum > 0)
            {
                maxNumber = Math.Max(maxNumber, userNum);
                minNumber = Math.Min(minNumber, userNum);
                userNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);

        }
        //*24*

        static void Model()
        {
            double num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                double last = num % 10;
                num = num / 10 - last / 10;
                Console.WriteLine(last);
            }

        }

        //*25*

        static void Random()
        {
            Random random = new Random();
            int rand = random.Next(0, 100);
            Console.WriteLine(rand);
            bool win = false;
            while (win == false)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == rand)
                {
                    Console.WriteLine("you win");
                    win = true;
                }
                if (num < rand)
                {
                    Console.WriteLine("to low");
                }
                else if (num > rand)
                    Console.WriteLine("to hight");
            }
        }
         //*26*

        static void Rect()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }


    }
}
    