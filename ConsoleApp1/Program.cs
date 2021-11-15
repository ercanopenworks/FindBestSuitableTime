using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static string ArrayChallenge(string[] strArr)
        {

            // code goes here  
            string result = "";
            TimeSpan difMax;

            List<DateTime> eventList = new List<DateTime>();

            for (int i = 0; i < strArr.Length; i++)
            {
                var temp = strArr[i].Split("-");
                eventList.Add(Convert.ToDateTime(temp[0]));
                eventList.Add(Convert.ToDateTime(temp[1]));
            }
            eventList.Sort();

            difMax = eventList[2] - eventList[1];

            for (int i = 2; i < eventList.Count; i+=2)
            {
                var dif = eventList[i] - eventList[i - 1];

                if (dif > difMax)
                    difMax = dif;

            }

            result = difMax.ToString("hh':'mm''");
            return result;

        }

        static void Main()
        {
            // keep this function call here


            //var input = new string[] { "12:15PM-02:00PM", "09:00AM-10:00AM", "10:30AM-12:00PM" };

            var input = new string[] { "12:15PM-02:00PM", "09:00AM-12:11PM", "02:02PM-04:00PM" };

            Console.WriteLine(ArrayChallenge(input));
        }
    }
}
