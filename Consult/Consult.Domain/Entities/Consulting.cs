using System;

namespace Consult.Domain.Entities
{
    public class Consulting : Entity
    {
        public Consulting(string description, string user, DateTime date)
        {
            Description = description;
            Done = false; //consult not completed
            Date = date;
            User = user;
        }

        public string Description { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }

        public void MarkAsDone() //Consult Completed
        {
            Done = true;
        }

        public void MarkAsNotDone() //Consult Not Completed
        {
            Done = false;
        }

        public void UpdateDescription(string description) //Update Date
        {
            Description = description;
        }
    }


}