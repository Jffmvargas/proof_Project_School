using System;
using static System.Console;
namespace School

{
    public class School
    {
        private string nameSchool;


        public School() { }
        public String name
        {
            set { this.nameSchool = value; }
            get { return nameSchool; }
        }
        public int yearOfCreation { get; set; }
        public static void Main(string[] args)
        {
            School first = new School();
            first.yearOfCreation = 2021;
            first.name = "My School";

            WriteLine(first.yearOfCreation);
            WriteLine(first.name);
        }



    }
}

