using ImapX.Collections;
using ImapX;
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
using WpfEmal;

namespace email
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Message mess;
        string mail = "";
        MessageCollection messages;
        public Page1(object folder)
        {
            InitializeComponent();

            Task.Run(() =>
            {

                Dispatcher.Invoke(new Action(() =>
                {
                    messages = ImapHalper.GetMessagesForFolder(folder.ToString());

                    //MessengeList.Items.Add(messages);

                    foreach (Message item in messages)
                    {
                        var s = item as Message;
                        List.Items.Add(s.Subject);
                    }
                }));


            });
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            string soob = "";

            var eng = List.SelectedItem;

            string sub = "";

            MailAddress from = null;

            foreach (Message item in messages)
            {

                if (item.Subject == eng)
                {

                    sub = item.Subject;
                    soob = item.Body.Text;
                    from = item.From;

                }
            }

            otpr pis = new otpr(from.ToString());

            folderpage.Content = pis;

        }


        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            string sub = "";

            string soob = "";

            string from = "";

            var eng = List.SelectedItem;
            
            foreach (Message item in messages)
            {

                if (item.Subject == eng)

                {

                    sub = item.Subject;

                    soob = item.Body.Text;

                    from = item.From.ToString();

                }
            }

            Pismo pis = new Pismo(sub, from, soob);

            folderpage.Content = pis;
        }


        private void MessengeList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string from = null;

            string sub = "";

            string soob = "";

            var eng = List.SelectedItem;

            mail = eng.ToString();
            
            foreach (Message item in messages)
            {

                if (item.Subject == eng)
                {
                    from = item.From.ToString();

                    sub = item.Subject;

                    soob = item.Body.Text;
                    
                }

            }
            Pismo pis = new Pismo(sub, from, soob);

            folderpage.Content = pis;

        }


    }
}
