using System;
using ImapX.Collections;
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

namespace email
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MailClick.SelectedItem as ComboBoxItem != null)
            {

                ImapHalper.Initialize((MailClick.SelectedItem as ComboBoxItem).Tag.ToString());
                try

                {

                    if (ImapHalper.Login(Email.Text, pass.Password))

                    {
                        bool open = false;

                        Pochta windows = new Pochta();

                        windows.ShowDialog();

                    } 
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());

                }

            }
            else
            {

                MessageBox.Show(Email.Text);

            }
        }
    }
}
