using DI_DemoLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionThroughAutofac
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
