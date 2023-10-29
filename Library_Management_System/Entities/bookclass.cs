using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Entities
{
    public class bookclass
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisiher { get; set; }
        public DateTime PbulishDate { get; set; }
        public int Quantity { get; set; }
        public decimal BookRentAmount { get; set; }
        public string ImgPath { get; set;}
        public bool Available { get; set;}
        public int EmployeeId { get; set; }       
        
        public int BorrowerId { get; set; }

    }
}
