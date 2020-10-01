using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ToDoList.Model
{
    public class LearningThing
    {
        private static int id;

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Crated { get; set; }
        public bool IsDone { get; set; }
        public Category Category { get; set; }
        public int Advanced { get; set; }

        public LearningThing(string subject, string description/*, string category*/)
        {
            Id = Interlocked.Increment(ref id);
            Subject = subject;
            Description = description;
            Crated = DateTime.Today;
            Advanced = 0;
            IsDone = false;
        }

        public override string ToString()
        {
            return Id + " " + Subject + " " + Description;
        }
    }
}
