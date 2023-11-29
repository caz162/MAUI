using Prism.Common;

namespace MainTabTest
{
	public static class PrismHelper
	{
        public static async Task AddTabAsync(Page currentPage, string name,
            INavigationParameters parameters = null)
        {
            TabbedPage tabbedPage = null;

            if (currentPage is TabbedPage tPage)
            {
                tabbedPage = tPage;
            }
            else if (currentPage.Parent is TabbedPage parent)
            {
                tabbedPage = parent;
            }
            else if (currentPage.Parent is NavigationPage navPage)
            {
                if (navPage.Parent != null && navPage.Parent is TabbedPage parent2)
                {
                    tabbedPage = parent2;
                }
            }
            
            ContainerLocator.Container.CreateScope();

            //No longer works, receive exception
            //var newTab = ContainerLocator.Container.Resolve<object>(name) as Page;

            Page newTab;
            switch (name)
            {
                case "InnerTabA":
                    newTab = ContainerLocator.Container.Resolve(typeof(InnerTabA)) as Page;
                    break;
                case "InnerTabB":
                    newTab = ContainerLocator.Container.Resolve(typeof(InnerTabB)) as Page;
                    break;
                case "InnerTabC":
                    newTab = ContainerLocator.Container.Resolve(typeof(InnerTabC)) as Page;
                    break;
                case "InnerTabD":
                    newTab = ContainerLocator.Container.Resolve(typeof(InnerTabD)) as Page;
                    break;
                case "InnerTabE":
                    newTab = ContainerLocator.Container.Resolve(typeof(InnerTabE)) as Page;
                    break;
                default:
                    throw new Exception("Unknown type");
            }
            
            var autowire = ViewModelLocator.GetAutowireViewModel(newTab);
            if (autowire == null)
                ViewModelLocator.SetAutowireViewModel(newTab, ViewModelLocatorBehavior.Automatic);
                
            await MvvmHelpers.OnInitializedAsync(newTab, parameters);

            tabbedPage.Children.Add(newTab);
            tabbedPage.CurrentPage = newTab;
        }
    }
}

