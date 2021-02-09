using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Models
{
    public class TicTac : ITicTac
    {
        // 0 = None, 1 = X, 2 = O
        private int status = 0;
        private int x;
        private int y;
        public IMvxCommand TicButtonClick { get; set; }

        public TicTac(int x, int y) {
            this.x = x;
            this.y = y;
            TicButtonClick = new MvxCommand(test);
        }

        public int State
        {
            get { return status; }
            set { status = value; }
        }

        public int X { 
            get { return this.x; } 
            set { this.x = value; } 
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public void test()
        {
            status++;
            Console.WriteLine(status);
        }
    }
}
