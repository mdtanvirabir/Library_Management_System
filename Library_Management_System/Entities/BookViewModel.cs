using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Entities
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisiher { get; set; }
        public DateTime PbulishDate { get; set; }
        public int Quantity { get; set; }
        public decimal BookRentAmount { get; set; }
        public string ImgPath { get; set; }
        public bool Gender { get; set; }
        public int EmployeeId { get; set; }
        public int BorrowerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string FullName { get; set; }
        public string EmpUserName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPassword { get; set; }
        public string ImagePath { get; set; }

    }
}
