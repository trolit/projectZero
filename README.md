# Project Zero

## 1. O projekcie
Projekt realizowany w ramach pracy inżynierskiej pod kryptonimem "Project Zero". Autorem pomysłu na pracę inżynierską jest Paweł Idzikowski. Został on zaakceptowany przez współautora - Adama Grabowskiego oraz w dalszym etapie przez promotora - dr. Piotra Jastrzębskiego. Project Zero to gra wykonana w Unity 3D w perspektywie "top-down view" - widoku z lotu ptaka. Oprócz dawania rozrywki ma ona też na celu pomóc w nauce programowania. Odbiorcami są przede wszystkim osoby rozpoczynające swoją przygodę z programowaniem ale także i te, które chciałyby sobie coś przypomnieć. Języki, które obejmuje gra to: Java, JavaScript, C#, HTML i PHP. Gracz tworzy postać, której przypisuje z podstawowej puli punkty do atrybutów. Atrybutami są języki programowania. <br/> <br/> 

Po wejściu do gry gracz porusza się swoją postacią po świecie, który podzielony jest na krainy. W każdej krainie dominuje odrębny język. Kraina identyfikowana jest rodzajem terenu* (patrz punkt 1.2). W trakcie podziwiania krain gracz napotka istoty z którymi będzie mógł porozmawiać. W trakcie konwersacji dowie się, że dana postać ma problem i potrzebuje pomocy. Gracz może udzielić jej pomocy jeżeli poziom umiejętności z danego języka przewyższa wymagany próg bądź jest na równi. Udzielenie pomocy polega na rozegraniu minigry. W Project Zero zaimplementowane są 4 minigry - wieżowiec(quiz), pinpin(podpięcie), puzzle, labirynt. Za pomyślne przejście minigry gracz nagradzany jest pieniędzmi i dodatkowymi informacjami w podsumowaniach na temat języka, który był tematem minigry. Pieniądze, które zbierze może wydać w sklepie na książki. Przeczytanie książki spowoduje podniesienie umiejętności z tego języka programowania który ksiązka opisuje. <br/> <br/> 

Gra została przygotowana w taki sposób aby przy jednym podejściu nie dało się wykupić wszystkich książek - a więc aby zdobyć maksymalne umiejętności we wszystkich językach. Ma to na celu nie tylko zachęcić do ponownego przejścia gry z innym rozdysponowaniem umiejętności ale też po to aby dać do zrozumienia graczowi, że nie jesteśmy w stanie być specjalistami we wszystkich językach. Możemy znać każdy język - oczywiście - ale i tak prędzej czy później będziemy musieli skorzystać z pomocy "wujka Google" aby przypomnieć sobie jak daną rzecz się robiło w danym języku programowania. 

Pewnie interesuje Was informacja dlaczego nazwa projektu brzmi Project Zero? Można to interpretować na wiele sposobów. Dla przykładu: zero bo gra oferuje treści dla osób, które zaczynają programowanie i chciałyby zdobyć jakiś pogląd na temat języków wymienionych w punkcie 1.1. Inna interpretacja: jest to większe przedsiewzięcie autorów w środowisku Unity3D. Można też tytułowe "zero" potraktować jako projekt wyjściowy w ramach pracy inżynierskiej. Jest sporo pomysłów na interpretację tego tytułu :)   

### 1.1 Od autora (Paweł Idzikowski)
Ze względu na zakres wykonanych zadań Project Zero uznać można za pełnoprawny tytuł. Projekt nie obejmuje wszystkich aspektów każdego z uwzględnionych języków. Dałoby się to co prawda zrobić jednak postawmy sobie pytanie - Czy taka gra nie stałaby się nudna po X jednostek czasu? Moim zdaniem - tak. Czy pomógłby najwyższy budżet? Nie i doprowadziłby do bankructwa bo zyski byłyby niewielkie. Na chwilę obecną nie ma takiej gry. Skupienie się na danym języku np. C# to już na starcie ograniczenie liczby odbiorców. W czasach obecnych nieodłącznym elementem topowych gier jest tryb wieloosobowy. Wartym uwagi jest także czynnik - wiek odbiorców. Kolejna rzecz - technologie stale się rozwijają więc gra, która niebyłaby stale aktualizowana to gra martwa. Jedyny sposób w jaki widzę takie gry to gry typu indie - nieduży budżet, masa fajnych rozwiązań i przemycona niewielka liczba informacji tak aby zachęcić odbiorcę do poczytania na własną rękę. W Project Zero wiedza przekazywana jest właśnie w taki sposób aby zachęcała graczy do zgłębiania omawianych treści poza grą. Oprócz tworzenia czegoś co miałoby mieć "użyteczne podłoże", zależało mi też na tym aby był to projekt, którym warto się pochwalić i zapisać jako udany projekt do kolekcji :) 

### 1.2 Od autora (Adam Grabowski)

### 1.3 Języki programowania jako atrybuty postaci
C#, HTML, Java, Javascript, PHP

### 1.4 Rodzaje krain i ich tereny
C# - teren zalesiony (styl wiosenny) <br/>
Java - teren pustynny <br/>
HTML - teren górzysty <br/>
JavaScript - teren zimowy <br/>
PHP - teren zalesiony (styl jesienny) <br/>

### 1.5 Minigry
W tej sekcji dowiesz się więcej na temat zaimplementowanych minigier.

