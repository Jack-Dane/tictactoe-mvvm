using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public class TicTac : ITicTac
    {
        // 0 = None, 1 = X, 2 = O
        private string status = "";
        public IMvxCommand TicButtonClick { get; set; }

        public TicTac() { }

        public string Value
        {
            get { return status; }
            set { status = value; }
        }
    }
}
