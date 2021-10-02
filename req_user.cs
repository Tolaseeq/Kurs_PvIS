using System;
using System.Collections.Generic;
using System.Text;

namespace KURS_SERGEEV
{
    class req_user
    {
        //commit
        public int id { get; set; }
        public bool active { get; set; }  //true - забанить, false - разбанить
        public string email { get; set; }
        public string user_name { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string password { get; set; }
        public string user_role_name { get; set; }
    }
}
