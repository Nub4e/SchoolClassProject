using EntityFrameworkModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllController.Controllers
{
    public class EventController
    {


        Event CurrentEvent = new Event();

        ClassbookEntities context = new ClassbookEntities();
        public EventController()
        {
            context.Database.Connection.Open();
        }

        public int ClosestEventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public int TeacherId { get; set; }

        public void PushEvent()
        {
            CurrentEvent.Name = Name;
            CurrentEvent.Description = Description;
            CurrentEvent.Date = Date;
            CurrentEvent.TeacherId = TeacherId;
        }

        public bool InvalidEventName(string EventName)
        {
            var validationt = false;
            validationt = context.Events.Any(w => w.Name == EventName);
            return validationt;
        }
        public void EndConnection()
        {
            context.Database.Connection.Close();
        }
        private  void AddEvent()
        {
            context.Events.Add(CurrentEvent);
            context.SaveChanges();
        }
        public void SetEvent(string name, DateTime date, string description, string TeacherEGN)
        {
            this.Name = name;
            this.Description = description;
            this.Date = date;
            this.TeacherId = context.Teachers.FirstOrDefault(w => w.PersonalNumber == TeacherEGN).TeacherId;
            PushEvent();
            AddEvent();

        }

        public DateTime ClosestDate()
        {
            //DateTime? smallest = auftragList.Min(a => a.dStart);
            DateTime closestDate;   
            closestDate =  context.Events.Select(w=>w.Date).ToList().Min(a => a.Date);
            this.ClosestEventId = context.Events.FirstOrDefault(a => a.Date == closestDate).EventId;
            return closestDate;
         
        }

        public string SetDescription()
        {
            Event closestEvent = context.Events.FirstOrDefault(w => w.EventId == ClosestEventId);
            return closestEvent.Name + " - " + closestEvent.Description;

        }

        public bool DateExists(DateTime value)
        {
            var DateValidation = false;
            DateValidation = context.Events.Any(w => w.Date == value.Date.Date);
            return DateValidation;
        }

        public bool HasEvents()
        {
           return  context.Events.Any();
        }
    }
}
