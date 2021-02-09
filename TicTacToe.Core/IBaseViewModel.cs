using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core
{
    public interface IBaseViewModel
    {
        string GetNextValue();
        bool CheckForWin();
    }
}
