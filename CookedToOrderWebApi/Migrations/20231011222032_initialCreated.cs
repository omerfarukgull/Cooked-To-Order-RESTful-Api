using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CookedToOrderWebApi.Migrations
{
    /// <inheritdoc />
    public partial class initialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Kahvaltılar" },
                    { 2, "Gözlemeler" },
                    { 3, "Tostlar" },
                    { 4, "Salatalar" },
                    { 5, "Pizzalar" },
                    { 6, "Burgerler" },
                    { 7, "Etler" },
                    { 8, "Makarna & Risotto" },
                    { 9, "Sıcak İçecekler" },
                    { 10, "Soğuk İçecekler" },
                    { 11, "Bitki Çayları" },
                    { 12, "Tatlılar" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CategoryId", "FoodDescription", "FoodName", "FoodPrice", "ImgUrl" },
                values: new object[,]
                {
                    { 1, 1, "2 adet poşe yumurta, narenciyeli yoğurt, fırınlanmış simit, konfit çeri domates, pul biberli tereyağ & kuru nane", "ÇITIR SİMİTLİ ÇILBIR", 100m, "food.jpg" },
                    { 2, 1, "2 adet poşe yumurta, narenciyeli yoğurt, fırınlanmış simit, konfit çeri domates, kimyon ve maydonoz ile sote edilmiş domates soslu kıyma, pul biberli tereyağ & kuru nane", "KIYMALI ÇILBIR", 150m, "food.jpg" },
                    { 3, 1, "Kızarmış ekşi maya ekmek, dereotlu krem peynir, salatalık, füme somon, poşe yumurta, kapari, dereotu, ince kıyım yeşil soğan", "FÜME SOMON & AVOKADO POŞE YUMURTA", 120m, "food.jpg" },
                    { 4, 1, "Ezine peynir, karışık marine zeytin, yarım avokado, çeri domates & sumaklı mini karışık yeşillik salatası, ızgara edilmiş tam tahıllı çavdar ekmeği & çırpılmış yumurta", "LIGHT KAHVALTI TABAĞI", 120m, "food.jpg" },
                    { 5, 1, "sucuk, çedar, mozzarella ve parmesan, yanında maskolin salatası", "SUCUKLU & 3 PEYNİRLİ OMLET", 100m, "food.jpg" },
                    { 6, 1, "2 göz yumurta (ilaveler: ezine peyniri, kaşar peyniri, sucuk, domates & biber)", "SAHANDA YUMURTA", 80m, "food.jpg" },
                    { 7, 1, "maskolin yaprakları (ilaveler: kaşar peyniri, ezine peyniri, mantar, sucuk, domates & biber)", "OMLET", 70m, "food.jpg" },
                    { 8, 1, "kızarmış ekşi maya ekmeği (ilaveler: ezine peyniri, sucuk 9.00)", "MENEMEN", 85m, "food.jpg" },
                    { 9, 2, "Beyaz Peynirli", "PEYNİRLİ GÖZLEME", 50m, "food.jpg" },
                    { 10, 2, "Sucuk, kaşar peynirli", "KARIŞIK GÖZLEME", 70m, "food.jpg" },
                    { 11, 2, "Patates", "PATATESLİ GÖZLEME", 65m, "food.jpg" },
                    { 12, 2, "Kıymalı", " KIYLMALI GÖZLEME", 70m, "food.jpg" },
                    { 13, 3, "Çavdarlı rustik ekmek, ev salçası, taze mihaliç peyniri, tapenade sos, taze fesleğen, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates", "THE HOUSE LIGHT TOST", 90m, "food.jpg" },
                    { 14, 3, "Ekşi maya ekmeği, taze kaşar, pesto sos, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates", "ÇİFT KAŞARLI KLASİK TOST", 75m, "food.jpg" },
                    { 15, 3, "ev salçası, taze kaşar, sucuk, the house limon vinegret ve taze kekik ile lezzetlendirilmiş domates", "SUCUKLU & KAŞARLI BAZLAMA TOST", 85m, "food.jpg" },
                    { 16, 4, "Izgara tavuk parçaları, parmesan, marul, çıtır ekmek, sezar sos", "TAVUKLU SEZAR SALATA", 120m, "food.jpg" },
                    { 17, 4, "Roka, közlenmiş renkli kapya biberler, fırınlanmış balkabağı, pancar, kabak, turp, nohut, kuru üzüm, krem peynir, kavrulmuş fındık, the house vinegret & nar ekşisi", "KİNOALI SEBZE SALATASI", 110m, "food.jpg" },
                    { 18, 4, "Esmer pirinç, guacamole, nane, marul, maydanoz, kuzu kulağı, domates, salatalık, fesleğen, yağ & limon vinegret, nar ekşisi", "AVOKADOLU & TULUM PEYNİRLİ SALATA", 120m, "food.jpg" },
                    { 19, 4, "Falafel topları, göbek marul, havuç, salatalık, mor & beyaz lahana, humus, sriracha (acı), guacamole, sumaklı & kırmızı soğanlı taze otlar, yağ & limon vinegret", "FALAFEL KASE ", 100m, "food.jpg" },
                    { 20, 5, "2 adet çıtır meksika yufkası, çedar peyniri, domates sos, mozzarella, italyan salamı, tatlı mısır, konfit çeri domates, renkli kapya biberler, jalepeno turşusu, kestane mantarı, fesleğen, parmesan, fırınlanmış balzamikli kırmızı soğan", "ÇEDARLI DOUBLE TORRTİLLA PİZZA", 150m, "food.jpg" },
                    { 21, 5, "Suda mozzarella dilimleri, karabiberli italyan dana salamı, hafif acılı domates sos, rende mozzarella, roka yaprakları ve parmesan", "MOZZARELLA & PEPPERONI PİZZA", 150m, "food.jpg" },
                    { 22, 5, "Margherita, meksika salsa, pesto sos, roka & balzamik", "BURRATA PİZZA", 140m, "food.jpg" },
                    { 23, 5, "İtalyan sucuğu, sotelenmiş dağ mantarları, yeşil biber, karamelize soğan, taze kekik & fesleğen, rende mozzarella, antakya yeşil zeytin, meksika salsa", "KLASİK PİZZA", 165m, "food.jpg" },
                    { 24, 6, "Burger köftesi, double çedar peyniri, salatalık turşusu, ketçap & hardal, ince doğranmış arpacık soğan, ince patates kızartması", "CHEESEBURGER", 120m, "food.jpg" },
                    { 25, 6, "Ağır ateşte piştikten sonra tiftiklenmiş kaburga eti, hafif acılı barbekü sos, çedar peyniri sosu, iceberg, karamelize soğan, the house yapımı brioche burger ekmeği, alman turşu, tütsü paprikalı patates kızartması", "KABURGA BURGER", 110m, "food.jpg" },
                    { 26, 6, "Burger köftesi, eritilmiş mersin bezde tulum peyniri, aioli sos, karamelize soğan, ince patates kızartması", "THE HOUSE BURGER", 115m, "food.jpg" },
                    { 27, 7, "Parmesan & ince kıyım yeşil soğanlı patates püresi, sote mevsim sebzeleri", "KREMALI & MANTAR SOSLU IZGARA DANA BONFİLE", 200m, "food.jpg" },
                    { 28, 7, "Yanında; karamelize soğan & sarımsaklı acı yağ ile sotelenmiş patates, kırmızı soğan & sumaklı taze otlar salatası", "ET KÜLBASTI", 250m, "food.jpg" },
                    { 29, 8, "Mafaldine makarna, ızgara tavuk dilimleri, porçini mantarı, krema, parmesan, maydanoz, meksika salsa", "TAVUKLU & PORÇİNİ MANTARLI MAKARNA", 150m, "food.jpg" },
                    { 30, 8, "Burrata, pesto sos, casarecce makarna, konfit çeri domates, ince kıyılmış roka, kabak & patlıcan, nar ekşisi", "THE HOUSE MAKARNA", 140m, "food.jpg" },
                    { 31, 8, "Yumuşacık 3 adet italyan köfte, hafif acılı domates sos, parmesan, fesleğen, maydonoz, narenciyeli yoğurt", "İTALYAN KÖFTELİ SPAGHETTI", 145m, "food.jpg" },
                    { 32, 9, "Klasik yöntemle demlenmiş karadeniz Türk çayı", "ÇAY", 20m, "food.jpg" },
                    { 33, 9, "Klasik yöntemle demlenmiş karadeniz sütlü Türk çayı", "SÜTLÜ ÇAY", 30m, "food.jpg" },
                    { 34, 9, "", "SICAK ÇİKOLATA", 25m, "food.jpg" },
                    { 35, 9, "Klasik Türk kahvesi", "TÜRK KAHVESİ", 20m, "food.jpg" },
                    { 36, 9, "Espresso, buharda ıstılımış sütün kremsi kıvamı ile hazırlanır", "LATTE", 40m, "food.jpg" },
                    { 37, 9, "Espressonun üzerine ısıtılmış süt ,parlak ve pürüzsüz köpük ile", "CAPPUCCINO", 45m, "food.jpg" },
                    { 38, 9, "Sıcak suyun üzerine mükemmel bir espresso", "AMERICANO", 60m, "food.jpg" },
                    { 39, 9, "Taze sıkılmış portakal suyu", "SIKMA PORTAKAL SUYU", 50m, "food.jpg" },
                    { 40, 9, "", "KOLA", 40m, "food.jpg" },
                    { 41, 9, "", "FANTA", 40m, "food.jpg" },
                    { 42, 9, "Limonlu,Karpuz çilek,Narlı", "MEYVELİ SODA", 45m, "food.jpg" },
                    { 43, 9, "", "AYRAN", 30m, "food.jpg" },
                    { 44, 9, "Limonlu, Mangolu, Şeftalili ", "SOĞUK ÇAY", 50m, "food.jpg" },
                    { 45, 10, "Portakal aromalı zencefil çayı", "PORTAKAL ZENCEFİLLİ YEŞİL ÇAY", 60m, "food.jpg" },
                    { 46, 10, "Nane aromalı ıhlamur çayı", "NANE IHLAMUR", 50m, "food.jpg" },
                    { 47, 10, "Yeşil çayı", "YEŞİL ÇAY", 45m, "food.jpg" },
                    { 48, 11, "Taze antep fıstklı baklava", "BAKLAVA", 140m, "food.jpg" },
                    { 49, 11, "Hatay üslü", "KÜNEFE", 145m, "food.jpg" },
                    { 50, 11, "Fırında", "SÜTLAÇ", 100m, "food.jpg" },
                    { 51, 11, "Sütlü, Çikolatalı, Çilekli", "DONDURMA", 90m, "food.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
