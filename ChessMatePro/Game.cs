using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
 
    public class Game
    {
         // Properties to store game metadata
        public string EventName { get; set; }
        public DateTime Date { get; set; }

        public string OpponentName { get; set; }

        public string WhitePlayer { get; set; }
        public string BlackPlayer { get; set; }

        public string Result { get; set; }

        public List<MoveListItem> MoveList { get; set; }

        public int GameID { get; set; }
    
        public Guid PGNFileID { get; set; }
        public PGNFile PGNFile { get; set; } // Navigation property

        public int UserID { get; set; }


        public Game()
        {
            // Initialize the MoorveList as an empty list
            MoveList = new List<MoveListItem>();
        }

         /// Adds a new move to the game's move list.
        public void AddMoveListItem(int moveNumber, string whiteMove, string blackMove)
        {
            MoveList.Add(new MoveListItem(moveNumber, whiteMove, blackMove));
        }

        public string GenerateGameAsString()
        {
            // Use StringBuilder for efficient string concatenation
            StringBuilder sb = new StringBuilder();
            // Append game metadata
            sb.AppendLine($"[Event \"{EventName}\"]");
            sb.AppendLine($"[Date \"{Date}\"]");
            sb.AppendLine($"[White \"{WhitePlayer}\"]");
            sb.AppendLine($"[Black \"{BlackPlayer}\"]");
            sb.AppendLine($"[Result \"{Result}\"]\n");

            // Append each move in the game
            foreach (var move in MoveList)
            {
                sb.AppendLine(move.ToString());
            }

            // Return the complete string representation of the game
            return sb.ToString();
        }


    }
}
