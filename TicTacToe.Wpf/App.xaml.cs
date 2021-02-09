using MvvmCross;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using TicTacToe.Core.Models;

namespace TicTacToe.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            //Mvx.IoCProvider.RegisterType<IGrid, Grid>();

            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }
    }
}
