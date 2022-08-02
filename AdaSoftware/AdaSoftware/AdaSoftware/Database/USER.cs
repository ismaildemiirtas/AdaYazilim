using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaSoftware.Database
{
    public class USER
    {
        [PrimaryKey, AutoIncrement]
        public int USERID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PASSWORD { get; set; }
        public string IMAGE { get; set; }
        public string USERNAME { get; set; }
    }
}
