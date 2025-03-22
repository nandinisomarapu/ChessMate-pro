using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? GamesPlayed { get; set; }

        public virtual ICollection<Game> Games { get; set; }


    }
}
