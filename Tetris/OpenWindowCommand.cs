using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Tetris
{
    public class OpenWindowCommand : ICommand
    {


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var vmOpen = parameter as string;
            if (vmOpen == null)
                throw new ArgumentNullException("Отсутствуют данные какое окно открывать!");

            if (String.IsNullOrWhiteSpace(vmOpen))
                throw new ArgumentNullException("Данные о окне не могут быть пустыми!");

            switch (vmOpen)
            {
                case "Game":
               
                    break;
                case "Score" :
                    ViewScore vscore = new ViewScore();
                    vscore.Show();
                    break;
                case "Setting":
                    ViewSetting vsettings = new ViewSetting();
                    vsettings.Show();
                    break;
                case "Exit":
                    break;
                case "BackMain":
                    MainView vmain = new MainView();
                    vmain.Show();
                    break;
                default:
                    throw new ArgumentException("Недопустимый параметр для команды");

            }
        
            var window = Application.Current.Windows[0];
            if (window != null)
                window.Close();

        }


        public event EventHandler CanExecuteChanged;
    }
}
