using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public class Grid : IGrid
    {
        private List<ITicTac> _grid = new List<ITicTac>();

        public Grid() { }

        public void Start()
        {
            // set up the TicTacToe grid
            for (int i = 0; i < 9; i++)
            {
                _grid.Add(new TicTac());
            }
        }

        public List<ITicTac> PlayGrid
        {
            get { return _grid; }
        }

        public bool CheckWinState()
        {
            bool won = true;
            int AddValue(string tileValue)
            {
                if (tileValue.Equals("X"))
                {
                    return 1;
                }
                else if (tileValue.Equals("O"))
                {
                    return -1;
                }
                return 0;
            }

            // check rows
            int total = 0;
            for (int i = 0; i < PlayGrid.Count; i++)
            {
                if (i % 3 == 0)
                {
                    if (Math.Abs(total) == 3)
                    {
                        return won;
                    }
                    total = 0;
                }

                total += AddValue(PlayGrid[i].Value);
            }

            // check columns
            total = 0;
            int loop_count = 0;
            for (int i = 0; i < PlayGrid.Count; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    if (Math.Abs(total) == 3)
                    {
                        return won;
                    }
                    loop_count++;
                    total = 0;
                }

                total += AddValue(PlayGrid[((i % 3) * 3) + loop_count].Value);
            }

            // TODO check diagnols

            return !won;
        }
    }
}
