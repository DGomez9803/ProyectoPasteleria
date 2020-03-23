//// -----------------------------------------------------------------------
//// <copyright file="App_Start.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
/// See more at: https://github.com/dn32/Fluent.Infrastructure/wiki
////-----------------------------------------------------------------------

using Fluent.Infrastructure.FluentTools;
using ProyectoPasteleria.DataBase;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProyectoPasteleria.App_Start), "PreStart")]

namespace ProyectoPasteleria {
    public static class App_Start {
        public static void PreStart() {
           // FluentStartup.Initialize(typeof(DbContextLocal));
        }
    }
}