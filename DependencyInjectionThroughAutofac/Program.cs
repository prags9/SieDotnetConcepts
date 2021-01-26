using Autofac;
using DI_DemoLib;
using System;

namespace DependencyInjectionThroughAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

        }
    }
}
