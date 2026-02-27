using System.Windows;
using System.Windows.Shapes;

namespace Atividade1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string resposta;
        private float valor;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ButtonConverter_Click(object sender, RoutedEventArgs e)
        {
            valor = float.Parse(TextBoxValor.Text);
            resposta = ((valor * 1.8) + 32).ToString();
            LabelResposta.Content = $"{resposta} Graus Fahrenheit";
        }
    }
}