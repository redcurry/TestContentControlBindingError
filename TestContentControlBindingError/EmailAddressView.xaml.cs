using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestContentControlBindingError
{
    /// <summary>
    /// Interaction logic for EmailAddressView.xaml
    /// </summary>
    public partial class EmailAddressView : UserControl
    {
        public EmailAddressView()
        {
            InitializeComponent();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("ComboBox selection changed");
        }
    }
}
