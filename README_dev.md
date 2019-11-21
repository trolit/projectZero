<p align="center">
<a href="https://github.com/trolit/projectZero"><img src="https://img.shields.io/badge/DOKUMENTACJA%20DLA%20UŻYTKOWNIKA%20(KLIKNIJ%20ABY%20PRZEJ%C5%9A%C4%86)-gray?color=986F8E&style=for-the-badge&logo=Atom" style="max-height: 550px;"></a>
</p>

## Dokumentacja developera

### Ciekawostki
- liczba linii kodu (tzw. sloc) katalogu Scripts na 13.11.19 - **6 136** (wartość bez uwzględnienia pustych linii),
- liczba skryptów katalogu Scripts - **108** ,
- w projekcie użyto 42 utworów muzycznych co daje łącznie **2 godziny 23 minut** czasu potrzebnego do ich wysłuchania,
- najdłużej trwającą czynnością było projektowanie (design) otoczenia mini-gier aby był zróżnicowany,
- najbardziej męczącą czynnością było projektowanie mini-gier z otoczeniem drzew (szczególnie dla języka PHP),
- najlepszym pomysłem było wdrożenie konsoli deweloperskiej z racji skali projektu (okazała się dużą pomocą w testowaniu),
- projekt 'rozpakowany' przez edytor Unity waży **2,55GB**,
- nagrody za medale, medale oraz dodatkowa postać nie były planowane w momencie ustalenia zakresu prac,
- na terenie krainy C# mieli być ludzie ale nie było dostępnego ciekawego assetu,
- jako najbardziej złożony skrypt zakwalifikowac można NPCHandler,
- najwięcej problemów było z przygotowaniem skryptu Pickup w minigrze typu Puzzle (efekt nie był taki jaki oczekiwano) ale został przerobiony i teraz wygląda solidnie,
- gdyby nie (powolne) rozpoczęcie projektu już w czerwcu to na 100% nie zostałby ukończony,
- projekt osiągnął 45 dyskusji na github z czego 3 opatrzono znaczkiem 'bug',
- czas okrążenia sceny Map najkrótszą ścieżką postacią Slime Rabbit wyniósł ok. 1min 47s,
- przejście bez zatrzymania całej sceny Map postacią Slime Rabbit wyniósł ok. 4min 30s,
- projekt zawiera 92 grafiki, 10 niestandardowych czcionek, 30 assetów,
- inspiracją HUD gracza na scenie Map był ten zaproponowany w Tom Clancy's Rainbow Six Siege,
- wersja grywalna posiada **52** sceny, a projekt posiada dodatkowo scene zaprojektowanej przedniej i tylnej okładki gry,
- plecak miał być początkowo faktycznym plecakiem w którym są puste miejsca i jak się zakupi książki to do tych pustych miejsc zostają wrzucone. Z racji ograniczenia czasu wybrano wariant lżejszy czyli "panel z wszystkimi książkami" jednak aby je przeczytać należy je wykupić.

### Mechanika
<p align="justify">
:small_orange_diamond:Gracz tworzy swoją postać nadając jej pseudonim, wybierając model spośród dostępnych oraz przyznając punkty umiejętności z podstawowej puli. Nie jest obowiązkowym nadanie pseudonimu, wybranie modelu i rozdanie wszystkich dostępnych punktów do rozdysponowania. Gracz ma pełną dowolność. <br/>
:small_orange_diamond: Rozgrywka toczy się na mapie w której rozlokowane są krainy, które gracz ma możliwość zwiedzać. Każda kraina jest reprezentowana przez specyficzny język i teren. W jej obszarach znajdują się postaci, z którymi gracz może wejść w interakcje (NPC). <br/>
:small_orange_diamond:NPC posiadają zadania, które gracz może wykonać. Podejście do zadania, to rozegranie minigry pod warunkiem, że poziom umiejętności gracza jest przynajmniej równy wymaganemu poziomowi. Szczegółowe informacje dotyczące mechaniki poszczególnych minigier zostały przedstawione w dziale odnośnie minigier.  <br/>
:small_orange_diamond:Ukończenie minigry wiąże się z otrzymaniem wynagrodzenia i informacji. O ile, w grze typu puzzle uzyskuje się stałą wartość pieniędzy, to w pozostałych trzech wpływ na wysokość kwoty ma liczba pomyłek. Przekazywana treść także zależy od typu minigry o czym wspomniane jest w sekcji - walory edukacyjne. <br/>
:small_orange_diamond: Pieniądze mogą być wydane w sklepach. <br/>
:small_orange_diamond: Podstawowym asortymentem sklepów są książki. <br/>
:small_orange_diamond: Na każdą krainę przypada jeden sklep. <br/>
:small_orange_diamond: Książka zawiera informacje na temat wybranego języka. Odczytanie jej rozwija umiejętności gracza w języku, którego dotyczy pozwalając uzyskać dostęp do kolejnych minigier. <br/>
:small_orange_diamond: Celem gry jest poznanie/przypomnienie elementów, które gra porusza. <br/>
:small_orange_diamond: Grę można uznać za "ukończoną" w 100%, jeżeli gracz przejdzie wszystkie dostępne minigry (nie jednym podejściem!). <br/>
:small_orange_diamond: Nie jest możliwe przegranie rozgrywki z koniecznością rozpoczęcia nowej. <br/>
:small_orange_diamond: Jedyną grą jaką można powtórzyć ponownie jest gra typu labirynt. 
</p>

