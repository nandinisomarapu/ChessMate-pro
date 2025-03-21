using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
    public class PGNFile
    {
        public Guid PGNFileID { get; set; }
        public string Moves { get; set; }
        public string Annotations { get; set; }
        public string Comments { get; set; }
        public string ExportStatus { get; set; }

        public ICollection<Game> Games { get; set; }

    }
}
