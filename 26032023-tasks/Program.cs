using System;
using System.Text;

namespace _26032023_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();

            ////MakeSentence(ref word);
            //Console.WriteLine(CheckFullName(word));

            int[] numbers = { 1, 2, 3, 4, 5, };
            int num = 7;
            num = 9;
            AddNumToArr(ref numbers, num);  

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }

        static void MakeSentence(ref string str)
        {
            //string newStr = "";
            StringBuilder stringBuilder = new StringBuilder();
            bool lastIsIndex = false;
            for (int i = 0; i < str.Length; i++)
            {
                //You have to write code
                //if ((newStr.Length > 0 && newStr[newStr.Length - 1] != ' ') || str[i] != ' ')
                //{
                //    newStr += str[i];
                //}
                //////////////////////////////////////////

                //if ((stringBuilder.ToString().Length>0 && stringBuilder.ToString()[stringBuilder.ToString().Length - 1] != ' ') || str[i] != ' ') 
                //{
                //    stringBuilder.Append(str[i]);
                //}

                if (str[i] != ' ')
                {
                    stringBuilder.Append(str[i]);
                    lastIsIndex = false;
                }
                else if (!lastIsIndex)
                {
                    stringBuilder.Append(str[i]);
                    lastIsIndex = true;
                }
            }

            str = stringBuilder.ToString();
        }

        static bool CheckPassword(string str)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    hasDigit = true;
                }
                else if (char.IsUpper(str[i]))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(str[i]))
                {
                    hasLower = true;
                }


                if (hasDigit && hasLower && hasUpper)
                {
                    return true;
                }
            }
            return false;
        }


        static bool CheckFullName(string str)
        {
            MakeSentence(ref str);
            string[] words = str.Split(' ');
            int counter = 0;
            foreach (var item in words)
            {
                if (char.IsUpper(item[0]))
                {
                    counter++;
                }
                if (counter == 2)
                {
                    return true;
                }

            }
            return false;
        }

        static void AddNumToArr(ref int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
    }
}
