﻿using MVVMExampleDemoW8._1.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVMExampleDemoW8._1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private int _clicks = 0;

        public int Clicks
        {
            get { return _clicks; }
            set
            {
                _clicks = value;
                RaisePropertyChanged();
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }


        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get { return _clickCommand = _clickCommand ?? new DelegateCommand(ClickCommandDelegate); }
        }

        private void ClickCommandDelegate()
        {
            Clicks++;
        }

    }
}
