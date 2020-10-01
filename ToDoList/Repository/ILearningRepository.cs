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
        LearningThing GetLearningThingByCategoryDescription(string description);
        void CreateLearningThing(LearningThing learningThing);
        void UpdateLearningThing(LearningThing learningThing);
        void DeleteLearningThing(int id);
    }
}
