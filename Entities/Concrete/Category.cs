﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Çıplak Class kalmasın 
    public class Category :IEntity
    {
        public int CategoyId { get; set; }  
        public string CategoryName { get; set; }

    }
}
