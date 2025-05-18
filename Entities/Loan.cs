using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Entities
{
    internal class Loan
    {
        public Guid LoanId { get; set; }
        public Guid BookId { get; set; }
        public Guid ReaderId {  get; set; }
        public DateTime LoanDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public Loan()
        {
            
        }

        public Loan(Guid id, Guid bookId, Guid readerId, DateTime loanDate, DateTime? returnDate)
        {
            LoanId = id;
            BookId = bookId;
            ReaderId = readerId;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }
    }
}
