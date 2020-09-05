/*
간단한 사칙연산을 하는 프로그램 짜기
나누는 값이 0일 때 num2의 값을 재입력하게 하는 라인 짜기
*/

using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n1 = 0, n2 = 0;
            //int sum = 0;
            //Convert.ToInt32(sum);

            //맨처음 콘솔창 디버그할 때 보이는 텍스트
            Console.WriteLine("welcome to console calculator");
            Console.WriteLine("\n");

            //사용자의 입력값 받기
            Console.WriteLine("Please enter the value for num1 ");
            n1 = Convert.ToDouble(Console.ReadLine());
            //아스키코드로 출력 되기 때문에 컨버트 함수 이용 + 콘솔창에서 입력받

            Console.WriteLine("\nPlease enter the value for num2 ");
            n2 = Convert.ToDouble(Console.ReadLine());

            //사칙연산 중 고르기
            Console.WriteLine("Which calculation do you need?");
            Console.WriteLine("option a - Addition");
            Console.WriteLine("option b - Subsraction");
            Console.WriteLine("option c - Multiplication");
            Console.WriteLine("option d - Division");

            Console.WriteLine("\nPlease enter one of them");

            //콘솔창에서 입력받은 알파벳 값이 case 일 때 
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Addition\n>>num1 + num2 = " + (n1 + n2).ToString());
                    break;

                case "b":
                    Console.WriteLine("Subtraction\n>>num1 - num2 = " + (n1 - n2).ToString());
                    break;

                case "c":
                    Console.WriteLine("Multiplication\n>>num1 * num2 = " + (n1 * n2).ToString());
                    break;

                //나누는 수가 0일 때 생기는 오류 수정을 위해 while문 추
                case "d":

                    while (n2 == 0)
                    {
                        Console.WriteLine("Divider should be bigger than 0, Re-enter num2");
                        n2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine("Division\n>>num1 / num2 = " + (n1 / n2).ToString());
                        break;

                    }

                    //창 닫을 때 텍스트
                    Console.WriteLine("\nPlease enter any key to end the programme");
                    Console.ReadKey();

            }
        }
    }
