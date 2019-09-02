# Projekt Zero

## 1. O projekcie
Projekt realizowany w ramach pracy inżynierskiej pod kryptonimem "Projekt Zero". Autorem pomysłu na pracę inżynierską jest Paweł Idzikowski. Został on zaakceptowany przez współautora - Adama Grabowskiego oraz w dalszym etapie promotora - dr. Piotra Jastrzębskiego. Projekt Zero to gra wykonana w Unity 3D w perspektywie "top-down view" - czyli widoku z lotu ptaka. Oprócz dawania rozrywki ma ona też na celu pomóc w nauce programowania. Odbiorcami są przede wszystkim osoby rozpoczynające swoją przygodę z programowaniem ale także i te, które chciałyby sobie coś przypomnieć. Języki, które obejmuje gra to: Java, JavaScript, C#, HTML i PHP. Gracz tworzy postać, której przypisuje z podstawowej puli punkty do atrybutów. Atrybutami są języki programowania. <br/> <br/> 

Po wejściu do gry gracz porusza się swoją postacią po świecie, który podzielony jest na krainy. W każdej krainie dominuje odrębny język. Kraina identyfikowana jest rodzajem terenu* (patrz punkt 1.2). W trakcie podziwiania krain gracz napotka istoty z którymi będzie mógł porozmawiać. W trakcie konwersacji dowie się, że dana postać ma problem ze swoim programem i potrzebuje pomocy. Gracz może udzielić jej pomocy jeżeli poziom umiejętności z danego języka przewyższa wymagany próg bądź jest na równi. Udzielenie pomocy polega na rozegraniu minigry. W Projekt Zero zaimplementowane są 4 minigry - quiz(wieżowiec), pinpin, puzzle, labirynt. Za pomyślne przejście minigry gracz nagradzany jest pieniędzmi i dodatkowymi informacjami w podsumowaniach. Pieniądze, które zbierze może wydać w sklepie na książki. Przeczytanie książki spowoduje podniesienie umiejętności z tego języka programowania który ksiązka opisuje. <br/> <br/> 

Gra została przygotowana w taki sposób aby przy jednym podejściu nie dało się wykupić wszystkich książek - a więc aby zdobyć maksymalne umiejętności we wszystkich językach. Ma to na celu nie tylko zachęcić do ponownego przejścia gry z innym rozdysponowaniem umiejętności ale też po to aby dać do zrozumienia graczowi, że nie jesteśmy w stanie być specjalistami we wszystkich językach. Możemy znać każdy język ale i tak prędzej czy później będziemy musieli skorzystać z pomocy "wujka Google" aby przypomnieć sobie jak daną rzecz się robiło w danym języku programowania.

Dlaczego nazwa projektu brzmi Projekt Zero (ang. Project Zero)? Można to interpretować na wiele sposobów. Dla przykładu: zero bo gra oferuje treści dla osób, które zaczynają programowanie i chciałyby zdobyć jakiś pogląd na temat języków wymienionych w punkcie 1.1. Inna interpretacja: jest to większe przedsiewzięcie autorów w środowisku Unity3D. Można też tytułowe "zero" potraktować jako projekt wyjściowy w ramach pracy inżynierskiej.  

### 1.1 Od autora (Paweł Idzikowski)
Projekt Zero będzie dla mnie drugą grą, którą wykonałem w środowisku Unity 3D a podsumowując z 2D - trzecią. Chciałem aby pracą inżynierską był produkt, który nie służy tylko do zapewnienia rozrywki ale też do poznania czy przypomnienia języków z którymi ma się w obecnych czasach styczność. Ci, którzy przeszli technikum informatyczne na pewno mieli styczność z HTML, Javascript, PHP i C++ (przynajmniej ja tak miałem począwszy od roku 2012 kiedy poszedłem do technikum). Wiadome jest, że dałoby się tak stworzyć grę aby omawiała wszystkie elementy tych języków jednak postawmy sobie pytanie - Czy taka gra nie stałaby się nudna po X jednostek czasu? Moim zdaniem tak, tak i jeszcze raz - tak. Nasz projekt nie omawia wszystkich rzeczy a "sprzedaje" jedne z ważniejszych informacji w sposób przyzwoity dla osób, które chciałyby jakoś zacząć przygodę z tymi językami ale nie wiedzą od czego zacząć. Chciałem aby sposób w jaki wiedza jest przekazywana zachęcała graczy do sprawdzenia większej liczby informacji na własną rękę, poza grą. Oprócz tworzenia czegoś co miałoby być użyteczne zależało mi też na tym aby był to projekt, którym warto się pochwalić i zapisać w swoim CV jako udana praca :) 

