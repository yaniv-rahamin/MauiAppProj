using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppProj.Model
{
    internal class User : ObservableObject
    {
        private string name;
        private string userName;
        private string email;
        private string password;
        private string phoneNumber;
        private DateTime birthDate;
        private string age;
       




        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public string UserName { get => userName; set { userName = value; OnPropertyChanged(); } }
        public string Email { get => email; set { email = value; OnPropertyChanged(); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(); } }
        public string PhoneNumber { get => phoneNumber; set { phoneNumber = value; OnPropertyChanged(); } }
        public DateTime BirthDate { get => birthDate; set { birthDate = value; OnPropertyChanged(); OnPropertyChanged(nameof(Age)); } }
        public string Age { get => age;  set { age = value; } }

    }
}