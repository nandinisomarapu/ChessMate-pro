using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
    public class MoveListItem
    {
        public int MoveNumber { get; set; }
        public string WhiteMove { get; set; }
        public string BlackMove { get; set; }

        public MoveListItem(int moveNumber, string whiteMove, string blackMove)
        {
            MoveNumber = moveNumber;
            WhiteMove = whiteMove;
            BlackMove = blackMove;
        }

        public override string ToString()
        {
            return $"{MoveNumber}. {WhiteMove} {BlackMove}";
        }
    }

 
}
