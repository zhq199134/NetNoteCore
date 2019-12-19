﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
{
      services.AddDbContext<NoteContext>(options => 
                          options.UseMySql(Configuration.GetConnectionString("NoteDb"),
                          b=>b.MigrationsAssembly("NetNote"))//将迁移上下文合并到当前程序集s
                          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));//所有查询都在 DbContext 的无跟踪中执行
      services.AddScoped<INoteRepository, NoteRepository>();
      services.AddScoped<INoteTypeRepository, NoteTypeRepository>();
      services.Configure<CookiePolicyOptions>(options =>
}