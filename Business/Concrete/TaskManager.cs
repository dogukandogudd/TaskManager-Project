using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;


        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public IDataResult<List<Entities.Concrete.Task>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Entities.Concrete.Task>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Entities.Concrete.Task>>(_taskDal.GetAll(),Messages.TasksListed);
        }

        public IDataResult<List<Entities.Concrete.Task>> GetAllByLocation(int LocationId)
        {
            return new SuccessDataResult<List<Entities.Concrete.Task>> (_taskDal.GetAll(t => t.LocationId == LocationId));
        }
        public IDataResult<List<Entities.Concrete.Task>> GetAllByStatus(int StatusId)
        {
            return new SuccessDataResult<List<Entities.Concrete.Task>>(_taskDal.GetAll(t => t.StatusId == StatusId));
        }

        
        public IResult Add(Entities.Concrete.Task task)
        {
            
            IResult result= BusinessRules.Run(CheckIfTaskTitleExists(task.TaskTitle));
            if (result!=null)
            {
                return result;
            }
            _taskDal.Add(task);
            return new SuccessResult(Messages.TaskAdded);

        }


      
        public IDataResult<Entities.Concrete.Task> GetById(int TaskId)
        {
            return  new SuccessDataResult<Entities.Concrete.Task>(_taskDal.Get(t => t.TaskId == TaskId));
        }

       
        IResult ITaskService.Update(Entities.Concrete.Task task)
        {
            _taskDal.Update(task);
            return new SuccessResult("Uptaded");
        }
        private IResult CheckIfTaskTitleExists(string TaskTitle)
        {
            var result = _taskDal.GetAll(t=>t.TaskTitle == TaskTitle).Any();
            if (result)
            {
                return new ErrorResult(Messages.TaskNameAlreadyExists);
            }
            return new SuccessResult();
        }

        IResult ITaskService.Delete(Entities.Concrete.Task task)
        {
            _taskDal.Delete(task);
            return new SuccessResult("Deleted");
        }

     
    }
}
