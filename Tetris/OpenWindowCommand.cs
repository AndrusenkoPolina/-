using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            if (vmOpen == "Game")
            {
                ViewGame windowopen = new ViewGame();
                MainView windclose = new MainView();
                windowopen.Show();
                windclose.Close();
            }

            if (vmOpen == "Score")
            {
                ViewScore windowopen = new ViewScore();
                windowopen.Show();
            }

            if (vmOpen == "Setting")
            {
                ViewSetting windowopen = new ViewSetting();
                windowopen.Show();
            }
            if (vmOpen == "Q")
            {

            }
    
        }


        public event EventHandler CanExecuteChanged;
    }
}
