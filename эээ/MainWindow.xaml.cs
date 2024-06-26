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

namespace эээ
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
        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создатель: Журавлев\nВариант 7\nПрактическая 19: Ввести n целых чисел. Вычислить для чисел < 0 функцию x^2. Результат обработки каждого числа вывести на экран.", "О программе");
        }
        private void Dobav(object sender, RoutedEventArgs e)
        {
            if (zn.Text != "")
            {
                bool f1 = int.TryParse(zn.Text, out int a);
                if (f1)
                {
                    list.Items.Add(a);
                }
                else
                {
                    MessageBox.Show("Необходимо вводить числа", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Значение не может быть пустым", "Ошибка");
            }
        }

        private void Ubrav(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex != -1)
            {
                list.Items.RemoveAt(list.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выделите объект для удаления", "Ошибка");
            }
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
        }
        private void Random(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random(); int x;
            if (random_count.Text != "")
            {
                bool f1 = int.TryParse(random_count.Text, out int a);
                if (f1)
                {
                    if (a >= 0)
                    {
                        for (int i = 0; i < a; i++)
                        {
                            x = rnd.Next(-100,100);
                            list.Items.Add(x);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество не может быть отрицательным", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Необхеодимо вводить числа", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Окно количества не может быть пустым", "Ошибка");
            }
        }
        private void Raschet(object sender, RoutedEventArgs e)
        {
            for(int i = 0;i < list.Items.Count;i++)
            {
                if (Convert.ToInt32(list.Items[i]) < 0)
                {
                    list_otv.Items.Add(Math.Pow(Convert.ToInt32(list.Items[i]), 2));
                }
            }
        }
        private void ClearOtv(object sender, RoutedEventArgs e)
        {
            list_otv.Items.Clear();
        }
    }
}