#### 1.5.1 Minigra wieżowiec (quiz)
W tej minigrze postać pojawia się na szczycie "wieżowca", który zbudowany jest z kilku poziomów. Każdy poziom to pytanie i cztery odpowiedzi do wyboru. Wybranie błędnej odpowiedzi nie wpływa na wieżowiec. Gracz znajduje się na danym poziomie do momentu aż nie wybierze prawidłowej odpowiedzi. Po wybraniu poprawnej - poziom wieżowca obniża się i gracz trafia na niższy poziom w którym jest kolejne pytanie i kolejne odpowiedzi. Minigra trwa dopóki gracz nie dojdzie do podstawy wieżowca. Zazwyczaj jest to po 4-5 odbytych poziomach.

#### 1.5.2 Minigra pinpin (podpięcie) 
Minigra pinpin(nazwa projektowa) jest podobna do wieżowca jednak tutaj do wyboru dostajemy fragmenty kodu i musimy wybrać ten który odpowiada terenowi na którym się znajdujemy (przykładowo: jeżeli uruchomiliśmy mini-grę na terenie C# to musimy wybrać kod, który jest zapisany w tym języku). Do wyboru kodu służy nam "pinezka" będąca w formie "pucharu", którą przesuwamy na wybrany kod. Potem jeżeli jesteśmy pewni to stajemy na przycisku służącym do weryfikacji. Prawidłowe umieszczenie pinezki spowoduje przejście do kolejnego etapu natomiast błędnej zmusza do wybrania innej opcji i ponownej weryfikacji. Błędne wybory są podliczane i wpływają na wypłatę za przejście poziomu. 

#### 1.5.3 Minigra puzzle
Minigra w której układamy puzzle z podanego kodu. Celem jest poprawne rozmieszczenie kodu. Aby ułatwić rozgrywkę dla osób początkujących umieszczenie puzzla w odpowiednim miejscu powoduje jego oznaczenie i zablokowanie przed dalszym przesunięciem. W nagrodę uzyskujemy pieniądze i informacje na temat kodu, który był układany.  

#### 1.5.4 Minigra labirynt
Minigra labirynt to gra w której zadaniem gracza jest unikanie "bugów" i zbieranie fragmentów kodu. Zebranie bugów powoduje obniżenie ilości informacji, które otrzymamy po ukończeniu gry i obniża ostateczną kwotę uzyskaną za przejście minigry. Jeżeli chcemy poznać te informację i uzyskać większą wygraną to możemy powtórzyć poziom. Przejście poziomu spowoduje jego oznaczenie jako wykonane i nie będzie go można już powtórzyć (tak jak i innych minigier) aby zapobiec "spamowaniu" uzyskiwaniem pieniędzy. 

### 1.6 Zrzuty ekranu (screeny)
Po zakończeniu projektowania :)

## 2. Sekcja dla devów

### 2.1 Planowane elementy
:white_check_mark: perspektywa rozgrywki z lotu ptaka (top down view) <br/>
:white_check_mark: główny świat podzielony na krainy </br>
:white_check_mark: zróżnicowany styl każdej z przygotowanych krain </br>
:white_check_mark: poruszające się istoty dzięki technologii Unity (navigation meshes) <br/>
:white_check_mark: możliwość interakcji z wybranymi istotami <br/>
:white_check_mark: plecak w którym przechowywane są książki, które można odczytać <br/>
:white_check_mark: kreator postaci <br/>
:white_check_mark: waluta <br/>
:white_check_mark: rozwój postaci poprzez czytanie książek <br/>
:white_check_mark: minigra typu wieżowiec (quiz) <br/>
:white_check_mark: minigra typu labirynt <br/>
:white_check_mark: minigra typu podpięcie <br/>
:white_check_mark: minigra typu puzzle <br/>
:white_check_mark: łączna liczba 40 minigier do rozegrania <br/>
:white_check_mark: podsumowania minigier z dawką programistycznej wiedzy <br/>
:white_check_mark: zróżnicowany level design minigier w zależności od krainy na której są rozgrywane <br/>
:white_check_mark: zróżnicowana oprawa muzyczna w każdej minigrze <br/> 
:white_check_mark: ustawienia najważniejszych aspektów gry <br/>
:white_check_mark: system repetytywności (nie uda się rozegrać wszystkich minigier za jednym podejściem) <br/>
:white_check_mark: system osiągnięć (medale) - JEŻELI STARCZY CZASU <br/>

### 2.2 Klawiszologia 
Uwaga! Klawiszologia może się różnić w zależności od tego w jaką mini-gierkę gramy bądź też czy znajdujemy się na mapie głównej <br/>
W - przód <br/> 
A - lewo <br/>
S - dół <br/>
D - prawo <br/>
B - otwarcie plecaka w którym mamy książki (badz tez nie jak zadnej jeszcze nie kupilismy) <br/>
F - interakcja z NPC (wejście w rozmowe) <br/>
Spacja [przytrzymanie] - złapanie i przesuwanie puzzla/pinezki <br/>
LPM (lewy przycisk myszy) - klikanie w sklepie -> kupowanie książek, otwieranie książek z inventory(plecaka) etc 

### 2.3 Wykorzystane materiały
W pliku Wykorzystane.txt umieszczone są odnośniki do rzeczy, które zostały wykorzystane w projekcie - głównie są to assety, muzyka i grafiki. Będą one uwiecznione w sekcji "Uznania" w grze. 

### 2.4 Wersja Unity
2018.3.12f1 

### 2.5 Wersja .NET Framework:
v 4.7.1 

### 2.6 Klucze 
po zakończeniu projektu

### 2.7 Zawartość podsumowań
po zakończeniu projektu

### 2.8 Realizacja zadań
po zakończeniu projektu

