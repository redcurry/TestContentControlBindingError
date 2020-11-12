using GalaSoft.MvvmLight;

namespace TestContentControlBindingError
{
    public class AddressContactInfoViewModel : ViewModelBase
    {
        private string street;
        public string Street
        {
            get => street;
            set => Set(nameof(Street), ref street, value);
        }

        private string city;
        public string City
        {
            get => city;
            set => Set(nameof(City), ref city, value);
        }

        private string state;
        public string State
        {
            get => state;
            set => Set(nameof(State), ref state, value);
        }

        private string zipCode;
        public string ZipCode
        {
            get => zipCode;
            set => Set(nameof(ZipCode), ref zipCode, value);
        }
    }
}