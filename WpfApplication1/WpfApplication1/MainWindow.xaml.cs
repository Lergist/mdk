using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        registred reg = new registred();
        Window1 w1 = new Window1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string prior = reg.login(textBox.Text, textBox1.Text);
            if (prior == "1")
            {
                this.Hide();
                w1.Show();
                this.Close();
            }
            else
            {
                if (prior == "2")
                {
                    MessageBox.Show("stud");
                }
                else
                {
                   
                        MessageBox.Show("Неправильное имя пользователя или пароль");
                    
                }
            }
            }

    }
}
