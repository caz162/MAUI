using System.Text.RegularExpressions;

namespace MainTabTest.ViewModels
{
    public abstract class BaseViewModel : BindableBase, IInitialize, IInitializeAsync, INavigationAware, IDestructible, IPageLifecycleAware
    {
        protected INavigationService _navigationService { get; }
        protected IPageDialogService _pageDialogs { get; }
        protected IDialogService _dialogs { get; }

        public string Name => $"{this.GetType().Name} : {Id}";
        
        protected BaseViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogs,
            IDialogService dialogService)
        {
            _navigationService = navigationService;
            _pageDialogs = pageDialogs;
            _dialogs = dialogService;
            Title = Regex.Replace(GetType().Name, "ViewModel", string.Empty);
            Id = Guid.NewGuid().ToString();
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
            GoBack = new DelegateCommand(OnGoBack);
        }

        public string Title { get; }

        public string Id { get; }

        public DelegateCommand<string> NavigateCommand { get; }

        public DelegateCommand GoBack { get; }

        private void OnNavigateCommandExecuted(string uri)
        {
            _navigationService.NavigateAsync(uri)
                .OnNavigationError(ex => Console.WriteLine(ex));
        }

        private void OnGoBack()
        {
            _navigationService.GoBackAsync();
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnAppearing()
        {
        }

        public virtual void OnDisappearing()
        {
        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.FromResult(true);
        }

        public virtual void Destroy()
        {
        }
    }
    
}

