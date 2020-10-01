using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Model;
using ToDoList.Repository;

namespace ToDoLIst.UnitTests
{
    public class LearningThingsRepositoryTest
    {
        [Test]
        public void RepositorytestGetByIdMethod()
        {
            List<LearningThing> learningThings = new List<LearningThing>();
            ILearningRepository learningRepository = new LearningThingRepository(learningThings);
            LearningThing learningThing1 = new LearningThing("l2", "none1");
            learningRepository.CreateLearningThing(learningThing1);

            Assert.AreEqual(learningThing1, learningRepository.GetLearningThingById(1));
        }

        [Test]
        public void RepositoryTestGetAllMethod()
        {
            List<LearningThing> learningThings = new List<LearningThing>()
            {
                new LearningThing("l1", "none1"),
                new LearningThing("l2", "none2")
            };
            ILearningRepository learningRepository = new LearningThingRepository(learningThings);

            Assert.AreEqual(2, learningRepository.GetAllLearningThings().Count());
        }

        [Test]
        public void RepositoryTestUpdateMethod()
        {
            List<LearningThing> learningThings = new List<LearningThing>()
            {
                new LearningThing("l1", "none1"),

            };
            ILearningRepository learningRepository = new LearningThingRepository(learningThings);
            LearningThing learningThing = new LearningThing("l2", "updated");
            learningRepository.UpdateLearningThing(learningThing, 1);


            Assert.AreEqual("updated", learningRepository.GetLearningThingById(1).Description);
        }

        [Test]
        public void RepositoryTestGetByDescriptionMethod()
        {
            Category category = new Category("myCategory");
            List<LearningThing> learningThings = new List<LearningThing>();
            LearningThing learningThing = new LearningThing("l1", "none1");
            learningThing.Category = category;
            ILearningRepository learningRepository = new LearningThingRepository(learningThings);

            learningRepository.CreateLearningThing(learningThing);

            Assert.AreEqual("myCategory", learningRepository.GetLearningThingByCategoryDescription("myCategory").FirstOrDefault().Category.Description);
        }

        [Test]
        public void RepositoryTestDeleteMethod()
        {
            List<LearningThing> learningThings = new List<LearningThing>()
            {
                new LearningThing("l1", "none1"),
                new LearningThing("l2", "none2")
            };
            ILearningRepository learningRepository = new LearningThingRepository(learningThings);
            learningRepository.DeleteLearningThing(1);

            Assert.AreEqual(1, learningRepository.GetAllLearningThings().Count());
        }

       
    }
}