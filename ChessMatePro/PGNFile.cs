using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
    public class PGNFile
    {
        [Key]
        public Guid PGNFileID { get; set; }
        public string Moves { get; set; }
        public string Annotations { get; set; }
        public string Comments { get; set; }
        public string ExportStatus { get; set; }

       

    }
}
