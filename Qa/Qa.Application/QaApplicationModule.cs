using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Qa.Application
{
    [DependsOn(typeof(AbpLocalizationModule))]
    public class QaApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<QaApplicationModule>("Qa.Application");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<QaResource>("en")
                    .AddVirtualJson("/Localization");
            });
        }
    }
}