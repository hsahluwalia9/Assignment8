using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class VM : INotifyPropertyChanged
    {
        //array that stores the value of 1 or 0 in a 3x3 grid.
        int[,] boardArray = new int[rows, columns];
        //array that used to convert and store boardArray values to string O or X accordingly.
        string[,] gameArray = new string[rows, columns];

        string _one,_two,_three,_four,_five,_six,_seven,_eight,_nine;
        const int rows = 3;
        const int columns = 3;
        
        Random r = new Random();
       
        //Method that sets up the gameboard with random O and X
        public void Game()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    boardArray[x, y] = r.Next(0, 2);
                    if (boardArray[x, y] == 0)
                    {
                        gameArray[x, y] = "O";
                    }
                    else if (boardArray[x, y] == 1)
                    {
                        gameArray[x, y] = "X";
                    
                    }
                }
                _one = gameArray[0, 0];
                _two = gameArray[0, 1];
                _three = gameArray[0, 2];
                _four = gameArray[1, 0];
                _five = gameArray[1, 1];
                _six = gameArray[1, 2];
                _seven = gameArray[2, 0];
                _eight = gameArray[2, 1];
                _nine = gameArray[2, 2];
                One = _one;
                Two = _two;
                Three = _three;
                Four = _four;
                Five = _five;
                Six = _six;
                Seven = _seven;
                Eight = _eight;
                Nine = _nine;
            }
        }

        public bool CheckO() { 
            if ((One == "O" && Two == "O" && Three == "O") || (Four == "O" && Five == "O" && Six == "O") || (Seven == "O" && Eight == "O" && Nine == "O") ||
                     (One == "O" && Four == "O" && Seven == "O") || (One == "O" && Five == "O" && Nine == "O") || (Three == "O" && Six == "O" && Nine == "O") ||
                     (Two == "O" && Five == "O" && Eight == "O") || (Three == "O" && Five == "O" && Seven == "O"))
             {
                return true;
             }
            return false;
        }

        public bool CheckX()
        {
            if ((One == "X" && Two == "X" && Three == "X") || (Four == "X" && Five == "X" && Six == "X") || (Seven == "X" && Eight == "X" && Nine == "X") ||
                        (One == "X" && Four == "X" && Seven == "X") || (One == "X" && Five == "X" && Nine == "X") || (Three == "X" && Six == "X" && Nine == "X") ||
                        (Two == "X" && Five == "X" && Eight == "X") || (Three == "X" && Five == "X" && Seven == "X"))
            {
                return true;
            }
            return false;
        }

        public bool CheckDraw()
        {
            if ((CheckX() == true) && (CheckO() == true) || ((CheckX()== false) &&(CheckO()==false)))
            {
                return true;
            }
            return false;
        }

        public string One
        {
            get {return _one;}
            set{_one=value; OnPropertyChanged();}
        }

        public string Two
        {
            get { return  _two; }
            set { _two=value; OnPropertyChanged(); }
        }

        public string Three
        {
            get { return gameArray[0, 2]; }
            set { gameArray[0, 2]= value; OnPropertyChanged(); }
        }

        public string Four
        {
            get { return gameArray[1, 0]; }
            set {gameArray[1, 0] = value; OnPropertyChanged(); }
        }

        public string Five
        {
            get { return gameArray[1, 1]; }
            set { gameArray[1, 1] = value; OnPropertyChanged(); }
        }

        public string Six
        {
            get { return gameArray[1, 2]; }
            set { gameArray[1, 2] = value; OnPropertyChanged(); }
        }

        public string Seven
        {
            get { return gameArray[2, 0]; }
            set { gameArray[2, 0] = value; OnPropertyChanged(); }
        }

        public string Eight
        {
            get { return gameArray[2, 1]; }
            set { gameArray[2, 1] = value; OnPropertyChanged(); }
        }

        public string Nine
        {
            get { return gameArray[2, 2]; }
            set { gameArray[2, 2] = value; OnPropertyChanged(); }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion
    }
}
