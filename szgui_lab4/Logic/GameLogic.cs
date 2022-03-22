using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szgui_lab4.Logic
{
    class GameLogic
    {
        public string Player { get; set; } = X;
        private const string X = "x";
        private const string O = "o";
        private string[,] Board= new string[3,3];

        public void SetPlayer()
        {
            if (Player==X)
            {
                Player = O;
            }
            else
            {
                Player = X;
            }
        }
        public bool Win()
        {
            for (int i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[i,0]))
                {
                    if (Board[i,0]==Board[i,1]&&Board[i,0]==Board[i,2])
                    {
                        return true;
                    }
                }

            }
            for (int i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0, i]))
                {
                    if (Board[0,i] == Board[i,i] && Board[0,i] == Board[2,i])
                    {
                        return true;
                    }
                }

            }
            if (!String.IsNullOrWhiteSpace(Board[1,1]))
            {
                if (Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2])
                {
                    return true;
                }
                if (Board[0, 2] == Board[1, 1] && Board[0, 0] == Board[2, 0])
                {

                }
            }


            return false;
        }

        internal void BoardUpdate(Pos buttonpos, string value)
        {
            Board[buttonpos.x, buttonpos.y] = value;
        }
    }
}
