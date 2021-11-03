
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;

namespace FileRenamer.Business
{
    public class ContainerBootstrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICharacterRenamer, GeneralRenamer>("GeneralRenamer");

            container.RegisterType<ICharacterRenamer, RegexRenamer>("RegexRenamer");
        }
    }
}