### Rodzaje krain, teren i istoty
| Język | Rodzaj terenu | Rodzaj istoty |
| :---:  | :---: | :---: |
| C# | teren zalesiony (styl wiosenny) | pies |
| Java | teren pustynny | kot |
| HTML | teren górzysty | królik |
| JavaScript | teren zimowy | pingwin |
| PHP | teren zalesiony (styl jesienny) | mysz | 

### Minigry
W tej sekcji poznasz szczegóły zaimplementowanych minigier.

#### Minigra wieżowiec (quiz)
<p align="justify">
W tej minigrze postać pojawia się na szczycie "metaforycznego wieżowca", który zbudowany jest z kilku poziomów. Każdy poziom to pytanie i cztery odpowiedzi do wyboru. Wybranie błędnej odpowiedzi nie wpływa na konstrukcje wieżowca. Gracz znajduje się na danym poziomie do momentu, aż nie wybierze prawidłowej odpowiedzi. Po wybraniu poprawnej, trafia na niższy poziom, w którym jest kolejne pytanie i kolejne odpowiedzi. Minigra trwa dopóki gracz nie dojdzie do podstawy wieżowca. Zazwyczaj jest to po 4-5 odbytych poziomach.
</p>

#### Minigra pinpin (podpięcie) 
<p align="justify">
Minigra pinpin(nazwa projektowa) jest podobna do wieżowca, jednak tutaj do wyboru dostajemy fragmenty kodu i musimy wybrać te, które odpowiadają terenowi, na którym się znajdujemy i w dodatku są poprawne (przykładowo: jeżeli uruchomiliśmy mini-grę na terenie C#, to musimy wybrać poprawny kod, który jest zapisany we wspomnianym języku). Do wyboru kodu służy nam "pinezka" ukazana w postaci "pucharu", który przesuwamy na wybrany kod. Jeżeli jesteśmy pewni to stajemy na przycisku służącym do weryfikacji naszej decyzji. Prawidłowe umieszczenie pinezki oznacza przejście do kolejnego etapu, natomiast błędnej, konieczność wybrania innej opcji z pozostałych i ponownej weryfikacji swojego wyboru. Błędne decyzje są podliczane i wpływają na wysokość wynagrodzenia za przejście poziomu. 
</p>

#### Minigra puzzle
<p align="justify">
Minigra, w której układamy puzzle z podanego kodu. Celem jest poprawne rozmieszczenie kodu. Aby ułatwić rozgrywkę dla osób początkujących, umieszczenie puzzla w odpowiednim miejscu powoduje jego oznaczenie i zablokowanie przed dalszym przesunięciem. W nagrodę uzyskujemy pieniądze i informacje na temat kodu, który był układany.  
</p>

#### Minigra labirynt
<p align="justify">
Minigra labirynt to gra, w której zadaniem gracza jest unikanie bloków będących "bugami" programu i zbieranie fragmentów kodu. Osiągnięcie pewnej ilości bugów powoduje obniżenie jakości informacji, które otrzymamy po ukończeniu gry i pomniejsza ostateczną kwotę uzyskaną za przejście minigry. Jeżeli chcemy poznać te informację i uzyskać większą wygraną to możemy poprawić wynik powtarzając poziom. W przypadku zakończenia rozgrywki zadanie zostaje oznaczene jako wykonane, gracz otrzymuje kwotę, która została mu pokazana na ekranie i nie będzie mógł już powtórzyć tego poziomu. Labirynt jest jedynym typem minigry, który można powtórzyć.
</p>

### Grafiki koncepcyjne
| Zarys krain | Przykład mapy | Zarys z przejściami |
| :---:  | :---:  | :---:  |
| <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_0.png?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_1.jpg?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_2.jpg?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> |
| Wieżowiec (z boku) | Wieżowiec (z góry) | Menu |
| <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_3.png?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_4.png?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_5.jpg?raw=true" alt="Koncepcja menu" width="350px" height="140px"></img> | 
| Tworzenie postaci | NPC (1) | NPC (2) |
| <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_6.jpg?raw=true" alt="Koncepcja tworzenia postaci" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_7.png?raw=true" alt="Koncepcja tworzenia postaci" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_8.png?raw=true" alt="Koncepcja tworzenia postaci" width="350px" height="140px"></img> |

### Planowane elementy
:zero::zero: perspektywa rozgrywki z lotu ptaka (top down view) <br/>
:zero::one: główny świat podzielony na 5 krain </br>
:zero::two: zróżnicowany styl każdej z przygotowanych krain </br>
:zero::three: poruszające się istoty dzięki technologii Unity <br/>
:zero::four: możliwość interakcji z wybranymi istotami <br/>
:zero::five: plecak w którym znajdują się książki, które można odczytać <br/>
:zero::six: kreator postaci <br/>
:zero::seven: waluta <br/>
:zero::eight: rozwój postaci poprzez czytanie książek <br/>
:zero::nine: minigra typu wieżowiec (quiz) <br/>
:one::zero: minigra typu labirynt <br/>
:one::one: minigra typu pinpin (podpięcie) <br/>
:one::two: minigra typu puzzle <br/>
:one::three: łączna liczba 40 minigier do rozegrania <br/>
:one::four: łączna liczba 20 książek do sprawdzenia <br/>
:one::five: ponad 40 utworów muzycznych do zbadania <br/>
:one::six: podsumowania minigier oraz ekrany wczytywania z dawką programistycznej wiedzy <br/>
:one::seven: zróżnicowany design poziomów minigier <br/>
:one::eight: zróżnicowana oprawa muzyczna w każdej minigrze <br/> 
:one::nine: ustawienia najważniejszych aspektów gry <br/>
:two::zero: repetytywność (nie uda się rozegrać wszystkich minigier za jednym podejściem) <br/>
:two::one: medale <br/>
:two::two: nagrody za medale <br/>

### Kolory reprezentacyjne krain
| Język | Kolor | Kodowa nazwa w Unity | Próbka |
| :---:  | :---:  | :---:  | :---: |
| C# | limonkowy | lime | ![#00FF00](https://placehold.it/25/00FF00/000000?text=+) |
| JavaScript | jasnoniebieski | cyan | ![#00ffff](https://placehold.it/25/00ffff/000000?text=+) |
| Java | żółty | yellow | ![#FFFF00](https://placehold.it/25/FFFF00/000000?text=+) |
| HTML | magenta | magenta | ![#ff00ff](https://placehold.it/25/ff00ff/000000?text=+) |
| PHP | pomarańczowy | orange | ![#FFA500](https://placehold.it/25/FFA500/000000?text=+) |

### Klawiszologia 
Uwaga! Klawiszologia może się różnić w zależności od tego w jaką mini-gierkę gramy bądź też czy znajdujemy się na mapie głównej <br/>
W - przód <br/> 
A - lewo <br/>
S - dół <br/>
D - prawo <br/>
B - otwarcie plecaka w którym mamy książki (badz tez nie jak zadnej jeszcze nie kupilismy) <br/>
F - interakcja z NPC (wejście w rozmowe) <br/>
Spacja [przytrzymanie] - złapanie i przesuwanie puzzla/pinezki <br/>
LPM (lewy przycisk myszy) - klikanie w sklepie -> kupowanie książek, otwieranie książek z inventory(plecaka) etc 

### Wykorzystane materiały
W pliku Wykorzystane.txt umieszczone są odnośniki do rzeczy, które zostały wykorzystane w projekcie - głównie są to assety, muzyka i grafiki. Będą one uwiecznione w sekcji "Uznania" w grze. Dokument można znaleźć <a href="https://github.com/trolit/projectZero/blob/master/Wykorzystane.txt">pod tym adresem</a>. 

### Konfiguracja Edytora
**Uwaga!** Aby uzyskać poprawny odczyt okna 'Game' należy utworzyć sobie profil rozdziałki **1920x1080**, ustawić go i zmniejszyć parametr Scale do minimum (t.j. **0,372**)

### Wersja narzędzia Unity
2018.3.12f1 

### Wersja .NET Framework
v 4.7.1 

### Zdjęcia z etapu projektowania
Zdjęcia z etapu projektowania gry znaleźć można w <a href="https://github.com/trolit/projectZero/issues/33">tym</a> wątku. A <a href="https://github.com/trolit/projectZero/issues/29">pod tym</a> adresem dostępne są urywkowe zdjęcia ze scen mini-gier typu labirynt, puzzle i pinpin(przypinka).

### Wideo z etapu projektowania
Adresy do klipów wideo umieszczonych w serwisie youtube z etapu projektowania gry dostępne są <a href="https://github.com/trolit/projectZero/issues/35">tutaj</a>.

### Analiza strategii 
Analizę odblokowań poziomów, wynagrodzeń, kar można znaleźć <a href="https://github.com/trolit/projectZero/issues/5">w tym</a> poście natomiast wycenę książek <a href="https://github.com/trolit/projectZero/issues/38">tutaj</a>.

### Zbiór kluczy 
Wszystkie użyte klucze w projekcie wraz z opisem dostępne są w <a href="https://github.com/trolit/projectZero/issues/4" target="_blank">tym</a> wątku.

### Zawartość podsumowań
Zawartość podsumowań dla mini-gier typu labirynt/pinpin/puzzle znajdziesz <a href="https://github.com/trolit/projectZero/issues/7">tu</a>.

### Zrealizowane zadania
Zadania jakie zostały zrealizowane w ramach projektu dostępne są <a href="https://github.com/trolit/projectZero/issues/2">tutaj</a>.
