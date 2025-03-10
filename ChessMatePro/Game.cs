using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
 
    public class Game
    {
        public string EventName { get; set; }
        public string Date { get; set; }

        public string WhitePlayer { get; set; }
        public string BlackPlayer { get; set; }

        public string Result { get; set; }

        public List<MoveListItem> MoveList { get; set; }

        public Game()
        {
            MoveList = new List<MoveListItem>();
        }

        public void AddMoveListItem(int moveNumber, string whiteMove, string blackMove)
        {
            MoveList.Add(new MoveListItem(moveNumber, whiteMove, blackMove));
        }

        public string GenerateGameAsString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[Event \"{EventName}\"]");
            sb.AppendLine($"[Date \"{Date}\"]");
            sb.AppendLine($"[White \"{WhitePlayer}\"]");
            sb.AppendLine($"[Black \"{BlackPlayer}\"]");
            sb.AppendLine($"[Result \"{Result}\"]\n");
            foreach (var move in MoveList)
            {
                sb.AppendLine(move.ToString());
            }

            return sb.ToString();
        }
    }
}
