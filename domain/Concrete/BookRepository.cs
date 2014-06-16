﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using domain.Abstract;
using domain.Entities;

namespace domain.Concrete
{
    public class BookRepository : IBookRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<book> Books
        {
            get { return context.Books; }
        }
    }
}
