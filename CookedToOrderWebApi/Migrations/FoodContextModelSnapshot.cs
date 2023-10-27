﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Repositories.Concrete;

#nullable disable

namespace CookedToOrderWebApi.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CookedToOrderEntity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kahvaltılar"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Gözlemeler"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Tostlar"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Salatalar"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Pizzalar"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Burgerler"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Etler"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Makarna & Risotto"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Sıcak İçecekler"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Soğuk İçecekler"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Bitki Çayları"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Tatlılar"
                        });
                });

            modelBuilder.Entity("CookedToOrderEntity.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FoodDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FoodPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            CategoryId = 1,
                            FoodDescription = "2 adet poşe yumurta, narenciyeli yoğurt, fırınlanmış simit, konfit çeri domates, pul biberli tereyağ & kuru nane",
                            FoodName = "ÇITIR SİMİTLİ ÇILBIR",
                            FoodPrice = 100m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 2,
                            CategoryId = 1,
                            FoodDescription = "2 adet poşe yumurta, narenciyeli yoğurt, fırınlanmış simit, konfit çeri domates, kimyon ve maydonoz ile sote edilmiş domates soslu kıyma, pul biberli tereyağ & kuru nane",
                            FoodName = "KIYMALI ÇILBIR",
                            FoodPrice = 150m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 3,
                            CategoryId = 1,
                            FoodDescription = "Kızarmış ekşi maya ekmek, dereotlu krem peynir, salatalık, füme somon, poşe yumurta, kapari, dereotu, ince kıyım yeşil soğan",
                            FoodName = "FÜME SOMON & AVOKADO POŞE YUMURTA",
                            FoodPrice = 120m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 4,
                            CategoryId = 1,
                            FoodDescription = "Ezine peynir, karışık marine zeytin, yarım avokado, çeri domates & sumaklı mini karışık yeşillik salatası, ızgara edilmiş tam tahıllı çavdar ekmeği & çırpılmış yumurta",
                            FoodName = "LIGHT KAHVALTI TABAĞI",
                            FoodPrice = 120m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 5,
                            CategoryId = 1,
                            FoodDescription = "sucuk, çedar, mozzarella ve parmesan, yanında maskolin salatası",
                            FoodName = "SUCUKLU & 3 PEYNİRLİ OMLET",
                            FoodPrice = 100m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 6,
                            CategoryId = 1,
                            FoodDescription = "2 göz yumurta (ilaveler: ezine peyniri, kaşar peyniri, sucuk, domates & biber)",
                            FoodName = "SAHANDA YUMURTA",
                            FoodPrice = 80m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 7,
                            CategoryId = 1,
                            FoodDescription = "maskolin yaprakları (ilaveler: kaşar peyniri, ezine peyniri, mantar, sucuk, domates & biber)",
                            FoodName = "OMLET",
                            FoodPrice = 70m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 8,
                            CategoryId = 1,
                            FoodDescription = "kızarmış ekşi maya ekmeği (ilaveler: ezine peyniri, sucuk 9.00)",
                            FoodName = "MENEMEN",
                            FoodPrice = 85m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 9,
                            CategoryId = 2,
                            FoodDescription = "Beyaz Peynirli",
                            FoodName = "PEYNİRLİ GÖZLEME",
                            FoodPrice = 50m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 10,
                            CategoryId = 2,
                            FoodDescription = "Sucuk, kaşar peynirli",
                            FoodName = "KARIŞIK GÖZLEME",
                            FoodPrice = 70m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 11,
                            CategoryId = 2,
                            FoodDescription = "Patates",
                            FoodName = "PATATESLİ GÖZLEME",
                            FoodPrice = 65m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 12,
                            CategoryId = 2,
                            FoodDescription = "Kıymalı",
                            FoodName = " KIYLMALI GÖZLEME",
                            FoodPrice = 70m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 13,
                            CategoryId = 3,
                            FoodDescription = "Çavdarlı rustik ekmek, ev salçası, taze mihaliç peyniri, tapenade sos, taze fesleğen, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates",
                            FoodName = "THE HOUSE LIGHT TOST",
                            FoodPrice = 90m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 14,
                            CategoryId = 3,
                            FoodDescription = "Ekşi maya ekmeği, taze kaşar, pesto sos, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates",
                            FoodName = "ÇİFT KAŞARLI KLASİK TOST",
                            FoodPrice = 75m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 15,
                            CategoryId = 3,
                            FoodDescription = "ev salçası, taze kaşar, sucuk, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates",
                            FoodName = "SUCUKLU & KAŞARLI BAZLAMA TOST",
                            FoodPrice = 85m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 16,
                            CategoryId = 4,
                            FoodDescription = "Izgara tavuk parçaları, parmesan, marul, çıtır ekmek, sezar sos",
                            FoodName = "TAVUKLU SEZAR SALATA",
                            FoodPrice = 120m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 17,
                            CategoryId = 4,
                            FoodDescription = "Roka, közlenmiş renkli kapya biberler, fırınlanmış balkabağı, pancar, kabak, turp, nohut, kuru üzüm, krem peynir, kavrulmuş fındık, the house vinegret & nar ekşisi",
                            FoodName = "KİNOALI SEBZE SALATASI",
                            FoodPrice = 110m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 18,
                            CategoryId = 4,
                            FoodDescription = "Esmer pirinç, guacamole, nane, marul, maydanoz, kuzu kulağı, domates, salatalık, fesleğen, yağ & limon vinegret, nar ekşisi",
                            FoodName = "AVOKADOLU & TULUM PEYNİRLİ SALATA",
                            FoodPrice = 120m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 19,
                            CategoryId = 4,
                            FoodDescription = "Falafel topları, göbek marul, havuç, salatalık, mor & beyaz lahana, humus, sriracha (acı), guacamole, sumaklı & kırmızı soğanlı taze otlar, yağ & limon vinegret",
                            FoodName = "FALAFEL KASE ",
                            FoodPrice = 100m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 20,
                            CategoryId = 5,
                            FoodDescription = "2 adet çıtır meksika yufkası, çedar peyniri, domates sos, mozzarella, italyan salamı, tatlı mısır, konfit çeri domates, renkli kapya biberler, jalepeno turşusu, kestane mantarı, fesleğen, parmesan, fırınlanmış balzamikli kırmızı soğan",
                            FoodName = "ÇEDARLI DOUBLE TORRTİLLA PİZZA",
                            FoodPrice = 150m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 21,
                            CategoryId = 5,
                            FoodDescription = "Suda mozzarella dilimleri, karabiberli italyan dana salamı, hafif acılı domates sos, rende mozzarella, roka yaprakları ve parmesan",
                            FoodName = "MOZZARELLA & PEPPERONI PİZZA",
                            FoodPrice = 150m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 22,
                            CategoryId = 5,
                            FoodDescription = "Margherita, meksika salsa, pesto sos, roka & balzamik",
                            FoodName = "BURRATA PİZZA",
                            FoodPrice = 140m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 23,
                            CategoryId = 5,
                            FoodDescription = "İtalyan sucuğu, sotelenmiş dağ mantarları, yeşil biber, karamelize soğan, taze kekik & fesleğen, rende mozzarella, antakya yeşil zeytin, meksika salsa",
                            FoodName = "KLASİK PİZZA",
                            FoodPrice = 165m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 24,
                            CategoryId = 6,
                            FoodDescription = "Burger köftesi, double çedar peyniri, salatalık turşusu, ketçap & hardal, ince doğranmış arpacık soğan, ince patates kızartması",
                            FoodName = "CHEESEBURGER",
                            FoodPrice = 120m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 25,
                            CategoryId = 6,
                            FoodDescription = "Ağır ateşte piştikten sonra tiftiklenmiş kaburga eti, hafif acılı barbekü sos, çedar peyniri sosu, iceberg, karamelize soğan, the house yapımı brioche burger ekmeği, alman turşu, tütsü paprikalı patates kızartması",
                            FoodName = "KABURGA BURGER",
                            FoodPrice = 110m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 26,
                            CategoryId = 6,
                            FoodDescription = "Burger köftesi, eritilmiş mersin bezde tulum peyniri, aioli sos, karamelize soğan, ince patates kızartması",
                            FoodName = "THE HOUSE BURGER",
                            FoodPrice = 115m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 27,
                            CategoryId = 7,
                            FoodDescription = "Parmesan & ince kıyım yeşil soğanlı patates püresi, sote mevsim sebzeleri",
                            FoodName = "KREMALI & MANTAR SOSLU IZGARA DANA BONFİLE",
                            FoodPrice = 200m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 28,
                            CategoryId = 7,
                            FoodDescription = "Yanında; karamelize soğan & sarımsaklı acı yağ ile sotelenmiş patates, kırmızı soğan & sumaklı taze otlar salatası",
                            FoodName = "ET KÜLBASTI",
                            FoodPrice = 250m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 29,
                            CategoryId = 8,
                            FoodDescription = "Mafaldine makarna, ızgara tavuk dilimleri, porçini mantarı, krema, parmesan, maydanoz, meksika salsa",
                            FoodName = "TAVUKLU & PORÇİNİ MANTARLI MAKARNA",
                            FoodPrice = 150m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 30,
                            CategoryId = 8,
                            FoodDescription = "Burrata, pesto sos, casarecce makarna, konfit çeri domates, ince kıyılmış roka, kabak & patlıcan, nar ekşisi",
                            FoodName = "THE HOUSE MAKARNA",
                            FoodPrice = 140m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 31,
                            CategoryId = 8,
                            FoodDescription = "Yumuşacık 3 adet italyan köfte, hafif acılı domates sos, parmesan, fesleğen, maydonoz, narenciyeli yoğurt",
                            FoodName = "İTALYAN KÖFTELİ SPAGHETTI",
                            FoodPrice = 145m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 32,
                            CategoryId = 9,
                            FoodDescription = "Klasik yöntemle demlenmiş karadeniz Türk çayı",
                            FoodName = "ÇAY",
                            FoodPrice = 20m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 33,
                            CategoryId = 9,
                            FoodDescription = "Klasik yöntemle demlenmiş karadeniz sütlü Türk çayı",
                            FoodName = "SÜTLÜ ÇAY",
                            FoodPrice = 30m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 34,
                            CategoryId = 9,
                            FoodDescription = "",
                            FoodName = "SICAK ÇİKOLATA",
                            FoodPrice = 25m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 35,
                            CategoryId = 9,
                            FoodDescription = "Klasik Türk kahvesi",
                            FoodName = "TÜRK KAHVESİ",
                            FoodPrice = 20m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 36,
                            CategoryId = 9,
                            FoodDescription = "Espresso, buharda ıstılımış sütün kremsi kıvamı ile hazırlanır",
                            FoodName = "LATTE",
                            FoodPrice = 40m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 37,
                            CategoryId = 9,
                            FoodDescription = "Espressonun üzerine ısıtılmış süt ,parlak ve pürüzsüz köpük ile",
                            FoodName = "CAPPUCCINO",
                            FoodPrice = 45m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 38,
                            CategoryId = 9,
                            FoodDescription = "Sıcak suyun üzerine mükemmel bir espresso",
                            FoodName = "AMERICANO",
                            FoodPrice = 60m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 39,
                            CategoryId = 9,
                            FoodDescription = "Taze sıkılmış portakal suyu",
                            FoodName = "SIKMA PORTAKAL SUYU",
                            FoodPrice = 50m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 40,
                            CategoryId = 9,
                            FoodDescription = "",
                            FoodName = "KOLA",
                            FoodPrice = 40m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 41,
                            CategoryId = 9,
                            FoodDescription = "",
                            FoodName = "FANTA",
                            FoodPrice = 40m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 42,
                            CategoryId = 9,
                            FoodDescription = "Limonlu,Karpuz çilek,Narlı",
                            FoodName = "MEYVELİ SODA",
                            FoodPrice = 45m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 43,
                            CategoryId = 9,
                            FoodDescription = "",
                            FoodName = "AYRAN",
                            FoodPrice = 30m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 44,
                            CategoryId = 9,
                            FoodDescription = "Limonlu, Mangolu, Şeftalili ",
                            FoodName = "SOĞUK ÇAY",
                            FoodPrice = 50m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 45,
                            CategoryId = 10,
                            FoodDescription = "Portakal aromalı zencefil çayı",
                            FoodName = "PORTAKAL ZENCEFİLLİ YEŞİL ÇAY",
                            FoodPrice = 60m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 46,
                            CategoryId = 10,
                            FoodDescription = "Nane aromalı ıhlamur çayı",
                            FoodName = "NANE IHLAMUR",
                            FoodPrice = 50m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 47,
                            CategoryId = 10,
                            FoodDescription = "Yeşil çayı",
                            FoodName = "YEŞİL ÇAY",
                            FoodPrice = 45m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 48,
                            CategoryId = 11,
                            FoodDescription = "Taze antep fıstklı baklava",
                            FoodName = "BAKLAVA",
                            FoodPrice = 140m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 49,
                            CategoryId = 11,
                            FoodDescription = "Hatay üslü",
                            FoodName = "KÜNEFE",
                            FoodPrice = 145m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 50,
                            CategoryId = 11,
                            FoodDescription = "Fırında",
                            FoodName = "SÜTLAÇ",
                            FoodPrice = 100m,
                            ImgUrl = "food.jpg"
                        },
                        new
                        {
                            FoodId = 51,
                            CategoryId = 11,
                            FoodDescription = "Sütlü, Çikolatalı, Çilekli",
                            FoodName = "DONDURMA",
                            FoodPrice = 90m,
                            ImgUrl = "food.jpg"
                        });
                });

            modelBuilder.Entity("CookedToOrderEntity.Food", b =>
                {
                    b.HasOne("CookedToOrderEntity.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CookedToOrderEntity.Category", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
