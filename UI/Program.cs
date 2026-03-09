using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            DAL.DependencyInjectionService.AddRepositories(services);
            BLL.DependencyInjectionService.AddServices(services);
           
            var types = typeof(Program).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract);
            foreach (var type in types)
            {
                services.AddTransient(type);
            }
            ServiceProvider = services.BuildServiceProvider();
            var formLogin = ServiceProvider.GetRequiredService<FormLogin>();

            Application.Run(formLogin);
        }
    }
}