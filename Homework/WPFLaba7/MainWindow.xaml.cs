﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFLaba7
{
    public partial class MainWindow : Window
    {
        TreeFolder treeFolder = new TreeFolder(Directory.GetCurrentDirectory());
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateFolders_Click(object sender, RoutedEventArgs e)
        {
            if (!long.TryParse(tbtPath.Text, out var count))
                return;
            treeFolder.CreateTreeFolders(count);
        }

        private void getFilesListbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbtPath.Text))
                return;
            var paths = Directory.GetFiles(tbtPath.Text);
            if (paths.Length <= 0)
                return;
            filesListlb.ItemsSource = paths;
        }

        private async void filesListlb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var file = filesListlb.SelectedItem as string;
            using var fileStream = File.OpenRead(file);
            byte[] b = new byte[1024 * 8];
            UTF8Encoding temp = new UTF8Encoding(true);
            string content = null;
            while (await fileStream.ReadAsync(b, 0, b.Length) > 0)
            {
                content += temp.GetString(b);
            }
            await fileStream.DisposeAsync();
            tbtText.Text = content;
        }
    }
}
