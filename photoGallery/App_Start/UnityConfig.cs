using System.Web.Mvc;
using PatternProject.Models;
using Unity;
using Unity.Mvc5;

namespace PatternProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IPhotoRepository, PhotoRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}