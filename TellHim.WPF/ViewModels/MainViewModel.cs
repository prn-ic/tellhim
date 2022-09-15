using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellHim.WPF.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private HomeViewModel? _homeViewModel;
        public HomeViewModel? HomeViewModel
        {
            get => _homeViewModel;
            set
            {
                _homeViewModel = value;
                OnPropertyChanged(nameof(HomeViewModel));
            }
        }
        public MainViewModel(HomeViewModel _viewModel)
        {
            HomeViewModel = _viewModel;
        }
    }
}
