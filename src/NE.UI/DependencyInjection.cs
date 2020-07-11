using Autofac;
using NE.Core;
using NE.Core.Encryption;
using NE.Infrastructure.IO;

namespace NotesEncryptor
{
    public class DependencyInjection
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AESEncryption>().As<IEncryptor>();
            builder.RegisterType<WFileOperator>().As<IFileOperator>();
            builder.RegisterType<Form1>();

            return builder.Build();
        }
    }
}
