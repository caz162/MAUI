using System;
using Prism.Common;

namespace MainTabTest.ViewModels
{
    public class MainTabPageViewModel(IPageAccessor pageAccessor,
            INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService)
        : BaseViewModel(navigationService, pageDialogs, dialogService)
    {
        private readonly IPageAccessor _pageAccessor = pageAccessor;

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            var currentPage = _pageAccessor.Page;

            await PrismHelper.AddTabAsync(currentPage, "InnerTabA", parameters);
            await PrismHelper.AddTabAsync(currentPage, "InnerTabB", parameters);
            await PrismHelper.AddTabAsync(currentPage, "InnerTabC", parameters);
            await PrismHelper.AddTabAsync(currentPage, "InnerTabD", parameters);
            await PrismHelper.AddTabAsync(currentPage, "InnerTabE", parameters);
        }
    }
}

