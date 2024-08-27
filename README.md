# Wst�p

To repozytorium zawiera moje rozwi�zanie zadania rekrutacyjnego kt�re od Pa�stwa otrzyma�em.
Repozytorium zawiera dwa projekty: pierwszy jest serwisem wystawiaj�cym Rest API umo�liwiaj�cym interakcj� z baz� daynch w SQL Server poprzez API (adres bazy konfigurowany przez ConnectionString).
Drugi projekt jest prostym interfejsem stworzonym w WinForms. Zawiera zamockowany formularz logowania, faktyczne formularze widoku zada� (ze strony pracownika) oraz prosty formularz tworzenia obiektu. Akcje formularza s� powi�zane z us�ug� API.
Model bazy zosta� zaprojektowany przez Entity Framework Core z podej�ciem Code First.

# Dodatkowe informacje
## Czego nie zd��y�em zrobi�:
- widoku menad�era, kt�ry by�by kopi� widoku pracownika z dodatkiem podzia�u task�w na miesi�ce
- wadliwym jest dzia�anie edycji zadania, cz�� zmian si� zapisuje natomiast nie od�wie�a na widoku
## Co mo�na jeszcze zrobi�:
- uwierzytelnianie domenowe, za pomoc� konta Windows
- zmiana implementacji walidacji wysy�anych request�w (podzia� na role u�ytkownika)
- zaimplementowanie jednej metody do wo�ania MessageBox.Show z b��dami (w ramach clean code, DRY)
- usprawniona klasa do przechowywania ListViewItem dla zada�, obecny spos�b implementacji otwiera furtki do utraty danych
- mo�na by�o napisa� wi�cej test�w