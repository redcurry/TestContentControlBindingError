using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace TestContentControlBindingError
{
    public class MainViewModel : ViewModelBase
    {
        private object previousContactInfo;

        public MainViewModel()
        {
            contactInfo = new EmailContactInfoViewModel();
        }

        public ICommand SwapContactInfoCommand =>
            new RelayCommand(SwapContactInfo);

        private void SwapContactInfo()
        {
            if (previousContactInfo == null)
            {
                previousContactInfo = ContactInfo;
                ContactInfo = new AddressContactInfoViewModel();
            }
            else
            {
                var temp = ContactInfo;
                ContactInfo = previousContactInfo;
                previousContactInfo = temp;
            }
        }

        private object contactInfo;
        public object ContactInfo
        {
            get => contactInfo;
            set => Set(nameof(ContactInfo), ref contactInfo, value);
        }
    }
}