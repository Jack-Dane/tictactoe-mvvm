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
        private string nextValue = "X";
        private bool _won;
        public List<TileViewModel> ViewTiles { get; set; }

        public GameViewModel() {
            Grid grid = new Grid();
            grid.Start();

            ViewTiles = Enumerable.Range(0, 9).Select(_ => new TileViewModel(this)).ToList();
        }

        public string GetNextValue()
        {
            // Get the next value to display on the TileViewModel
            nextValue = nextValue.Equals("X") ? "O" : "X";

            return nextValue;
        }

        public bool Won
        {
            get { return _won; }
            set
            {

                _won = value;
            }
        }

        private void blockWon()
        {

        }

        public bool CheckForWin()
        {
            int AddValue(string tileValue)
            {
                if (tileValue.Equals("X"))
                {
                    return 1;
                }
                else if(tileValue.Equals("O"))
                {
                    return -1;
                }
                return 0;
            }

            // check rows
            int total = 0;
            for (int i=0; i<ViewTiles.Count; i++)
            {
                if (i % 3 == 0)
                {
                    if (Math.Abs(total) == 3)
                    {
                        Won = true;
                    }
                    total = 0;
                }

                total += AddValue(ViewTiles[i].Value);
            }

            // check columns
            total = 0;
            int loop_count = 0;
            for (int i=0; i<ViewTiles.Count; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    if (Math.Abs(total) == 3)
                    {
                        Won = true;
                    }
                    loop_count++;
                    total = 0;
                }

                total += AddValue(ViewTiles[((i % 3) * 3) + loop_count].Value);
            }

            return false;
        }
    }
}
