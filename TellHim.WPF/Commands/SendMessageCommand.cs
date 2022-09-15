using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellHim.Domain.Models;
using TellHim.EntityFramework;
using TellHim.EntityFramework.Services;
using TellHim.WPF.ViewModels;

namespace TellHim.WPF.Commands
{
    public class SendMessageCommand: CommandBase
    {
        private readonly HomeViewModel? _viewModel;
        public SendMessageCommand(HomeViewModel? viewModel)
        {
            _viewModel = viewModel;
        }
        public override async void Execute(object parameter)
        {
            try
            {
                User? newUser = new User()
                {
                    Name = _viewModel!.Username,
                    Message = _viewModel!.Message
                };

                await _viewModel!.DataService!.Create(newUser);
                await _viewModel!.Connection!.InvokeAsync("Send", _viewModel!.Username, _viewModel!.Message);
                
            }
            catch (Exception ex)
            {
                _viewModel!.Users?.Add(new User() { Name = "Ошибка", Message = $"{ex}" });
            }
        }
    }
}
