using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public class Grid : IGrid
    {
        private List<TicTac> _grid = new List<TicTac>();

        public Grid() { }

        public void Start()
        {
            int row = 0;
            int column = 0;
            // set up the TicTacToe grid
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    row++;
                    column = 0;
                }
                _grid.Add(new TicTac(row, column));
                column++;
            }
        }

        public List<TicTac> PlayGrid
        {
            get { return _grid; }
        }
    }
}
