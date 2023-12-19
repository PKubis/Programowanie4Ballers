using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4Ballers.Data.Migrations
{
    public partial class InitialSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Nike", "Pierwsze z butów zaprojektowane dla Michaela Jordana w 1985 roku", "jordan1.png", "Jordan I Mid", 599.99m },
                    { 2, "Nike", "Michale zagrał w meczu gwiazd, zdobył koronę najlepszego strzelca ligi przekraczając granicę 3000 punktów. Ponadto wygrał konkurs wsadów oraz w dziewięciu kolejnych spotkaniach zdobył 40 i więcej punktów.", "jordan2.jpg", "Jordan II", 929.99m },
                    { 3, "Nike", " Michael ponownie zagrał w meczu gwiazd, trzeci raz z rzędu zdobył tytuł najlepszego strzelca ligi. Jego powietrzne akrobacje oraz słynny jordanowski język stały się jego znakiem firmowym.", "jordan4.jpg", "Jordan IV", 1863.37m },
                    { 4, "Nike", "Z roku na rok Jordan gra coraz lepiej. Ciężka praca popłaca.Michale zdobywa 69 punktów w meczu przeciwko Cavaliers. Zostaje wybrany do pierwszej piątki NBA, występuje w meczy All-Star oraz po raz czwarty z rzędu zdobywa tytuł najlepszego strzelca.", "jordan5.jpg", "Jordan V", 1049.99m },
                    { 5, "Nike", "Trzecie mistrzostwo NBA z zespołem Bulls. Siódmy tytuł najlepszego snajpera ligi. Podczas potyczki finałowej, Jordan zdobywa średnio w meczu 41 punktów.", "jordan8.jpg", "Jordan VIII", 1364.56m },
                    { 6, "Nike", " Pierwszy model obuwia z serii Air Jordan, w których Michael nigdy nie zagrał w meczu ligowym. Jordan odchodzi z NBA i rozpoczyna przygodę z baseball'em.", "jordan9.png", "Jordan IX", 3947.99m },
                    { 7, "Nike", "Tinker Hatfield, który projektował Air Jordan od III do XV, powrócił aby zaprojektować XX. To fani Tinker domagali się aby Nike go o to poprosiło", "jordan20.jpg", "Jordan XX", 1460.00m },
                    { 8, "Nike", "Drugi model wydany dla znakomitego koszykarza Cleavlend Cavaliers LeBron James", "lebron2.png", "Lebron II", 1399.99m },
                    { 9, "Nike", "Jordan Max Aura 4 to sneakersy, które nigdy nie pójdą w odstawkę! Ich wyrazisty design pozwala na tworzenie ciekawych outfitów w klimacie urban-city.", "MaxAura.png", "Max Aura", 449.00m },
                    { 10, "Nike", "Dzięki designowi inspirowanemu wysokim stylem koszykówki i graffiti z lat 90. te buty przyciągają wzrok.", "pippen.png", "UpTempo", 699.00m },
                    { 11, "Nike", "Jedenasta wersja \"Air Jordanów\" została uznana za najbardziej wyjątkową pośród wszystkich modeli obuwia MJ.", "jordan11.jpg", "Jordan XI", 999.99m },
                    { 12, "Nike", "Jordan kontynuuje swą dominację na parkietach ligi NBA, zdobywając czwarty tytuł mistrzowski z Pippenem i spółką z Chicago", "jordan12.png", "Jordan XII", 999.99m },
                    { 13, "Nike", "Trzynastki to jedne z ładniejszych modeli Air Jordans mają gładko przebiegające linie są bardzo żywe. Projekt bazuje na łapie Czarnej Pantery. Zielonkawe holograficzne 'oko' na pięcie przedstawia oko zwierzęcia a podeszwa przypomina łapę. AJ XIII są bardzo wygodne i mają świetną przyczepność", "jordan13.jpg", "Jordan XIII", 760.99m },
                    { 14, "Nike", "Czternasty model \"air jordanów\" nawiązywał do pasji Jordana do samochodów. Styliści zrobili niemalże wszystko, aby ten model był odzwierciedleniem ulubionego auta MJ, Ferrari 550 M", "jordan14.jpg", "Jordan XIV", 597.00m },
                    { 15, "Nike", "Air Jordan specjalnie wykonany na ostatni sezon Michaela Jordana w jego wspaniałej karierze.", "jordan18.jpg", "Jordan XVIII", 709.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
