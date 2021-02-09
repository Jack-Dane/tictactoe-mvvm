using MvvmCross;
using MvvmCross.ViewModels;
using TicTacToe.Core.ViewModels;

namespace TicTacToe.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<GameViewModel>();
        }
    }
}
