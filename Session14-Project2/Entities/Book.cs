using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_Project2.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int AuthorId { get; set; }

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
