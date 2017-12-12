﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tetris
{
    public class ViewModelMainWindow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


    
        public ICommand Open { get; set; }

        public ViewModelMainWindow()
        {
            Open = new OpenWindowCommand();
        }

    }




}
