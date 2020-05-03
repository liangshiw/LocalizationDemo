using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Qa.Application;
using Volo.Abp;

namespace Qa.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var application = AbpApplicationFactory.Create<QaConsoleAppModule>())
            {
                application.Initialize();


                var localizer = application.ServiceProvider.GetService<IStringLocalizer<QaResource>>();

                Console.WriteLine(localizer["HelloWorld"]);
            }
        }
    }
}