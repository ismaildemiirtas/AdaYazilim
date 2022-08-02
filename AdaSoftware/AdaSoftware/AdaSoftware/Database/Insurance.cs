using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaSoftware.Database
{
    public class Insurance
    {

        [PrimaryKey, AutoIncrement]
        public int InsuranceID { get; set; }
        public string COMPANY { get; set; }
        public string TYPE { get; set; }
        public string YEAR { get; set; }
        public string DETAILS { get; set; }
    }
}
