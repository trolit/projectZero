# Project Zero 


<p align="center">
 <a href="https://en.wikipedia.org/wiki/List_of_video_game_genres"><img src="https://img.shields.io/badge/Gatunek-Sandbox%20RPG,%20Educational-blue?color=DC4C46&style=for-the-badge" style="max-height: 300px;"></a>
<a><img src="https://img.shields.io/badge/Obs%C5%82ugiwany%20j%C4%99zyk-polski-blue?color=eead0e&style=for-the-badge" style="max-height: 300px;"></a>
<a href="https://www.microsoft.com/net"><img src="https://img.shields.io/badge/Inicjacja%20projektu-16%20czerwca%202019-blue?color=5B5EA6&style=for-the-badge" style="max-height: 300px;"></a>
<a href="https://www.techopedia.com/definition/32207/target-platform"><img src="https://img.shields.io/badge/Platforma-Win32/Win64-green?style=for-the-badge&color=C48F65" style="max-height: 300px;"></a>
<a href="https://www.microsoft.com/net"><img src="https://img.shields.io/badge/Framework-4.7.1-blueviolet.svg?style=for-the-badge&logo=.NET" style="max-height: 300px;"></a>
<a href="https://unity3d.com/get-unity/download/archive"><img src="https://img.shields.io/badge/Wersja-2018.3.12f1-orange?color=577284&style=for-the-badge&logo=unity" style="max-height: 300px;"></a>
<a href="https://en.wikipedia.org/wiki/MIT_License"><img src="https://img.shields.io/badge/Licencja-MIT-blue?style=for-the-badge" style="max-height: 300px;"></a>
</p>

## O projekcie

### Wstęp
<p align="justify">
Projekt realizowany jest w ramach pracy inżynierskiej pod kryptonimem "Project Zero". Inicjatorem pomysłu na pracę inżynierską jest Paweł Idzikowski. Został on zaakceptowany przez współautora - Adama Grabowskiego a w dalszym etapie zlecony do realizacji przez promotora - dr. Piotra Jastrzębskiego. Project Zero to gra wykonana w Unity 3D w perspektywie "top-down view", co w języku polskim moglibyśmy przetłumaczyć jako "widok z lotu ptaka". Oprócz rozrywki, gra ma na celu wesprzeć naukę programowania. Odbiorcami są przede wszystkim osoby rozpoczynające swoją przygodę z programowaniem, ale także i te, które chciałyby sobie coś przypomnieć. Minimalny wiek odbiorcy uważamy za 11-12 lat. Języki, które obejmuje gra to: Java, JavaScript, C#, HTML i PHP. Gracz tworzy postać, której przypisuje z podstawowej puli punkty do atrybutów. Atrybutami są języki programowania. <br/> 
</p>
<p align="justify">
Po rozpoczęciu gry, gracz porusza się przygotowaną postacią po świecie, który podzielony jest na krainy. W każdej krainie dominuje odrębny język. Kraina identyfikowana jest rodzajem terenu. W trakcie podziwiania krain gracz napotka istoty, z którymi będzie mógł porozmawiać. W trakcie konwersacji dowie się, że mają do rozwiązania problemy. Gracz może udzielić pomocy pod warunkiem, że poziom umiejętności postaci z danego języka przewyższa wymagany próg, bądź jest na równi. Udzielenie pomocy wiąże się z rozegraniem minigry. W Project Zero zaimplementowane są 4 minigry - wieżowiec(quiz), pinpin(podpięcie), puzzle, labirynt. Każdy poziom to unikalny design sceny i oprawa muzyczna. Za pomyślne przejście minigry, gracz nagradzany jest pieniędzmi i dodatkowymi informacjami w podsumowaniach na temat języka, który był tematem minigry. Pieniądze, które zbierze może wydać w sklepie na np. książki. Przeczytanie książki spowoduje podniesienie umiejętności z tego języka programowania, który ksiązka opisuje. <br/> 
</p>
<p align="justify">
Gra została przygotowana w taki sposób, aby przy jednym podejściu nie dało się wykupić wszystkich książek - a więc, aby zdobyć maksymalne umiejętności we wszystkich językach. Ma to na celu nie tylko zachęcić do ponownego przejścia gry z innym rozdysponowaniem umiejętności, ale też po to, aby dać do zrozumienia graczowi, że nie jesteśmy w stanie być specjalistami we wszystkich językach. Możemy znać każdy język - oczywiście - ale i tak prędzej czy później będziemy musieli skorzystać z pomocy np. przeglądarki Google, aby przypomnieć sobie, jak daną rzecz się robiło w danym języku programowania. Dodatkowym motywatorem do ponownego przejścia gry jest unikalny design poziomów i oprawa muzyczna. <br/> 
</p>
<p align="justify">
Pewnie interesuje Was informacja, dlaczego nazwa projektu brzmi Project Zero? Można to interpretować na wiele sposobów. Dla przykładu: zero, bo gra oferuje treści dla osób, które zaczynają programowanie i chciałyby zdobyć jakiś pogląd na temat uwzględnionych języków. Inna interpretacja: jest to większe przedsiewzięcie autorów w środowisku Unity3D. Można też tytułowe "zero" potraktować jako projekt wyjściowy w ramach pierwszego stopnia naukowego. Jest sporo pomysłów na interpretację tego tytułu :)   
</p>

