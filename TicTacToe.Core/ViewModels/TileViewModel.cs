using MvvmCross.ViewModels;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Core.Models;

namespace TicTacToe.Core.ViewModels
{
    public class TileViewModel : MvxViewModel
    {
        private bool _enabled = true;
        private IBaseViewModel _baseViewModel;
        private ITicTac _ticTac;
        public IMvxCommand TileClick { get; set; }

        public TileViewModel(IBaseViewModel baseViewModel, ITicTac ticTac)
        {
            TileClick = new MvxCommand(Increment);

            _baseViewModel = baseViewModel;
            _ticTac = ticTac;
        }

        public string Value {
            get { return _ticTac.Value;  } 
            set
            {
                _ticTac.Value = value;
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
