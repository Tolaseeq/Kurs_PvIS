using System;
using System.Collections.Generic;
using System.Text;

namespace KURS_SERGEEV
{
    class req_user
    {
        //commit
        public int id { get; set; }
        public bool ban_status { get; set; }  //true - забанить, false - разбанить
        public bool is_admin { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }
}
