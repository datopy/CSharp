﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class BookNotFoundException : ApplicationException
    {
        public BookNotFoundException(string message) : base(message)
        {

        }
    }
}
