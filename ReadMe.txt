Strona 4Ballers versja Visual Studio Community 2022 .NET SDK 6.0

W celu wglądu do istniejących produktów dostępnych w bazie należy aktualizować migrację 
Narzędzia/Menadżer pakietów NuGet/Konsola menadżera pakietów
w poleceniu wpisujemy
Update-Database

W przypadku problemów z EmailSender należy wpisać w konsoli pakietów NuGet komendę 
Update-Package -ProjectName 4Ballers

Dostępne zakładki dla użytkowników nie zalogowanych 
4Ballers - powrót do strony głównej z logo programu 
Historia - Krótki opis historii koszykówki 
Drużyny - Aktualna lista drużyn amerykańskiej Ligi NBA 
Szczegóły drużyn dostępne tylko dla zalogowanych użytkowników
Kontakt - informacje do kontaktu z autorem oraz dostępny formularz kontaktowy wysyłający emaile 
Obuwie - Lista dostępnych produktów w sklepie 
Możliwość kupowania produktów możliwa tylko dla zalogowanych użytkowników
Rejestracja - przekierowanie do formularzu rejestracji konta
Logowanie - przekierowanie do formularza logowania na stronę 

Po utworzeniu konta w formularzu rejestracji Klikamy na "Kliknij tutaj aby potwierdzić swoje konto"
Wtedy dostajemy komunikat zwrotny "Dziękujemy za potwierdzenie e-maila."

Teraz można się zalogować przy użyciu swojego loginu i hasła.
Zyskujemy dostęp do wszystkich opcji programu. 
Czyli w zakładce Drużyny możemy zajrzeć do każdej z wyświetlonej drużyny i zobaczymy krótki opis wraz ze zdjęciem Boiska ,na którym grają
W zakładce Obuwie zyskujemy możliwośc wejścia w szczegóły obuwia które nas interesuje z możliwością wyboru rozmiaru i funkcją przenoszenia produktu do koszyka.
Pojawia się także zakładka Koszyk w której mamy wgląd do butów które zapisaliśmy i sumę w złotówkach wszystkich wybranych produktów oraz każdego z osobna.


Zakładając konto przy użyciu  maila piotrkubis1989@gmail.com zyskujemy funkcję admina.
Admin może dodawać produkty wpisując ich 
Nazwę , Markę , Cenę ,wgrać obraz który znajduję się w wwwroots/images . dodać opis produktu

Edytować produkty : 
Możliwośc zmiany wszystkich wyżej wymienionych danych produktów które już istnieją 


Możliwośc Usuwania produktu ze strony 
Widok Koszyka zawiera oprócz podstawowych informacji :
Logo,Produkt,Rozmiar,Ilość,Cena 
dodatkową opcje :
Kupujący w której mamy podgląd emaila osoby która dodała do koszyka dany produkt.