using System;
using System.Collections.Generic;
using ToDoList.Model;
using ToDoList.Repository;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LearningThing learningThing = new LearningThing("l1", "none0");
            LearningThing learningThing1 = new LearningThing("l2", "none1");
            LearningThing learningThing2 = new LearningThing("l3", "none2");

            LearningThing learningThing3 = new LearningThing("l3", "updated");


            Category category1 = new Category("dupa");
            Category category2 = new Category("dupa2");

            learningThing.Category = category1;
            learningThing1.Category = category1;
            learningThing2.Category = category2;

            List<LearningThing> learningThings = new List<LearningThing>();
            ILearningRepository learningRepository = new LearningThingRepository(learningThings);

            learningRepository.CreateLearningThing(learningThing1);
            learningRepository.CreateLearningThing(learningThing2);
            learningRepository.CreateLearningThing(learningThing);

            foreach (var item in learningRepository.GetAllLearningThings())
            {
                Console.WriteLine(item.ToString());
            }

            learningRepository.UpdateLearningThing(learningThing3, 1);
            //learningRepository.DeleteLearningThing(1);
           
            foreach(var item in learningRepository.GetAllLearningThings())
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
