using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Model;

namespace ToDoList.Repository
{
    public class LearningThingRepository: ILearningRepository
    {
        private List<LearningThing> context;

        public LearningThingRepository(List<LearningThing> context)
        {
            this.context = context;
        }

        public void CreateLearningThing(LearningThing learningThing)
        {
            context.Add(learningThing);
        }

        public void DeleteLearningThing(int id)
        {
            LearningThing learningThing = context.Find(x => x.Id.Equals(id));
            context.Remove(learningThing);
        }

        public IEnumerable<LearningThing> GetAllLearningThings()
        {
            return context.ToList();
        }

        public IEnumerable<LearningThing> GetLearningThingByCategoryDescription(string description)
        {
            return context.FindAll(x => x.Category.Description.Equals(description));
        }

        public LearningThing GetLearningThingById(int id)
        {
            return context.Find(x => x.Id.Equals(id));
        }

        public void UpdateLearningThing(LearningThing newLearningThing, int idToUpdate)
        {
            var obj = context.FirstOrDefault(x => x.Id.Equals(idToUpdate));
            if (obj != null)
            {
                obj.Advanced = newLearningThing.Advanced;
                obj.Category = newLearningThing.Category;
                obj.Subject = newLearningThing.Subject;
                obj.Description = newLearningThing.Description;
            }
            
        }
    }
}