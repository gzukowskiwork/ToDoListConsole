using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Model;

namespace ToDoList.Repository
{
    class LearningThingRepository: ILearningRepository
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

        public LearningThing GetLearningThingByCategoryDescription(string description)
        {
            return context.Find(x => x.Description.Equals(description));
        }

        public LearningThing GetLearningThingById(int id)
        {
            return context.Find(x => x.Id.Equals(id));
        }

        public void UpdateLearningThing(LearningThing learningThing)
        {
            LearningThing learningThingToUpdate = context.Find(x => x.Id.Equals(learningThing.Id));
            learningThingToUpdate = learningThing;
            context.Add(learningThingToUpdate);
        }
    }
}
