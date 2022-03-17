using System;
using System.Collections.Generic;
using System.Text;

namespace StringTestProject
{
    class Program
    {
        #region Constants
        
        private const int CountOfLettersToRemove = 5;
        private const int CountOfCycles = 50000;

        #endregion

        #region Methods

        static void Main(string[] args)
        {
            #region Reference

            //string string1 = "Hello world";
            //string string2 = "Hello world";

            //bool isEquals = string1 == string2;
            //Console.WriteLine(isEquals.ToString()); //true

            #endregion

            #region Immutable

            #region 1

            //string s1 = "Hello ";
            //string s2 = s1;
            //s1 += "World";

            //Console.WriteLine(s2); //hello world

            #endregion

            #region 2

            //string someString = "Hello world";

            //someString.Remove(CountOfLettersToRemove);
            //Console.WriteLine(someString);

            //string anotherString = someString.Remove(CountOfLettersToRemove);
            //Console.WriteLine(anotherString);

            #endregion

            #region 3

            var immutubleString = "Strings are immutable";

            #region 3.1

            //for (int i = 0; i < immutubleString.Length; i++)
            //{
            //    Console.WriteLine(immutubleString[i]);
            //}

            #endregion

            #region 3.2

            //int length = immutubleString.Length;
            //for (int i = 0; i < length / 2; i++)
            //{
            //    char c = immutubleString[i];
            //    immutubleString[i] = immutubleString[length - i - 1];
            //    immutubleString[length - i - 1] = c;
            //}

            #endregion

            #endregion

            #endregion

            #region Performance

            //List<string> stringList = FillStringList();

            //CreateByString(stringList);
            //CreateByStringBuilder(stringList);

            #endregion

            Console.ReadKey();
        }
        
        #region Helpers

        private static List<string> FillStringList()
        {
            List<string> stringList = new List<string>();

            for (int i = 0; i < CountOfCycles; i++)
            {
                stringList.Add(i.ToString());
            }

            return stringList;
        }
        
        private static string CreateByString(List<string> stringList)
        {
            string result = default;

            Console.WriteLine($"{DateTime.Now} Start");

            foreach (string s in stringList)
            {
                result += s;
            }

            Console.WriteLine($"{DateTime.Now} Done");
            return result;
        }

        private static string CreateByStringBuilder(List<string> stringList)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine($"{DateTime.Now} Start");

            foreach (string s in stringList)
            {
                stringBuilder.Append(s);
            }

            Console.WriteLine($"{DateTime.Now} Done");

            return stringBuilder.ToString();
        }

        #endregion
        
        #endregion
    }
}
