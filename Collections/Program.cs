using Collections.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(6);
            //nums.Add(7);
            //nums.Add(8);
            //nums.Add(9);





            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 5)
            //{
            //    Console.WriteLine("List Count is {0}", nums.Count);
            //}

            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "Arif";
            //person1.Id = 6;
            //person1.Email = "Arifgh@mail.ru";

            //Person person2 = new Person
            //{
            //    Id=8,
            //    Name="Qedir",
            //    Email="Qedir@mail.ru"


            //};

            //people.Add(person1);
            //people.Add(person2);

            //people.Add(new Person { Id = 1, Name = "Huseyn", Email = "huseynnj@mail.ru" });
            //people.Add(new Person { Id = 2, Name = "Huseyn", Email = "orxan@mail.ru" });
            //people.Add(new Person { Id = 8, Name = "Orxan", Email = "orxan1@mail.ru" });
            //people.Add(new Person { Id = 3, Name = "Seid", Email = "Seid@mail.ru" });
            //people.Add(new Person { Id = 4, Name = "Cavid", Email = "Cavid@mail.ru" });
            //people.Add(new Person { Id = 5, Name = "Maqa", Email = "maqa@mail.ru" });

            //GetStudents(people);
            //GetNumbers(nums);

            //var result = GetPersonByName(people, "Huseyn");
            //Console.WriteLine(result.Name + "-" + result.Id + "-" + result.Email + "-");

            //var result = GetPeopleByName(people, "Huseyn");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + "-" + item.Id + "-" + item.Email + "-");
            //}

            //Hashtable datas = new Hashtable();
            //datas.Add(1, "Huseyn");
            //datas.Add(2, "Arif");
            //datas.Add(3, "Hesen");
            //datas.Add(4, "Eli");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList datas = new SortedList();
            //datas.Add(1, "Huseyn");
            //datas.Add(5, "Arif");
            //datas.Add(34, "Hesen");
            //datas.Add(4, "Eli");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList<int, string> datas = new SortedList<int, string>(); //classda yazmaq olur
            //datas.Add(6, "Huseyn");
            //datas.Add(4, "Azer");

            //foreach (KeyValuePair<int,string> item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //ArrayList datas = new ArrayList();

            //datas.Add("Salam");
            //datas.Add(5);
            //datas.Add(true);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<int> datas = new HashSet<int>();
            //datas.Add(1);
            //datas.Add(5);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> datas = new Stack<int>();
            //datas.Push(8);
            //datas.Push(22);
            //datas.Push(18);
            //datas.Push(11);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> datas = new Queue<int>();
            //datas.Enqueue(5);
            //datas.Enqueue(7);
            //datas.Enqueue(8);
            //datas.Enqueue(11);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("Admin", "Ferid");
            datas.Add("SuperAdmin","Huseyn");
            datas.Add("Members", "Azer");
            datas.Add("User", "Maqa");

            //foreach (var item in datas)
            //{
            //    Console.WriteLine($"Name :{item.Value}, Role : {item.Key}");
            //}

            foreach (var item in datas)
            {
                if(item.Key == "Admin")
                {
                    Console.WriteLine($"Name :{item.Value}, Role : {item.Key}");
                    break;
                }
            }
        }




        public static void GetStudents(List<Person> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine("Students : Id - {0},Name -{1}, Email -{2}",stu.Id,stu.Name,stu.Email);
            }

        }

        public static void GetNumbers(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        
        public static List<Person> GetPeopleByName(List<Person>people,string name)
        {
            var person = people.FindAll(m => m.Name == name);
            return person;
        }

    }
}
