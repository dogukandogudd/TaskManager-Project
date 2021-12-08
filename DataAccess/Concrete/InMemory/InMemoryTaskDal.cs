using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTaskDal : ITaskDal
    {
        List<Entities.Concrete.Task> _tasks;
     
        public void Add(Entities.Concrete.Task task)
        {
            _tasks.Add(task);
        }

        public void Delete(Entities.Concrete.Task task)
        {

            Entities.Concrete.Task taskToDelete =_tasks.SingleOrDefault(t=>t.TaskId==task.TaskId);
            _tasks.Remove(taskToDelete);
        }

        public Entities.Concrete.Task Get(Expression<Func<Entities.Concrete.Task, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Concrete.Task> GetAll()
        {
            return _tasks;
        }

        public List<Entities.Concrete.Task> GetAll(Expression<Func<Entities.Concrete.Task, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Concrete.Task> GetAllByLocation(int LocationId)
        {
            return _tasks.Where(t => t.LocationId == LocationId).ToList();
        }

        public void Update(Entities.Concrete.Task task)
        {
            Entities.Concrete.Task taskToUptade = _tasks.SingleOrDefault(t => t.StatusId == task.StatusId);
            taskToUptade.StatusId=task.StatusId;
            taskToUptade.TaskTitle = task.TaskTitle;
            taskToUptade.LocationId=task.LocationId;
            taskToUptade.TaskCheck = task.TaskCheck;
            taskToUptade.TaskDescription=task.TaskDescription;
        }
    }
}
