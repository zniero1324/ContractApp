﻿using ContractApp.MVVM.ViewModels;
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

namespace ContractApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for AddMaidView.xaml
    /// </summary>
    public partial class AddMaidView : Window
    {
        public AddMaidView(string CardNo)
        {
            InitializeComponent();
            AddMaidViewModel? maidVM = new();

            DataContext = maidVM;
            maidVM.CardNo = CardNo;
        }
    }
}
