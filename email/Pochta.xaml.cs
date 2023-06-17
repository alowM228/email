﻿using email;
using ImapX;
using ImapX.Collections;
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
using System.Windows.Shapes;

namespace email
{
    /// <summary>
    /// Логика взаимодействия для Pochta.xaml
    /// </summary>
    public partial class Pochta : Window
    {
        private CommonFolderCollection folders = ImapHalper.GetFolders();
        public Pochta()
        {
            InitializeComponent();

            foreach(var item in folders)
            {

                ListFolder.Items.Add(item.Name);

            }
         
        }

        private void ListFolder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var folder = ListFolder.SelectedItem;

            Page1 folderPage = new Page1(folder);

            folderpage.Content = folderPage;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string otkogo = "";

            otpr page = new otpr(otkogo.ToString());

            folderpage.Content = page;

        }
    }
}
