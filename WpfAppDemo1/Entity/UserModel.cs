using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppDemo1.Entity
{
    class UserModel
    {
        public string UserName { get; set; }
        public string Content { get; set; }
        public string FilePath { get; set; }
        public string SignTime { get; set; }
    }

    class TransactionModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime TDate { get; set; }
        public string Price { get; set; }
    }
}
