﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7Assignment.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}