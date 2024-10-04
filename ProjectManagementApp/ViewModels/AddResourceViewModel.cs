using ProjectManagementApp.Models;
using ProjectManagementApp.Services.Navigation;
using ProjectManagementApp.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace ProjectManagementApp.ViewModels
{
    public class AddResourceViewModel : ViewModelBase
    {
        private string _firstName;
        private string _lastName;
        private string _skill;
        private string _timeZone;
        private string _email;
        private string _phone;
        private string _address;
        private string _city;
        private string _state;
        private string _zip;
        private string _country;
        private string _role;
        private float _dailyHours;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Skill
        {
            get => _skill;
            set
            {
                _skill = value;
                OnPropertyChanged(nameof(Skill));
            }
        }

        public string TimeZone
        {
            get => _timeZone;
            set
            {
                _timeZone = value;
                OnPropertyChanged(nameof(TimeZone));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        public string State
        {
            get => _state;
            set
            {
                _state = value;
                OnPropertyChanged(nameof(State));
            }
        }

        public string Zip
        {
            get => _zip;
            set
            {
                _zip = value;
                OnPropertyChanged(nameof(Zip));
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }

        public float DailyHours
        {
            get => _dailyHours;
            set
            {
                _dailyHours = value;
                OnPropertyChanged(nameof(DailyHours));
            }
        }

        public ICommand SaveCommand { get; }

        public AddResourceViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService, dataService)
        {
            SaveCommand = new Command(async () => await SaveResource());
        }

        private async Task SaveResource()
        {
            var resource = new Resource
            {
                FirstName = FirstName,
                LastName = LastName,
                Skill = Skill,
                TimeZone = TimeZone,
                Email = Email,
                Phone = Phone,
                Address = Address,
                City = City,
                State = State,
                Zip = Zip,
                Country = Country,
                Role = Role,
                DailyHours = DailyHours
            };

            //await DataService.AddResourceAsync(resource);
            await NavigationService.PopAsync();
        }
    }
}
