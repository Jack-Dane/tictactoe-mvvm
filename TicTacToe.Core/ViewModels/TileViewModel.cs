using MvvmCross.ViewModels;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.ViewModels
{
    public class TileViewModel : MvxViewModel
    {
        private string _value = "";
        private bool _enabled = true;
        private IBaseViewModel _baseViewModel;
        public IMvxCommand TileClick { get; set; }

        public TileViewModel(IBaseViewModel baseViewModel)
        {
            TileClick = new MvxCommand(Increment);

            _baseViewModel = baseViewModel;
        }

        public string Value {
            get { return _value;  } 
            set
            {
                _value = value;
                RaisePropertyChanged(() => Value);
            }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                _enabled = value;
                RaisePropertyChanged(() => Enabled);
            }
        }

        public void Increment()
        {
            Enabled = false;
            Value = _baseViewModel.GetNextValue();
            _baseViewModel.CheckForWin();
        }
    }
}
