using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookedToOrderEntity.Models;

namespace CookedToOrderData.Concrete.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Kahvaltılar" },
                new Category { CategoryId = 2, CategoryName = "Gözlemeler" },
                new Category { CategoryId = 3, CategoryName = "Tostlar" },
                new Category { CategoryId = 4, CategoryName = "Salatalar" },
                new Category { CategoryId = 5, CategoryName = "Pizzalar" },
                new Category { CategoryId = 6, CategoryName = "Burgerler" },
                new Category { CategoryId = 7, CategoryName = "Etler" },
                new Category { CategoryId = 8, CategoryName = "Makarna & Risotto" },
                new Category { CategoryId = 9, CategoryName = "Sıcak İçecekler" },
                new Category { CategoryId = 10, CategoryName = "Soğuk İçecekler" },
                new Category { CategoryId = 11, CategoryName = "Bitki Çayları" },
                new Category { CategoryId = 12, CategoryName = "Tatlılar" }
                );
        }
    }
}
