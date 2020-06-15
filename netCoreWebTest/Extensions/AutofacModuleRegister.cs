using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace netCoreWebTest.Extensions
{
    public class AutofacModuleRegister : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region 没有接口层的服务层注入

            //因为没有接口层，所以不能实现解耦，只能用 Load 方法。
            //注意如果使用没有接口的服务，并想对其使用 AOP 拦截，就必须设置为虚方法
            var assemblysServicesNoInterfaces = Assembly.Load("Core.Repository");
            builder.RegisterAssemblyTypes(assemblysServicesNoInterfaces);
        }

        #endregion
    }
}
