using Autofac;
using Autofac.Core;
using NE.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesEncryptor
{
    public class DependencyInjection
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AES>().As<IEncryptor>();
            builder.RegisterType<WFileOperator>().As<IFileOperator>();
            builder.RegisterType<Form1>();

            return builder.Build();
        }
    }
}
