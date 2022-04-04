﻿using Core.CrousCuttingConcerns.Caching;
using Core.CrousCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IOS;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicesCollection)
        {
            servicesCollection.AddMemoryCache();
            servicesCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            servicesCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //servicesCollection.AddSingleton<Stopwatch>();
        }
    }
}
