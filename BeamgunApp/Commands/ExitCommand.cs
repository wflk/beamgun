﻿using System;
using System.Windows;
using System.Windows.Input;
using BeamgunApp.ViewModel;

namespace BeamgunApp.Commands
{
    public class ExitCommand : ICommand
    {
        private readonly BeamgunViewModel _viewModel;

        public ExitCommand(BeamgunViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Reset();
            Application.Current.Shutdown();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
