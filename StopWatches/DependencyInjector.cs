using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace StopWatches
{
    public class DependencyInjector
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();

        public static void Register<I, T>() where T : I
        {
            UnityContainer.RegisterType<I, T>(new ContainerControlledLifetimeManager());
        }

        public static T Retrieve<T>()
        {
            return UnityContainer.Resolve<T>();
        }

        public static void Inject<I>(I instance)
        {
            UnityContainer.RegisterInstance<I>(instance, new ContainerControlledLifetimeManager());
        }
    }
}
