using System;
using System.Collections;
using System.Collections.Generic;

namespace MyClasses
{
    //how to declare struct and enum
    #region struct and enum
    public struct Box
    {
        public int height;
        public int weidth;

    }
    public enum weekdays
    {
        red, yellow, blue
    }
    #endregion
    /*-----------------------------------------------------------------------------------------------------*/
    //how to declare a generic class
    class AllTypes<T>
    {
        T value;
        public AllTypes(T value)
        {
            this.value = value;
        }

        public T result()
        {
            return this.value;
        }
    }
    /*-----------------------------------------------------------------------------------------------------*/
    #region Day1 classes
    //all day 1 functions and operations are in the Day1 class
    public class Day1
    {
        #region yeasterday work
        public static void YeasterdayWorkOperations()
        {

            myFunxtion(y: 5, i: 4, s: "hello");
            System.Console.WriteLine(sum(1, 5, 3));
            System.Console.WriteLine(sum(1, 2, 5, 6, 4, 8));
            weekdays w = weekdays.blue;
            int x = (int)w;


            int[] arr = new int[] { 1, 2, 3, 4, 96 };
            int[] arr2 = new int[10];

            arr.CopyTo(arr2, 2);
            Array.Reverse(arr);
            //how to sort an array
            var people = new Person[3] {
                new Person() { name="zid", age=18},
                new Person() { name="hasan", age=55},
                new Person() { name="sami", age=24}
            };
            Array.Sort(people);
            foreach (var per in people)
            {
                System.Console.WriteLine(per.name);
            }

            People people2 = new People();
            foreach (Person person in people2)
            {
                System.Console.WriteLine(person.name);
            }

            Swit s = new Swit();
            foreach (int i in s)
            {
                System.Console.WriteLine(i);
            }


            PrintArray(arr, ConsoleColor.Red);

            PrintArray(arr2, ConsoleColor.Blue);

            ITalk t = new Coder();
            t.HelloWorld("message");
            var people3 = new List<ITalk>() {
                new Person() { name="me", age=18},
                new Coder()
            };
            foreach (var per in people)
            {
                per.HelloWorld("message");
            }
        }
        #endregion


        #region functions
        static void PrintArray<T>(IEnumerable<T> args, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (var item in args)
            {
                Console.Write($"{item},");
            }
            System.Console.WriteLine();
        }
        static void myFunxtion(int i, int y, string s)
        {
            Console.WriteLine(i);
        }
        static int sum(params int[] args)
        {
            int result = 0;
            foreach (var i in args)
            {
                result += i;
            }
            return result;
        }
        #endregion
    }
    /*-----------------------------------------------------------------------------------------------------*/
    //how to declare and implement inrterfaces
    interface ITalk
    {
        void HelloWorld(string message);
    }
    public class Person : ITalk, IComparable
    {
        public string name;
        public int age;
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int CompareTo(object obj)
        {
            Person o = (Person)obj;
            if (o.age > this.age) return 1;
            else if (o.age < this.age) return -1;
            else return 0;
        }

        public void HelloWorld(string message)
        {
            System.Console.WriteLine($"person hello this: {message}");
        }
    }
    class Coder : ITalk
    {
        public void HelloWorld(string message)
        {
            System.Console.WriteLine($"coder echo {message}");
        }
        public void code()
        {

        }
    }
    public class People : IList<Person>
    {
        List<Person> people;
        public People()
        {
            people = new List<Person>() {
                new Person("said", 30),
                new Person("mo3ad", 40),
                new Person("salwa", 50)
            };
        }

        public Person this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Person item)
        {
            people.Add(item);
        }

        public void Clear()
        {
            people.Clear();
        }

        public bool Contains(Person item)
        {
            return people.Contains(item);
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return people.GetEnumerator();
        }

        public int IndexOf(Person item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Person item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class oj : ICollection
    {
        public int Count => 1;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class Swit
    {

        List<int> nums = new List<int>() { 2, 9, 8, 7, 6, 4 };
        public IEnumerator<int> GetEnumerator()
        {
            return nums.GetEnumerator();
        }
    }
    #endregion

}
