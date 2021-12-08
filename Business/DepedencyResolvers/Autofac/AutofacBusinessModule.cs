using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DepedencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TaskManager>().As<ITaskService>().SingleInstance();
            builder.RegisterType<EfTaskDal>().As<ITaskDal>().SingleInstance();

            builder.RegisterType<LocationManager>().As<ILocationService>();
            builder.RegisterType<EfLocationDal>().As<ILocationDal>();

            builder.RegisterType<StatusManager>().As<IStatusService>();
            builder.RegisterType<EfStatusDal>().As<IStatusDal>();
         

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
