﻿using ImapX;
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

namespace email
{

    public partial class Pismo : Page
    {
        bool open = false;

        string from;

        public Pismo(string Subject,string Otkogo,string sobshenie)
        {
            InitializeComponent();

            Topic.Text = Subject;

            otkogo.Text = Otkogo.ToString();

            soobshinee.Text = sobshenie;

            from = Otkogo.ToString() ;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            otpr page = new otpr(from);

            folderpage.Content = page;
                
        
        }

       
    }
    
}
