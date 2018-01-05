using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Controllers;
using Task1.Models;
using Task1.Products;
using Task1.Repository;
using Task1.Repository.CategoriesRepository;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Injection;

namespace Task1.App_Start
{
    public static class Unity
    {
        public static IUnityContainer Configure()
        {
            IUnityContainer container = new UnityContainer();
            registerService(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        private static void registerService(IUnityContainer container)
        {
            container.RegisterType<ICategory,CategoryRepository>();
            container.RegisterType<Iproduct, ProductRepository>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            
        }
    }
}