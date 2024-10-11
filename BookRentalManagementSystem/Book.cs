using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    internal class Book
    {
        private int bookId { get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private decimal rentalPrice { get; set; }
    }
}
