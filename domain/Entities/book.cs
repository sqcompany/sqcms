﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain.Entities
{
    public class book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public byte[] Thumbnail { get; set; }
        public decimal Price { get; set; }
        public DateTime Published { get; set; }
    }
}
