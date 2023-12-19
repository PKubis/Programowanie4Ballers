using _4Ballers.Models;
using Microsoft.EntityFrameworkCore;

namespace _4Ballers.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                // Tutaj dodajesz produkty, które chcesz zaseedować
                new Product { Id = 1, Name = "Jordan I Mid", Brand = "Nike", Price = 599.99M, ImageUrl = "jordan1.png", Description = "Pierwsze z butów zaprojektowane dla Michaela Jordana w 1985 roku" },
                new Product { Id = 2, Name = "Jordan II", Brand = "Nike", Price = 929.99M, ImageUrl = "jordan2.jpg", Description = "Michale zagrał w meczu gwiazd, zdobył koronę najlepszego strzelca ligi przekraczając granicę 3000 punktów. Ponadto wygrał konkurs wsadów oraz w dziewięciu kolejnych spotkaniach zdobył 40 i więcej punktów." },
               new Product { Id = 3, Name = "Jordan IV", Brand = "Nike", Price = 1863.37M, ImageUrl = "jordan4.jpg", Description = " Michael ponownie zagrał w meczu gwiazd, trzeci raz z rzędu zdobył tytuł najlepszego strzelca ligi. Jego powietrzne akrobacje oraz słynny jordanowski język stały się jego znakiem firmowym." },
               new Product { Id = 4, Name = "Jordan V", Brand = "Nike", Price = 1049.99M, ImageUrl = "jordan5.jpg", Description = "Z roku na rok Jordan gra coraz lepiej. Ciężka praca popłaca.Michale zdobywa 69 punktów w meczu przeciwko Cavaliers. Zostaje wybrany do pierwszej piątki NBA, występuje w meczy All-Star oraz po raz czwarty z rzędu zdobywa tytuł najlepszego strzelca." },
               new Product { Id = 5, Name = "Jordan VIII", Brand = "Nike", Price = 1364.56M, ImageUrl = "jordan8.jpg", Description = "Trzecie mistrzostwo NBA z zespołem Bulls. Siódmy tytuł najlepszego snajpera ligi. Podczas potyczki finałowej, Jordan zdobywa średnio w meczu 41 punktów." },
               new Product { Id = 6, Name = "Jordan IX", Brand = "Nike", Price = 3947.99M, ImageUrl = "jordan9.png", Description = " Pierwszy model obuwia z serii Air Jordan, w których Michael nigdy nie zagrał w meczu ligowym. Jordan odchodzi z NBA i rozpoczyna przygodę z baseball'em." },
               new Product { Id = 7, Name = "Jordan XX", Brand = "Nike", Price = 1460.00M, ImageUrl = "jordan20.jpg", Description = "Tinker Hatfield, który projektował Air Jordan od III do XV, powrócił aby zaprojektować XX. To fani Tinker domagali się aby Nike go o to poprosiło" },
               new Product { Id = 8, Name = "Lebron II", Brand = "Nike", Price = 1399.99M, ImageUrl = "lebron2.png", Description = "Drugi model wydany dla znakomitego koszykarza Cleavlend Cavaliers LeBron James" },
               new Product { Id = 9, Name = "Max Aura", Brand = "Nike", Price = 449.00M, ImageUrl = "MaxAura.png", Description = "Jordan Max Aura 4 to sneakersy, które nigdy nie pójdą w odstawkę! Ich wyrazisty design pozwala na tworzenie ciekawych outfitów w klimacie urban-city." },
               new Product { Id = 10, Name = "UpTempo", Brand = "Nike", Price = 699.00M, ImageUrl = "pippen.png", Description = "Dzięki designowi inspirowanemu wysokim stylem koszykówki i graffiti z lat 90. te buty przyciągają wzrok." },
               new Product { Id = 11, Name = "Jordan XI", Brand = "Nike", Price = 999.99M, ImageUrl = "jordan11.jpg", Description = "Jedenasta wersja \"Air Jordanów\" została uznana za najbardziej wyjątkową pośród wszystkich modeli obuwia MJ." },
               new Product { Id = 12, Name = "Jordan XII", Brand = "Nike", Price = 999.99M, ImageUrl = "jordan12.png", Description = "Jordan kontynuuje swą dominację na parkietach ligi NBA, zdobywając czwarty tytuł mistrzowski z Pippenem i spółką z Chicago" },
               new Product { Id = 13, Name = "Jordan XIII", Brand = "Nike", Price = 760.99M, ImageUrl = "jordan13.jpg", Description = "Trzynastki to jedne z ładniejszych modeli Air Jordans mają gładko przebiegające linie są bardzo żywe. Projekt bazuje na łapie Czarnej Pantery. Zielonkawe holograficzne 'oko' na pięcie przedstawia oko zwierzęcia a podeszwa przypomina łapę. AJ XIII są bardzo wygodne i mają świetną przyczepność" },
               new Product { Id = 14, Name = "Jordan XIV", Brand = "Nike", Price = 597.00M, ImageUrl = "jordan14.jpg", Description = "Czternasty model \"air jordanów\" nawiązywał do pasji Jordana do samochodów. Styliści zrobili niemalże wszystko, aby ten model był odzwierciedleniem ulubionego auta MJ, Ferrari 550 M" },
               new Product { Id = 15, Name = "Jordan XVIII", Brand = "Nike", Price = 709.00M, ImageUrl = "jordan18.jpg", Description = "Air Jordan specjalnie wykonany na ostatni sezon Michaela Jordana w jego wspaniałej karierze." }
            );
        }
    }
}