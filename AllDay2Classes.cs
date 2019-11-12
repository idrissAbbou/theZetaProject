using System.Collections.Generic;
using System.IO;
using System;

namespace AllDay2Classes
{
    public delegate bool FilterHandler(int i); // functions pointer
    public delegate void MeDel(string message);
    public delegate void MapDel(int i);
    public class Day2 {
        static public void myFunc(){
            // int[] arr = new int[] {5,4,10,2,1,3,9,8,7};
            // IEnumerable<int> result = arr.Filter(i=> i%3 == 0);
            // foreach (var item in result)
            // {
            //     System.Console.WriteLine(item);
            // }


            // MeDel del = new MeDel(SayMessage);
            // del += WriteMessageToAFile;
            // // del -= WriteMessageToAFile;

            // del.Invoke("this is a message from MeDel");

            // Action<int> ac;
            // ac = new Action<int>((int i) => {
            //      Console.WriteLine($"this my ac delegate: {i}");
            // });
            // ac += i => Console.WriteLine($"this my ac: {i}");

            // ac.Invoke(9999999);
            // ManipulateDel(Map1, 2,5,6,7,8,9,4,6,2,1,9);

            // int[] arrs = new int[] {3,5,6,7,9,10,4,5,1,4,2};
            // IEnumerable<int> meResult = arrs.Filter(i => i%3 ==0);
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // foreach (var item in meResult)
            // {
            //     System.Console.WriteLine(item);
            // }

            // Action<string> meDel2 = new Action<string>((string m)=> {
            //     Console.BackgroundColor = ConsoleColor.Red;
            //     Console.WriteLine(m);
            // });
            // meDel2 += (string m) => {
            //     File.WriteAllText("./foo.txt", m);
            // };

            // meDel2("this is a message");

            // Func<bool, int, float, string> f;
            // Action<string> la3natSamawiya = new Action<string>(FuckAyWa7dMaKay7mlchYuGiOh);
            // la3natSamawiya.Invoke("morad");

            // GoToHeaven("alhamo lilahi kabira, sob7ana lahi wa bi7amdih");
        }

        static void FuckAyWa7dMaKay7mlchYuGiOh(string name) {
            Console.ForegroundColor = ConsoleColor.Red;
            while(true)
            {
                System.Console.WriteLine($"la3na 3la mok ya {name}");
            }
        }

        static void GoToHeaven(string message) {
            while (true)
            {
                System.Console.WriteLine(message);
            }
        }

        static bool twoFilter(int i) {
            return i % 2 == 0;
        }

        static void Map1(int i) {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(i);
        }

        static void SayMessage(string message) {
            System.Console.WriteLine(message);
        }

        static void WriteMessageToAFile (string message){
            File.WriteAllText("./text.txt", message);
        }

        public static void ManipulateDel(MapDel map, params int[] args) {
            foreach (var item in args)
            {
                map(item);
            }
        }
    }

    //extension classes
    public static class HelperMethods {
        public static IEnumerable<int> Filter(this IEnumerable<int> agrs,  FilterHandler filter) {
            foreach (var i in agrs)
            {
                if (filter(i))
                {
                    yield return i;
                }
            }
        }
    }

    
}