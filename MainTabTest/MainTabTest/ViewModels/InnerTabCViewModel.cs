using System;
namespace MainTabTest.ViewModels
{
	public class InnerTabCViewModel : BaseViewModel
	{
		public InnerTabCViewModel(INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService) : base (navigationService, pageDialogs, dialogService)
		{
		}
	}
}

