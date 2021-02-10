using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TicTacToe.Core.Models;

namespace TicTacToe.Core.ViewModels
{
    public class GameViewModel : MvxViewModel, IBaseViewModel
    {
        private string _nextValue = "X";
        private bool _won;
        private IGrid _grid;
        public List<TileViewModel> ViewTiles { get; set; }

        public GameViewModel() {
            ViewTiles = new List<TileViewModel>();
            _grid = new Grid();
            _grid.Start();

            // create a list of ViewModels from the Models and bind
            List<ITicTac> ticTacs = _grid.PlayGrid;
            foreach (ITicTac ticTac in ticTacs)
            {
                ViewTiles.Add(new TileViewModel(this, ticTac));
            }

            // ViewTiles = Enumerable.Range(0, 9).Select(_ => new TileViewModel(this)).ToList();
        }

        public string GetNextValue()
        {
            // Get the next value to display on the TileViewModel
            _nextValue = _nextValue.Equals("X") ? "O" : "X";

            return _nextValue;
        }

        public bool Won
        {
            get { return _won; }
            set
            {

                _won = value;
            }
        }

        public bool CheckForWin()
        {
            return _grid.CheckWinState();
        }
    }
}
