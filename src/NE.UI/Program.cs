using Autofac;
using System;
using System.Windows.Forms;

namespace NotesEncryptor
{
    static class Program
    {
        private static IContainer container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            container = DependencyInjection.CreateContainer();

            Application.Run(container.Resolve<Form1>());
        }
    }
}
