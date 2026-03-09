using BLL.Interfaces;
using BLL.Inventory;
using BLL.Purchases;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISupplierService, SupplierService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<ISaleService, SaleService>();
            services.AddTransient<IEventlogService, EventlogService>();
            services.AddTransient<IAuditService, AuditService>();
            services.AddTransient<IDeliveryService, DeliveryService>();
            services.AddTransient<IPermissionService, PermissionService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IVehicleService, VehicleService>();
            services.AddTransient<IDbMaintenanceService, DbMaintenanceService>();
            services.AddTransient<ILanguageService, LanguageService>();
            services.AddTransient<IEmployeeService, EmployeeService>();

            return services;
        }
    }
}
