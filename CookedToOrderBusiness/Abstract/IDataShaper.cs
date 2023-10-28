﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeDate(IEnumerable<T> etities, string fieldsString);
        ExpandoObject ShapeDate(T entity, string fieldsString);
    }
}
