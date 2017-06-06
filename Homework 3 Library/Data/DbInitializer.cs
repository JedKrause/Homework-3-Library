﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework_3_Library.Models;

namespace Homework_3_Library.Data
{
    public class DbInitializer
    {
        public static void Initilize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Patrons.Any())
            {
                return;
            }
            var patrons = new Patron[]
            {
                 new Patron{FirstName="Jed",LastName="Krause",MembershipDate=DateTime.Parse("2015-09-01")},
                 new Patron{FirstName="Daniel",LastName="Boon",MembershipDate=DateTime.Parse("2012-09-01")},
                 new Patron{FirstName="Frank",LastName="Sinatra",MembershipDate=DateTime.Parse("2013-09-01")},
                 new Patron{FirstName="Paul",LastName="Krause",MembershipDate=DateTime.Parse("2012-09-01")},
                 new Patron{FirstName="Joey",LastName="Wheeler",MembershipDate=DateTime.Parse("2012-09-01")},
                 new Patron{FirstName="Ashley",LastName="Williams",MembershipDate=DateTime.Parse("2011-09-01")},
                 new Patron{FirstName="Steve",LastName="Young",MembershipDate=DateTime.Parse("2013-09-01")},
                 new Patron{FirstName="Bob",LastName="Smith",MembershipDate=DateTime.Parse("2015-09-01")}
            };
            foreach (Patron p in patrons)
            {
                context.Patrons.Add(p);
            }
            context.SaveChanges();
            var books = new Book[]
            {
                 new Book{BookID=1234,Title="The Hobbit",Genre="Fantasy"},
                 new Book{BookID=5678,Title="The Fellowship of the Ring",Genre="Fantasy"},
                 new Book{BookID=9101,Title="The Two Towers",Genre="Fantasy"},
                 new Book{BookID=1121,Title="The Retun of the King",Genre="Fantasy"},
                 new Book{BookID=3141,Title="Silmarillion",Genre="Fantasy"},
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
            var rentals = new Rental[]
            {
                 new Rental{PatronID=1,BookID=1234,DueDate = DateTime.Parse("2017-5-5")},
                 new Rental{PatronID=1,BookID=5678,DueDate = DateTime.Parse("2017-6-6")},
                 new Rental{PatronID=1,BookID=9101,DueDate = DateTime.Parse("2017-7-7")},
                 new Rental{PatronID=2,BookID=1234,DueDate= DateTime.Parse("2017-8-8")},
                 new Rental{PatronID=2,BookID=5678,DueDate= DateTime.Parse("2017-9-9")},
                 new Rental{PatronID=2,BookID=9101,DueDate= DateTime.Parse("2017-1-1")},
                 new Rental{PatronID=3,BookID=1234,DueDate= DateTime.Parse("2017-2-2")},
                 new Rental{PatronID=4,BookID=1234,DueDate= DateTime.Parse("2017-3-3")},
                 new Rental{PatronID=4,BookID=5678,DueDate= DateTime.Parse("2017-4-4")},
                 new Rental{PatronID=5,BookID=5678,DueDate= DateTime.Parse("2017-10-10")},
                 new Rental{PatronID=6,BookID=9101,DueDate= DateTime.Parse("2017-11-11")},
                 new Rental{PatronID=7,BookID=3141,DueDate= DateTime.Parse("2017-12-12")},
            };
            foreach (Rental r in rentals)
            {
                context.Rentals.Add(r);
            }
            context.SaveChanges();
        }
    }
}
