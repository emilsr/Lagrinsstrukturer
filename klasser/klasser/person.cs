using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser
{
    class person
    {
        public string namn { get; set; }
        public string efterNamn { get; set; }

        public string hellaNamn { get { return namn+ " " + efterNamn; } }
        public int antal { get { return namn.Length + efterNamn.Length; } }
        public int datum { get; set; }
    }

}
