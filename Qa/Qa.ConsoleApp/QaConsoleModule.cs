using Qa.Application;
using Volo.Abp.Modularity;

namespace Qa.ConsoleApp
{
    [DependsOn(typeof(QaApplicationModule))]
    public class QaConsoleAppModule :AbpModule
    {
        
    }
}