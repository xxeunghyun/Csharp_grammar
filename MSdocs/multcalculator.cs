

using System;

namespace calculator
{
    //연산식 진행하는 함순
    class calculator
    {
        //public 이니까 후에 다른 데서도 쓸 수 있
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;  //NaN은 기본 Not a Number

            switch(op)
            {
                case "a":
                    result = num1 + num2;
                    break;

                case "s":
                    result = num1 - num2;
                    break;

                case "m":
                    result = num1 * num2;
                    break;

                case "d":
                    if(num2 != 0)   //0이 아닐 때만 식 진행
                    {
                        result = num1 / num2;
                    }
                    break;

                default:    //위에 네개 외에 입력값이라면
                    break;
            }

            return result;
        }
    }

    class program
    {
        //void니까 리턴 값 없어도 됨
        static void Main(string[] args)
        {
            bool endapp = false;

            Console.WriteLine("Welcome to console calculator\n");

            while(!endapp) // =true,항상계속
            {
                string input1 = "";
                string input2 = "";
                double result = 0;

                Console.WriteLine("Type a number and press Enter key");
                input1 = Console.ReadLine();

                double cleannum1 = 0;

                while(! (double.TryParse(input1, out cleannum1))) //반환 값은 변환이 성공했는지 실패했는지를 나타냄, 정수로 입력할 때까지 돌리기
                {
                    Console.WriteLine("This is not valid input. Please enter an 'integer' value!");
                    input1 = Console.ReadLine();
                }


                Console.WriteLine("Type a number and press Enter key");
                input2 = Console.ReadLine();

                double cleannum2 = 0;

                while (!double.TryParse(input2, out cleannum2))
                {
                    Console.WriteLine("This is not valid input. Please enter and 'integer' value!");
                    input2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operation");
                Console.WriteLine("\ta - addition");
                Console.WriteLine("\ts - subtraction");
                Console.WriteLine("\tm - multiplication");
                Console.WriteLine("\td - division");

                Console.WriteLine("Please choose the option");

                string op = Console.ReadLine();

                try
                {
                    result = calculator.DoOperation(cleannum1, cleannum2, op);
                    if (double.IsNaN(result))
                    {       //넘2가 0이고 나누기를 하려할 때 에러메세지 띄워주기

                        Console.WriteLine("*** Mathematical error occurs\n");
                    }

                    else
                        Console.WriteLine("Your result: " + result.ToString() + "\n");
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Exception occreed!\nreason: "+ex.Message);
                }

                Console.WriteLine("Calculation is done!\nPress 'n' 'Enter' keys to close the app");

                if (Console.ReadLine() == "n")
                    endapp = true; //while문 빠져나오ㄱ
            }
            return;
        }
    }
}