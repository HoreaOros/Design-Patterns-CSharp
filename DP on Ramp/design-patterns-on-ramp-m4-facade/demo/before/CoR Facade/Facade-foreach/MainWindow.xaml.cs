﻿using System.Collections.Generic;
using System.Windows;

namespace Facade_foreach
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> people = People.GetPeople();
        }
    }
}
