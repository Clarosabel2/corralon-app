using DAL.Interfaces;
using DAL.Inventory;
using DAL.Purchases;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<ISaleRepository, SaleRepository>();
            services.AddTransient<IEventlogRepository, EventLogRepository>();
            services.AddTransient<IAuditRepository, AuditRepository>();
            services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            services.AddTransient<IPermissionRepository, PermissionRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IVehicleRepository, VehicleRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
