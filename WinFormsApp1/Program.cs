using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using WinFormsApp1.Services;
using WinFormsApp1.Services.Interfaces;
using WinFormsApp1.Data;
using WinFormsApp1.Entity;

namespace WinFormsApp1
{
    static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Register database context with the connection string for PostgreSQL
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql("Server=localhost;Port=5432;Database=test;User Id=postgres;Password=bmv1s10n;"));

            // Register IPasswordHasher service
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            // Register your other services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<UserRegisterForm>();
            services.AddScoped<Form1>(); // Register Form1

            // Build the service provider
            ServiceProvider = services.BuildServiceProvider();

            // Initialize and run the application
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
    }
}