using Autofac;
using AutofacConsole.Interface;
using Autofac.Configuration;

namespace AutofacConsole
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        /// <value>The container.</value>
        private static IContainer Container { get; set; }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            InitContainer();
            WriteDate();
        }

        /// <summary>
        /// Initializes the container.
        /// </summary>
        private static void InitContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            Container = builder.Build();
        }

        /// <summary>
        /// Writes the date.
        /// </summary>
        public static void WriteDate()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.Write();
            }
        }
    }
}
