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

namespace WPFApp
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

        void CreateTask()
        {
            Task T;
            Action Code = new Action(ShowMessage);
            T = new Task(Code);

            Task T2 = new Task(delegate
            {
                MessageBox.Show("Ejecutando una tarea en un metodo anonimo ");
            }
            );
            Task T3A = new Task(() => ShowMessage());
            Task T3 = new Task(
                () => ShowMessage());

            Task T4 = new Task(() => MessageBox.Show("Ejecutando la tarea 4"));

            Task T5 = new Task(() =>
                {
                    DateTime CurrenDate = DateTime.Today;
                    DateTime StarDate= CurrenDate.AddDays(30);
                    MessageBox.Show($"Tarea 5.  Fecha calculada: {StarDate}");
                }
                );

            Task T6 = new Task((message) =>
            MessageBox.Show(message.ToString()), "exprecion lambda con parametros");

        }

        

        void ShowMessage()
        {
            MessageBox.Show("Ejecutando el metodo ShowMessage");
        }

        
}
}