# Wstêp

To repozytorium zawiera moje rozwi¹zanie zadania rekrutacyjnego które od Pañstwa otrzyma³em.
Repozytorium zawiera dwa projekty: pierwszy jest serwisem wystawiaj¹cym Rest API umo¿liwiaj¹cym interakcjê z baz¹ daynch w SQL Server poprzez API (adres bazy konfigurowany przez ConnectionString).
Drugi projekt jest prostym interfejsem stworzonym w WinForms. Zawiera zamockowany formularz logowania, faktyczne formularze widoku zadañ (ze strony pracownika) oraz prosty formularz tworzenia obiektu. Akcje formularza s¹ powi¹zane z us³ug¹ API.
Model bazy zosta³ zaprojektowany przez Entity Framework Core z podejœciem Code First.

# Dodatkowe informacje
## Czego nie zd¹¿y³em zrobiæ:
- widoku menad¿era, który by³by kopi¹ widoku pracownika z dodatkiem podzia³u tasków na miesi¹ce
- wadliwym jest dzia³anie edycji zadania, czêœæ zmian siê zapisuje natomiast nie odœwie¿a na widoku
## Co mo¿na jeszcze zrobiæ:
- uwierzytelnianie domenowe, za pomoc¹ konta Windows
- zmiana implementacji walidacji wysy³anych requestów (podzia³ na role u¿ytkownika)
- zaimplementowanie jednej metody do wo³ania MessageBox.Show z b³êdami (w ramach clean code, DRY)
- usprawniona klasa do przechowywania ListViewItem dla zadañ, obecny sposób implementacji otwiera furtki do utraty danych
- mo¿na by³o napisaæ wiêcej testów