### Mechanika
<p align="justify">
:small_orange_diamond: Gracz tworzy swoją postać nadając jej pseudonim, wybierając model spośród dostępnych oraz przyznając punkty umiejętności z podstawowej puli. Nie jest obowiązkowym nadanie pseudonimu, wybranie modelu i rozdanie wszystkich dostępnych punktów do rozdysponowania. Gracz ma pełną dowolność. <br/>
:small_orange_diamond: Rozgrywka toczy się na mapie w której rozlokowane są krainy. Każda kraina jest reprezentowana przez specyficzny język i teren. W jej obszarach znajdują się postaci, z którymi gracz może wejść w interakcje (NPC). <br/>
:small_orange_diamond: NPC posiadają zadania, które może wykonać gracz. Podejście do zadania, to rozegranie minigry pod warunkiem, że poziom umiejętności gracza jest przynajmniej równy wymaganemu poziomowi. Szczegółowe informacje dotyczące mechaniki poszczególnych minigier zostały przedstawione w dziale odnośnie minigier.  <br/>
:small_orange_diamond: Ukończenie minigry wiąże się z otrzymaniem wynagrodzenia i informacji. O ile, w grze typu puzzle uzyskuje się stałą wartość pieniędzy, to w pozostałych trzech wpływ na wysokość kwoty ma liczba pomyłek. Przekazywana treść także zależy od typu minigry. <br/>
:small_orange_diamond: Pieniądze mogą być wydane w sklepach. <br/>
:small_orange_diamond: Podstawowym asortymentem sklepów są książki. <br/>
:small_orange_diamond: Na każdą krainę przypada jeden sklep. <br/>
:small_orange_diamond: Książka zawiera informacje na temat wybranego języka. Dodatkowo jej odczytanie rozwija umiejętności gracza w języku, którego dotyczy pozwalając uzyskać dostęp do kolejnych minigier. <br/>
:small_orange_diamond: Celem gry jest poznanie/przypomnienie elementów, które gra porusza. <br/>
:small_orange_diamond: Grę można uznać za "ukończoną" w 100%, jeżeli gracz przejdzie wszystkie dostępne minigry (nie jednym podejściem!). <br/>
:small_orange_diamond: Nie jest możliwe przegranie rozgrywki z koniecznością rozpoczęcia nowej.
:small_orange_diamond: Jedyną grą jaką można powtórzyć ponownie jest gra typu labirynt.
</p>

### Rodzaje krain i ich tereny
| Język | Rodzaj terenu |
| :---:  | :---: |
| C# | teren zalesiony (styl wiosenny |
| Java | teren pustynny | 
| HTML | teren górzysty |
| JavaScript | teren zimowy |
| PHP | teren zalesiony (styl jesienny) | 

### Minigry
W tej sekcji poznasz szczegóły zaimplementowanych minigier.

#### Minigra wieżowiec (quiz)
<p align="justify">
W tej minigrze postać pojawia się na szczycie "metaforycznego wieżowca", który zbudowany jest z kilku poziomów. Każdy poziom to pytanie i cztery odpowiedzi do wyboru. Wybranie błędnej odpowiedzi nie wpływa na wieżowiec. Gracz znajduje się na danym poziomie do momentu, aż nie wybierze prawidłowej odpowiedzi. Po wybraniu poprawnej - gracz trafia na niższy poziom, w którym jest kolejne pytanie i kolejne odpowiedzi. Minigra trwa dopóki gracz nie dojdzie do podstawy wieżowca. Zazwyczaj jest to po 4-5 odbytych poziomach.
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
Minigra labirynt to gra, w której zadaniem gracza jest unikanie "bugów" i zbieranie fragmentów kodu. Zebranie pewnej ilości bugów powoduje obniżenie jakości informacji, które otrzymamy po ukończeniu gry i obniża ostateczną kwotę uzyskaną za przejście minigry. Jeżeli chcemy poznać te informację i uzyskać większą wygraną to możemy poprawić wynik powtarzając poziom. W przypadku zakończenia rozgrywki zadanie zostaje oznaczene jako wykonane, gracz otrzymuje kwotę, która została mu pokazana na ekranie i nie będzie mógł już powtórzyć tego poziomu. Labirynt jest jedynym typem minigry, który można powtórzyć.
</p>

### Walory edukacyjne
<p align="justify">
Gra oferuje poznanie języków C#, HTML, Java, JavaScript, PHP w sposób nierygorystyczny. Oznacza to, że graczowi nie jest narzucany obowiązek analizowania oferowanej wiedzy. Przekazywana jest ona poprzez
</p>

- treści zawarte w książkach
- treści zawarte w ekranach wczytywania 
- podsumowania minigier
  - w rozgrywkach w stylu puzzle poruszane są elementy, które wystąpiły w układankach
  - poziomy typu labirynt to porcje dodatkowych informacji  
  - typu pinpin zawierają poprawne fragmenty kodów z rozgrywki 
  - typu wieżowiec zawierają podsumowania wybranych odpowiedzi

