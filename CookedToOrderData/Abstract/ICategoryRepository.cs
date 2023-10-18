﻿using CookedToFoodCore.DataAccess;
using CookedToOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookedToOrderData.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
    }
}