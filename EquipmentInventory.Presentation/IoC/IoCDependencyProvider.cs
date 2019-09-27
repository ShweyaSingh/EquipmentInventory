using AutoMapper;
using EquipmentInventory.Data;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Unity;
using Unity.Extension;

namespace EquipmentInventory.Presentation
{
    class IoCDependencyProvider
    {
        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <value>The container.</value>
        public static IUnityContainer Container { get; set; }

        /// <summary>
        /// Initializes the unity container.
        /// </summary>
        /// <param name="containerName">Name of the container.</param>
        /// <param name="unityContainerExtension">Optionally, a unity container extension you might want to register</param>
        /// <returns>Unity container.</returns>
        public static IUnityContainer InitializeContainer(string containerName, UnityContainerExtension unityContainerExtension = null)
        {
            if (Container == null)
            {
                Container = new UnityContainer();

                if (unityContainerExtension != null)
                {
                    Container.AddExtension(unityContainerExtension);
                }
            }

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
            section.Configure(Container, containerName);

            return Container;
        }

        /// <summary>
        /// Resolves with specified parameters.
        /// </summary>
        /// <typeparam name="T">Parameters required by constructor.</typeparam>
        /// <returns>Object instance.</returns>
        public static T Resolve<T>()
        {
            T instance = default(T);
            try
            {
                instance = Container.Resolve<T>();
            }
            catch
            {
                // todo: create custom exception "DIException" and throw this instead.
                throw;
            }

            return instance;
        }

        /// <summary>
        /// Cleans up the unity container by calling its 'dispose' method.
        /// </summary>
        public static void CleanUp()
        {
            if (Container != null)
            {
                Container.Dispose();
            }
        }
    }
}