Przedstawione informacje są skondensowane w taki sposób aby
- nie odrzucały/zamęczały odbiorcy nadmiarem tekstu,
- były na zasadzie "haseł-kluczy" aby gracz mógł w łatwy sposób wyszukać te treści w Internecie

### Od autora (Paweł Idzikowski)
<p align="justify">
Ze względu na zakres wykonanych zadań Project Zero traktuję jako pełnoprawny tytuł. Projekt nie obejmuje wszystkich aspektów każdego z uwzględnionych języków i nie definiuje każdego z pojęć w sposób wyczerpujący. Dałoby się to co prawda zrobić, jednak postawmy sobie pytanie - Czy taka gra nie stałaby się nudna po X jednostek czasu? Moim zdaniem - tak. Czy pomógłby najwyższy budżet? Nie. Na chwilę obecną gry uczące programowania idą bardziej w kierunku podstaw, czyli myślenia, jak ułożyć kod z prostych komend typu idź do przodu, obróć się w prawo aby dotrzeć z punktu A do B aniżeli konkretów z danego języka. Przykładem takiej produkcji jest Rabbids Coding, która - na marginesie - swoją premierę ma wyzaczoną na 8 października 2019 roku i będzie dostępna dla każdego... także.. warto zerknąć. Ćwiczenie znajomości konkretnego języka jest bardziej widoczne w aplikacjach (np. na platformę Androida). Sam z ciekawości taką aplikację sprawdziłem jednak nie utrzymała się długo na moim urządzeniu ale to już inna kwestia. Wracając do tematu sensu takich gier.. Skupienie się na jakimś języku np. C# to już na starcie ograniczenie liczby odbiorców - nie każdy musi go lubić. W czasach obecnych nieodłącznym elementem większości topowych gier jest tryb wieloosobowy. Przy analizie produktu czynnikiem kluczowym jest też wiek odbiorców. Biorąc pod uwagę swoje pierwsze doświadczenia z programowaniem (w 2007 roku modyfikowałem plugin do wtedy popularnej gry Counter Strike 1.6, który był napisany w języku C++ pod nazwą kodową: Blockmaker) myślę, że minimalny wiek odbiorcy Project Zero ustaliłbym na 11-12 lat. Problematyczne w grach edukacyjnych takiego typu są też technologie. Stale się rozwijają więc gra, która nie byłaby modernizowana pod względem treści to gra martwa. Jedyny sposób, w jaki widzę takie gry, to produkcje z gatunku indie - nieduży budżet, masa fajnych rozwiązań i przemycona w jakimś stopniu liczba istotnych informacji. Z rywalizacją online? Czemu nie. W zwartym zespole posiadającym animatorów, designerów modeli, programistów i level designerów myślę, że produkt miałby szansę zyskać niemałe zainteresowanie nie tylko graczy ale i osób z obszaru edukacji w tematyce IT. W Project Zero wiedza przekazywana jest w sposób, aby zachęcać odbiorce do zgłębiania omawianych treści poza grą. Oprócz tworzenia czegoś, co miałoby mieć "użyteczne podłoże", zależało mi też na tym, aby był to projekt, którym warto się pochwalić i zapisać jako udany projekt do kolekcji :) 
</p>

### Od autora (Adam Grabowski)
<p align="justify">
<oczekiwanie na publikacje>
</p>

### Zrzuty ekranu z gry
<do późniejszej publikacji>

## Sekcja dla devów

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
:two::zero: system repetytywności (nie uda się rozegrać wszystkich minigier za jednym podejściem) <br/>
:two::one: system osiągnięć (medale) - jeżeli czas pozwoli <br/>
:two::three: dodatkowe rzeczy w sklepie - jeżeli czas pozwoli <br/>

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
Należy mieć także na uwadze fakt, że klawiszologia w finalnym projekcie może się różnić od tej zaprezentowanej poniżej! <br/>
W - przód <br/> 
A - lewo <br/>
S - dół <br/>
D - prawo <br/>
B - otwarcie plecaka w którym mamy książki (badz tez nie jak zadnej jeszcze nie kupilismy) <br/>
F - interakcja z NPC (wejście w rozmowe) <br/>
Spacja [przytrzymanie] - złapanie i przesuwanie puzzla/pinezki <br/>
LPM (lewy przycisk myszy) - klikanie w sklepie -> kupowanie książek, otwieranie książek z inventory(plecaka) etc 

### Wykorzystane materiały
W pliku Wykorzystane.txt umieszczone są odnośniki do rzeczy, które zostały wykorzystane w projekcie - głównie są to assety, muzyka i grafiki. Będą one uwiecznione w sekcji "Uznania" w grze oraz prawdopodobnie w README (w późniejszym czasie). 

### Wersja narzędzia Unity
2018.3.12f1 

### Wersja .NET Framework:
v 4.7.1 

### Klucze 
<do późniejszej publikacji>

### Zawartość podsumowań
<do późniejszej publikacji>

### Zrealizowane zadania
<do późniejszej publikacji>
