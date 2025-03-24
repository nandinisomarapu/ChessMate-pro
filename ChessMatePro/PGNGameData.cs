using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate_pro
{
    public class PGNGameData
    {
        public string EventName { get; set; }
        public DateTime GameDate { get; set; }
        public string White { get; set; }

        public string Black { get; set; }

        public string Result { get; set; }
        public List<string> Moves { get; set; }


    }
}
