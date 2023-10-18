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
    public class FoodConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food { FoodId = 1, FoodName = "ÇITIR SİMİTLİ ÇILBIR", FoodDescription = "2 adet poşe yumurta, narenciyeli yoğurt, fırınlanmış simit, konfit çeri domates, pul biberli tereyağ & kuru nane", FoodPrice = 100, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 2, FoodName = "KIYMALI ÇILBIR", FoodDescription = "2 adet poşe yumurta, narenciyeli yoğurt, fırınlanmış simit, konfit çeri domates, kimyon ve maydonoz ile sote edilmiş domates soslu kıyma, pul biberli tereyağ & kuru nane", FoodPrice = 150, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 3, FoodName = "FÜME SOMON & AVOKADO POŞE YUMURTA", FoodDescription = "Kızarmış ekşi maya ekmek, dereotlu krem peynir, salatalık, füme somon, poşe yumurta, kapari, dereotu, ince kıyım yeşil soğan", FoodPrice = 120, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 4, FoodName = "LIGHT KAHVALTI TABAĞI", FoodDescription = "Ezine peynir, karışık marine zeytin, yarım avokado, çeri domates & sumaklı mini karışık yeşillik salatası, ızgara edilmiş tam tahıllı çavdar ekmeği & çırpılmış yumurta", FoodPrice = 120, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 5, FoodName = "SUCUKLU & 3 PEYNİRLİ OMLET", FoodDescription = "sucuk, çedar, mozzarella ve parmesan, yanında maskolin salatası", FoodPrice = 100, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 6, FoodName = "SAHANDA YUMURTA", FoodDescription = "2 göz yumurta (ilaveler: ezine peyniri, kaşar peyniri, sucuk, domates & biber)", FoodPrice = 80, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 7, FoodName = "OMLET", FoodDescription = "maskolin yaprakları (ilaveler: kaşar peyniri, ezine peyniri, mantar, sucuk, domates & biber)", FoodPrice = 70, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 8, FoodName = "MENEMEN", FoodDescription = "kızarmış ekşi maya ekmeği (ilaveler: ezine peyniri, sucuk 9.00)", FoodPrice = 85, ImgUrl = "food.jpg", CategoryId = 1 },
                new Food { FoodId = 9, FoodName = "PEYNİRLİ GÖZLEME", FoodDescription = "Beyaz Peynirli", FoodPrice = 50, ImgUrl = "food.jpg", CategoryId = 2 },
                new Food { FoodId = 10, FoodName = "KARIŞIK GÖZLEME", FoodDescription = "Sucuk, kaşar peynirli", FoodPrice = 70, ImgUrl = "food.jpg", CategoryId = 2 },
                new Food { FoodId = 11, FoodName = "PATATESLİ GÖZLEME", FoodDescription = "Patates", FoodPrice = 65, ImgUrl = "food.jpg", CategoryId = 2 },
                new Food { FoodId = 12, FoodName = " KIYLMALI GÖZLEME", FoodDescription = "Kıymalı", FoodPrice = 70, ImgUrl = "food.jpg", CategoryId = 2 },
                new Food { FoodId = 13, FoodName = "THE HOUSE LIGHT TOST", FoodDescription = "Çavdarlı rustik ekmek, ev salçası, taze mihaliç peyniri, tapenade sos, taze fesleğen, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates", FoodPrice = 90, ImgUrl = "food.jpg", CategoryId = 3 },
                new Food { FoodId = 14, FoodName = "ÇİFT KAŞARLI KLASİK TOST", FoodDescription = "Ekşi maya ekmeği, taze kaşar, pesto sos, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates", FoodPrice = 75, ImgUrl = "food.jpg", CategoryId = 3 },
                new Food { FoodId = 15, FoodName = "SUCUKLU & KAŞARLI BAZLAMA TOST", FoodDescription = "ev salçası, taze kaşar, sucuk, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates", FoodPrice = 85, ImgUrl = "food.jpg", CategoryId = 3 },
                new Food { FoodId = 16, FoodName = "TAVUKLU SEZAR SALATA", FoodDescription = "Izgara tavuk parçaları, parmesan, marul, çıtır ekmek, sezar sos", FoodPrice = 120, ImgUrl = "food.jpg", CategoryId = 4 },
                new Food { FoodId = 17, FoodName = "KİNOALI SEBZE SALATASI", FoodDescription = "Roka, közlenmiş renkli kapya biberler, fırınlanmış balkabağı, pancar, kabak, turp, nohut, kuru üzüm, krem peynir, kavrulmuş fındık, the house vinegret & nar ekşisi", FoodPrice = 110, ImgUrl = "food.jpg", CategoryId = 4 },
                new Food { FoodId = 18, FoodName = "AVOKADOLU & TULUM PEYNİRLİ SALATA", FoodDescription = "Esmer pirinç, guacamole, nane, marul, maydanoz, kuzu kulağı, domates, salatalık, fesleğen, yağ & limon vinegret, nar ekşisi", FoodPrice = 120, ImgUrl = "food.jpg", CategoryId = 4 },
                new Food { FoodId = 19, FoodName = "FALAFEL KASE ", FoodDescription = "Falafel topları, göbek marul, havuç, salatalık, mor & beyaz lahana, humus, sriracha (acı), guacamole, sumaklı & kırmızı soğanlı taze otlar, yağ & limon vinegret", FoodPrice = 100, ImgUrl = "food.jpg", CategoryId = 4 },

                new Food { FoodId = 20, FoodName = "ÇEDARLI DOUBLE TORRTİLLA PİZZA", FoodDescription = "2 adet çıtır meksika yufkası, çedar peyniri, domates sos, mozzarella, italyan salamı, tatlı mısır, konfit çeri domates, renkli kapya biberler, jalepeno turşusu, kestane mantarı, fesleğen, parmesan, fırınlanmış balzamikli kırmızı soğan", FoodPrice = 150, ImgUrl = "food.jpg", CategoryId = 5 },
                new Food { FoodId = 21, FoodName = "MOZZARELLA & PEPPERONI PİZZA", FoodDescription = "Suda mozzarella dilimleri, karabiberli italyan dana salamı, hafif acılı domates sos, rende mozzarella, roka yaprakları ve parmesan", FoodPrice = 150, ImgUrl = "food.jpg", CategoryId = 5 },
                new Food { FoodId = 22, FoodName = "BURRATA PİZZA", FoodDescription = "Margherita, meksika salsa, pesto sos, roka & balzamik", FoodPrice = 140, ImgUrl = "food.jpg", CategoryId = 5 },
                new Food { FoodId = 23, FoodName = "KLASİK PİZZA", FoodDescription = "İtalyan sucuğu, sotelenmiş dağ mantarları, yeşil biber, karamelize soğan, taze kekik & fesleğen, rende mozzarella, antakya yeşil zeytin, meksika salsa", FoodPrice = 165, ImgUrl = "food.jpg", CategoryId = 5 },
                new Food { FoodId = 24, FoodName = "CHEESEBURGER", FoodDescription = "Burger köftesi, double çedar peyniri, salatalık turşusu, ketçap & hardal, ince doğranmış arpacık soğan, ince patates kızartması", FoodPrice = 120, ImgUrl = "food.jpg", CategoryId = 6 },
                new Food { FoodId = 25, FoodName = "KABURGA BURGER", FoodDescription = "Ağır ateşte piştikten sonra tiftiklenmiş kaburga eti, hafif acılı barbekü sos, çedar peyniri sosu, iceberg, karamelize soğan, the house yapımı brioche burger ekmeği, alman turşu, tütsü paprikalı patates kızartması", FoodPrice = 110, ImgUrl = "food.jpg", CategoryId = 6 },
                new Food { FoodId = 26, FoodName = "THE HOUSE BURGER", FoodDescription = "Burger köftesi, eritilmiş mersin bezde tulum peyniri, aioli sos, karamelize soğan, ince patates kızartması", FoodPrice = 115, ImgUrl = "food.jpg", CategoryId = 6 },
                new Food { FoodId = 27, FoodName = "KREMALI & MANTAR SOSLU IZGARA DANA BONFİLE", FoodDescription = "Parmesan & ince kıyım yeşil soğanlı patates püresi, sote mevsim sebzeleri", FoodPrice = 200, ImgUrl = "food.jpg", CategoryId = 7 },
                new Food { FoodId = 28, FoodName = "ET KÜLBASTI", FoodDescription = "Yanında; karamelize soğan & sarımsaklı acı yağ ile sotelenmiş patates, kırmızı soğan & sumaklı taze otlar salatası", FoodPrice = 250, ImgUrl = "food.jpg", CategoryId = 7 },
                new Food { FoodId = 29, FoodName = "TAVUKLU & PORÇİNİ MANTARLI MAKARNA", FoodDescription = "Mafaldine makarna, ızgara tavuk dilimleri, porçini mantarı, krema, parmesan, maydanoz, meksika salsa", FoodPrice = 150, ImgUrl = "food.jpg", CategoryId = 8 },
                new Food { FoodId = 30, FoodName = "THE HOUSE MAKARNA", FoodDescription = "Burrata, pesto sos, casarecce makarna, konfit çeri domates, ince kıyılmış roka, kabak & patlıcan, nar ekşisi", FoodPrice = 140, ImgUrl = "food.jpg", CategoryId = 8 },
                new Food { FoodId = 31, FoodName = "İTALYAN KÖFTELİ SPAGHETTI", FoodDescription = "Yumuşacık 3 adet italyan köfte, hafif acılı domates sos, parmesan, fesleğen, maydonoz, narenciyeli yoğurt", FoodPrice = 145, ImgUrl = "food.jpg", CategoryId = 8 },
                new Food { FoodId = 32, FoodName = "ÇAY", FoodDescription = "Klasik yöntemle demlenmiş karadeniz Türk çayı", FoodPrice = 20, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 33, FoodName = "SÜTLÜ ÇAY", FoodDescription = "Klasik yöntemle demlenmiş karadeniz sütlü Türk çayı", FoodPrice = 30, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 34, FoodName = "SICAK ÇİKOLATA", FoodDescription = "", FoodPrice = 25, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 35, FoodName = "TÜRK KAHVESİ", FoodDescription = "Klasik Türk kahvesi", FoodPrice = 20, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 36, FoodName = "LATTE", FoodDescription = "Espresso, buharda ıstılımış sütün kremsi kıvamı ile hazırlanır", FoodPrice = 40, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 37, FoodName = "CAPPUCCINO", FoodDescription = "Espressonun üzerine ısıtılmış süt ,parlak ve pürüzsüz köpük ile", FoodPrice = 45, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 38, FoodName = "AMERICANO", FoodDescription = "Sıcak suyun üzerine mükemmel bir espresso", FoodPrice = 60, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 39, FoodName = "SIKMA PORTAKAL SUYU", FoodDescription = "Taze sıkılmış portakal suyu", FoodPrice = 50, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 40, FoodName = "KOLA", FoodDescription = "", FoodPrice = 40, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 41, FoodName = "FANTA", FoodDescription = "", FoodPrice = 40, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 42, FoodName = "MEYVELİ SODA", FoodDescription = "Limonlu,Karpuz çilek,Narlı", FoodPrice = 45, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 43, FoodName = "AYRAN", FoodDescription = "", FoodPrice = 30, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 44, FoodName = "SOĞUK ÇAY", FoodDescription = "Limonlu, Mangolu, Şeftalili ", FoodPrice = 50, ImgUrl = "food.jpg", CategoryId = 9 },
                new Food { FoodId = 45, FoodName = "PORTAKAL ZENCEFİLLİ YEŞİL ÇAY", FoodDescription = "Portakal aromalı zencefil çayı", FoodPrice = 60, ImgUrl = "food.jpg", CategoryId = 10 },
                new Food { FoodId = 46, FoodName = "NANE IHLAMUR", FoodDescription = "Nane aromalı ıhlamur çayı", FoodPrice = 50, ImgUrl = "food.jpg", CategoryId = 10 },
                new Food { FoodId = 47, FoodName = "YEŞİL ÇAY", FoodDescription = "Yeşil çayı", FoodPrice = 45, ImgUrl = "food.jpg", CategoryId = 10 },
                new Food { FoodId = 48, FoodName = "BAKLAVA", FoodDescription = "Taze antep fıstklı baklava", FoodPrice = 140, ImgUrl = "food.jpg", CategoryId = 11 },
                new Food { FoodId = 49, FoodName = "KÜNEFE", FoodDescription = "Hatay üslü", FoodPrice = 145, ImgUrl = "food.jpg", CategoryId = 11 },
                new Food { FoodId = 50, FoodName = "SÜTLAÇ", FoodDescription = "Fırında", FoodPrice = 100, ImgUrl = "food.jpg", CategoryId = 11 },
                new Food { FoodId = 51, FoodName = "DONDURMA", FoodDescription = "Sütlü, Çikolatalı, Çilekli", FoodPrice = 90, ImgUrl = "food.jpg", CategoryId = 11 }

                );
        }
    }
}
