using System.Windows;
using System.Windows.Controls;
using Demo1.ViewModel;

namespace Demo1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LstVw_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public EmpFormViewModel SelectedEmp
        {
            get { return (EmpFormViewModel)GetValue(SelectedEmpProperty); }
            set { SetValue(SelectedEmpProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedEmp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedEmpProperty =
            DependencyProperty.Register("SelectedEmp", typeof(EmpFormViewModel), typeof(MainWindow), new PropertyMetadata(OnSelectedEmpChanged));



        private static void OnSelectedEmpChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            MainWindow mainWindow = dependencyObject as MainWindow;
            EmpFormViewModel oldval = (EmpFormViewModel)e.OldValue;
            EmpFormViewModel newval = (EmpFormViewModel)e.NewValue;

            if (mainWindow != null)
            {
                //mainWindow.txtBlock.Background = Brushes.Green;
                newval = oldval;
            }

        }


    }
}
