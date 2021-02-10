using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public interface IGrid
    {
        void Start();
        List<ITicTac> PlayGrid
        {
            get;
        }

        bool CheckWinState();
    }
}
