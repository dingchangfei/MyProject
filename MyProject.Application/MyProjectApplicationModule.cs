﻿using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace MyProject
{
    [DependsOn(typeof(MyProjectCoreModule), typeof(AbpAutoMapperModule))]
    public class MyProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
