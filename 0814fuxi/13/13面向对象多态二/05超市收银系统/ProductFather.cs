﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05超市收银系统
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public ProductFather(string id,double price,string name)
        {
            this.Price = price;
            this.ID = id;
            this.Name = name;
        }
    }
}
