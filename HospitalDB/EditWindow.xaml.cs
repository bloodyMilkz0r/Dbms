using System.Windows;

namespace HospitalDB
{

    public partial class EditWindow : Window
    {
        public Patient Patient { get; private set; }
        public EditWindow(Patient p)
        {
            InitializeComponent();

            Patient = p;

            this.DataContext = Patient;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
