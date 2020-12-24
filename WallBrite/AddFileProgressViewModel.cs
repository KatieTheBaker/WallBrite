﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WallBrite
{
    public class AddFileProgressViewModel
    {
        public LibraryViewModel Library { get; set; }

        private readonly AddFileProgressWindow _progressWindow;
        public AddFileProgressViewModel(LibraryViewModel library)
        {
            Library = library;

            _progressWindow = new AddFileProgressWindow
            {
                DataContext = this
            };

            _progressWindow.Show();
        }

        public void CloseWindow()
        {
            _progressWindow.Close();
        }

    }
}