using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Model;

namespace ToDoList.Repository
{
    public interface ILearningRepository
    {
        IEnumerable<LearningThing> GetAllLearningThings();
        LearningThing GetLearningThingById(int id);
        IEnumerable<LearningThing> GetLearningThingByCategoryDescription(string description);
        void CreateLearningThing(LearningThing learningThing);
        void UpdateLearningThing(LearningThing learningThing, int id);
        void DeleteLearningThing(int id);
    }
}
