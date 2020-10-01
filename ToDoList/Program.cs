using System;
using ToDoList.Model;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LearningThing learningThing = new LearningThing("l1", "none");
            LearningThing learningThing1 = new LearningThing("l2", "none");
            LearningThing learningThing2 = new LearningThing("l3", "none");
           
            Category category1 = new Category("dupa");
            Category category2 = new Category("dupa2");

            learningThing.Category = category1;
            learningThing2.Category = category2;

            Console.WriteLine(learningThing.Advanced);

            Console.WriteLine(learningThing1.Id);

            Console.WriteLine(learningThing2.Category.Description);

        }
    }
}
