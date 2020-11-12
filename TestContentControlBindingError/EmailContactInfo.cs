using System.Collections.ObjectModel;
using System.Diagnostics;
using GalaSoft.MvvmLight;

namespace TestContentControlBindingError
{
    public class EmailContactInfoViewModel : ViewModelBase
    {
        public EmailContactInfoViewModel()
        {
            EmailSecurityTypes.Add("Secure");
            EmailSecurityTypes.Add("Not secure");
        }

        public ObservableCollection<string> EmailSecurityTypes { get; } =
            new ObservableCollection<string>();

        private string emailSecurity;
        public string EmailSecurity
        {
            get => emailSecurity;
            set
            {
                if (Set(nameof(EmailSecurity), ref emailSecurity, value))
                    Debug.WriteLine($"{nameof(EmailSecurity)} changed to {value}");
            }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get => emailAddress;
            set => Set(nameof(EmailAddress), ref emailAddress, value);
        }
    }
}