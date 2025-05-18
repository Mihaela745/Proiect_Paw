using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }         
        public string Author { get; set; }
        public int PublishingYear { get; set; }
        public bool IsAvailable { get; set; }     

        public Book() {
            Id = Guid.NewGuid();
            IsAvailable = true;
        }

        public Book(Guid id, string title, string author, int publishingYear, bool isAvailable)
         : this()
        {
            Id = id;
            Title = title;
            Author = author;
            PublishingYear = publishingYear;
            IsAvailable = isAvailable;
        }

    }
}
