using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.ObjectModel;
using TellHim.Domain.Models;
using TellHim.EntityFramework;
using TellHim.EntityFramework.Services;
using System.Windows.Threading;
using System.Windows.Input;
using TellHim.WPF.Commands;
using System.Linq;

namespace TellHim.WPF.ViewModels
{
    public class HomeViewModel: ViewModelBase
    {
        private static readonly TellHimDbContextFactory? _contextFactory = new TellHimDbContextFactory();
        private DataService? _dataService = new DataService(_contextFactory);
        private HubConnection? _connection;

        private string? _username;
        private string? _message;
        private ObservableCollection<User>? _users;

        public string? Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string? Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        } 

        public ObservableCollection<User>? Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public HubConnection? Connection
        {
            get
            {
                return _connection;
            }
            set
            {
                _connection = value;
                OnPropertyChanged(nameof(Connection));
            }
        }

        public ICommand? InitializeHomeViewModelCommand { get; }
        public ICommand? SendMessageCommand { get; }
        public DataService? DataService
        {
            get => _dataService;
        }

        public HomeViewModel()
        {
            Users = new ObservableCollection<User>(_dataService.GetAll().Reverse());
            

            _connection = new HubConnectionBuilder().WithUrl("https://localhost:7192/chat").Build();

            _connection.On<string, string>("Receive", (username, message) =>
            {
                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    User? newUser = new User()
                    {
                        Name = username,
                        Message = message
                    };

                    Users.Insert(0, newUser);

                });
            });

            InitializeHomeViewModelCommand = new InitializeHomeViewModelCommand(this);
            SendMessageCommand = new SendMessageCommand(this);
        }

    }
}
