using Unity;

namespace FileRenamer
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
