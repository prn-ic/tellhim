using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellHim.Domain.Models;
using TellHim.WPF.ViewModels;

namespace TellHim.WPF.Commands
{
    public class InitializeHomeViewModelCommand: CommandBase
    {
        private readonly HomeViewModel _viewModel;
        public InitializeHomeViewModelCommand(HomeViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public override async void Execute(object parameter)
        {
            try
            {
                await _viewModel.Connection.StartAsync();
                _viewModel!.Users?.Add(new User() { Name = "Успешно!", Message = "Вы вошли в чат!" });
            }
            catch (Exception ex)
            {
                _viewModel!.Users?.Add(new User() { Name = "Ошибка", Message = $"{ex}" });            
            }
        }
    }
}
