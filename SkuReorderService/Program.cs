using SendGrid.Helpers.Mail;
using SkuReorderService;
using SkuReorderService.Configuration;
using SkuReorderService.IRepositary;
using SkuReorderService.Models;
using SkuReorderService.Repositary;
using SkuReorderService.Services;

using System.Reflection.Metadata;


//IHost host = Host.CreateDefaultBuilder(args)
//    .ConfigureServices(services =>
//    {
//        services.AddHostedService<Worker>();
//    })
//    .Build();

//await host.RunAsync();

namespace SkuReorderService
{
    class Program
    {
        static void Main(string[] args)
        {
           
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            CreateHostBuilder(args).Build().Run();
            
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
            })
            //.UseNLog()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(hostContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();
                    var mailSettingss = new MailSettingss();
                    configuration.GetSection("MailSettingss").Bind(mailSettingss);
                    services.AddSingleton(mailSettingss);
                    services.AddHostedService<Worker>();
                    services.AddTransient<ISkuRepositary, SkuRepositary>();
                    services.AddTransient<MAIWMSContext>();
                    //services.Configure<MailSettingss>(configuration.GetSection(nameof(MailSettingss)));
                    services.AddTransient<IMailService, MailService>();
                });

    }
}