﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestParameters
{
    //Base class
    public abstract class RequestParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; }
        private int _pageSize;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value > maxPageSize ? maxPageSize : value; }
        }

        public String? OrderBy { get; set; }
        public String? Fields { get; set; }
    }
}