### 1.2 Języki programowania jako atrybuty postaci
C#, HTML, Java, Javascript, PHP

### 1.3 Rodzaje krain i ich tereny
C# - teren zalesiony (styl wiosenny) <br/>
Java - teren pustynny <br/>
HTML - teren górzysty <br/>
JavaScript - teren zimowy <br/>
PHP - teren zalesiony (styl jesienny) <br/>

### 1.4 Minigry
W tej sekcji dowiesz się więcej na temat zaimplementowanych minigier.

#### 1.4.1 Minigra quiz (wieżowiec)
W tej minigrze postać pojawia się na szczycie "wieżowca", który zbudowany jest z kilku poziomów. Każdy poziom to pytanie i cztery odpowiedzi do wyboru. Wybranie błędnej odpowiedzi nie wpływa na wieżowiec. Gracz znajduje się na danym poziomie do momentu aż nie wybierze prawidłowej odpowiedzi. Po wybraniu poprawnej - poziom wieżowca obniża się i gracz trafia na niższy poziom w którym jest kolejne pytanie i kolejne odpowiedzi. Minigra trwa dopóki gracz nie dojdzie do podstawy wieżowca. Zazwyczaj jest to po 4-5 odbytych poziomach.

#### 1.4.2 Minigra podpięcie (pinpin) 
Minigra pinpin(nazwa projektowa) jest podobna do quizu jednak tutaj do wyboru dostajemy fragmenty kodu i musimy wybrać ten który odpowiada terenowi na którym się znajdujemy (przykładowo: jeżeli uruchomiliśmy mini-grę na terenie C# to musimy wybrać kod, który jest zapisany w tym języku). Do wyboru kodu służy nam "pinezka" będąca w formie "pucharu", którą przesuwamy na wybrany kod. Potem jeżeli jesteśmy pewni to stajemy na przycisku służącym do weryfikacji. Prawidłowe umieszczenie pinezki spowoduje przejście do kolejnego etapu natomiast błędnej zmusza do wybrania innej opcji i ponownej weryfikacji. Błędne wybory są podliczane i wpływają na wypłatę za przejście poziomu. 

#### 1.4.3 Minigra puzzle
Minigra w której układamy puzzle z podanego kodu. Celem jest poprawne rozmieszczenie kodu. Aby ułatwić rozgrywkę dla osób początkujących umieszczenie puzzla w odpowiednim miejscu powoduje jego oznaczenie i zablokowanie przed dalszym przesunięciem. W nagrodę uzyskujemy pieniądze i informacje na temat kodu, który był układany.  

#### 1.4.4 Minigra labirynt
Minigra labirynt to gra w której zadaniem gracza jest unikanie "bugów" i zbieranie fragmentów kodu. Zebranie bugów powoduje obniżenie ilości informacji, które otrzymamy po ukończeniu gry i obniża ostateczną kwotę uzyskaną za przejście minigry. Jeżeli chcemy poznać te informację i uzyskać większą wygraną to możemy powtórzyć poziom. Przejście poziomu spowoduje jego oznaczenie jako wykonane i nie będzie go można już powtórzyć (tak jak i innych minigier) aby zapobiec "spamowaniu" uzyskiwaniem pieniędzy. 

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

### 2.3 Wykorzystane rzeczy
W pliku Wykorzystane.txt umieszczone są odnośniki do rzeczy, które zostały wykorzystane w projekcie. Dodatkowo będą one uwiecznione w sekcji "Uznania" w grze. 

### 2.4 Wersja Unity:
2018.3.12f1 

### 2.5 Wersja .NET Framework:
v 4.7.1 
