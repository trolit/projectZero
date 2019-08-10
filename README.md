# Projekt Zero

## 1. O projekcie
Projekt realizowany w ramach pracy inżynierskiej pod kryptonimem "Projekt Zero". Autorem pomysłu na pracę inżynierską jest Paweł Idzikowski. Został on zaakceptowany przez współautora - Adama Grabowskiego oraz w dalszym etapie promotora - dr. Piotra Jastrzębskiego. Projekt Zero to gra wykonana w Unity 3D w perspektywie "top-down view" - czyli widoku z lotu ptaka. Oprócz dawania rozrywki ma ona też na celu pomóc w nauce programowania. Odbiorcami są przede wszystkim osoby rozpoczynające swoją przygodę z programowaniem ale także i te, które chciałyby sobie coś przypomnieć. Języki, które obejmuje gra to: Java, JavaScript, C#, HTML i PHP. Gracz tworzy postać, której przypisuje z podstawowej puli punkty do atrybutów. Atrybutami są języki programowania. <br/> <br/> 

Po wejściu do gry gracz porusza się swoją postacią po świecie, który podzielony jest na krainy. W każdej krainie dominuje odrębny język. Kraina identyfikowana jest rodzajem terenu* (patrz punkt 1.2). W trakcie podziwiania krain gracz napotka postaci z którymi będzie mógł porozmawiać. W trakcie konwersacji dowie się, że dana postać ma problem ze swoim programem i potrzebuje pomocy. Gracz może udzielić jej pomocy jeżeli poziom umiejętności z danego języka przewyższa wymagany próg. Udzielenie pomocy polega na rozegraniu minigry. W Projekt Zero zaimplementowane są 4 minigry - quiz(wieżowiec), pinpin, puzzle, labirynt. Za pomyślne przejście minigry gracz nagradzany jest pieniędzmi i dodatkowymi informacjami. Pieniądze, które zbierze może wydać w sklepie na książki. Przeczytanie książki spowoduje podniesienie umiejętności z tego języka programowania który ksiązka opisuje. <br/> <br/> 

Gra została przygotowana w taki sposób aby przy jednym podejściu nie dało się wykupić wszystkich książek - a więc aby zdobyć maksymalne umiejętności we wszystkich językach. Ma to na celu nie tylko zachęcić do ponownego przejścia gry z innym rozdysponowaniem umiejętności ale też po to aby dać do zrozumienia graczowi, że nie jesteśmy w stanie być specjalistami we wszystkich językach. Możemy znać każdy język ale i tak prędzej czy później będziemy musieli skorzystać z pomocy "wujka Google" aby przypomnieć sobie jak daną rzecz się robiło.        

### 1.1 Języki programowania jako atrybuty postaci
C#, HTML, Java, Javascript, PHP

### 1.2 Rodzaje terenu
C# - teren zalesiony (wiosna) <br/>
Java - teren pustynny <br/>
HTML - teren górzysty <br/>
JavaScript - teren zimowy <br/>
PHP - teren zalesiony (jesień) <br/>

### 1.3 Minigry
W tej sekcji dowiesz się na temat zaimplementowanych minigier.

#### 1.3.1 Minigra quiz (wieżowiec)
W tej minigrze postać pojawia się na szczycie "wieżowca", który zbudowany jest z kilku poziomów. Każdy poziom to pytanie i cztery odpowiedzi do wyboru. Wybranie błędnej odpowiedzi nie wpływa na wieżowiec. Gracz znajduje się na danym poziomie do momentu aż nie wybierze prawidłowej odpowiedzi. Po wybraniu poprawnej - poziom wieżowca obniża się i gracz trafia na niższy poziom w którym jest kolejne pytanie i kolejne odpowiedzi. Minigra trwa dopóki gracz nie dojdzie do podstawy wieżowca. Zazwyczaj jest to po 4-5 odbytych poziomach.

#### 1.3.2 Minigra pinpin 
Minigra pinpin jest podobna do quizu jednak tutaj do wyboru dostajemy fragmenty kodu i musimy wybrać ten który odpowiada terenowi na którym się znajdujemy (przykładowo: jeżeli uruchomiliśmy mini-grę na terenie C# to musimy wybrać kod, który jest zapisany w tym języku). Do wyboru kodu służy nam "pinezka" będąca w formie "pucharu", którą przesuwamy na wybrany kod. Potem jeżeli jesteśmy pewni to stajemy na przycisku służącym do weryfikacji. Prawidłowe umieszczenie pinezki spowoduje przejście do kolejnego etapu natomiast błędnej zmusza do wybrania innej opcji i ponownej weryfikacji. Błędne wybory są podliczane i wpływają na wypłatę za przejście poziomu. 

#### 1.3.3 Minigra puzzle
Minigra w której układamy puzzle z podanego kodu. Celem jest poprawne rozmieszczenie kodu. Aby ułatwić rozgrywkę dla osób początkujących umieszczenie puzzla w odpowiednim miejscu powoduje jego oznaczenie i zablokowanie przed dalszym przesunięciem. W nagrodę uzyskujemy pieniądze i informacje na temat kodu, który był układany.  

#### 1.3.4 Minigra labirynt
Minigra labirynt to gra w której zadaniem gracza jest unikanie "bugów" i zbieranie fragmentów kodu. Zebranie bugów powoduje obniżenie ilości informacji, które otrzymamy po ukończeniu gry i obniża ostateczną kwotę uzyskaną za przejście minigry. Jeżeli chcemy poznać te informację i uzyskać większą wygraną to możemy powtórzyć poziom. Przejście poziomu spowoduje jego oznaczenie jako wykonane i nie będzie go można już powtórzyć (tak jak i innych minigier) aby zapobiec "spamowaniu" uzyskiwaniem pieniędzy. 

## 2. Sekcja dla devów

### 2.1 Planowane elementy
- główny świat po którym można się poruszać i wchodzić w interakcję z niektórymi "NPC'ami" - oferować oni będą minigry w które możemy zagrać <br/> 
- NPC się poruszają (https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html) <br/>
- motyw z plecakiem w którym przechowujemy rzeczy (w naszym przypadku książki) <br/>
- zdobywanie waluty (pieniędzy) <br/>
- możliwość wydania waluty w sklepie na książki które podnoszą umiejętności <br/>
- kreator postaci (możliwość przydzielenia atrybutów) </br>
- niektóre zadania wymagać będą od postaci jakiegoś poziomu umiejętności z danego języka programowania </br>
- mini-gra na zasadzie quizu <br/>
- mini-gra na zasadzie labiryntu w którym są bugi na które nie wolno wejść i trzeba przejść do wyjścia :) </br>
- mini-gra na zasadzie podpięcia do danego fragmentu kodu odpowiedniego języka programowania <br/>
- mini-gra na zasadzie układania puzzli z kodu, w perspektywie "z góry" - coś w stylu jak poniżej <br/>
![zdjecie zostalo usuniete](https://i.pinimg.com/originals/fe/a5/c0/fea5c00c531619211f9232d1f6d702af.jpg)

### 2.2 Klawiszologia 
W - przód <br/>
A - lewo <br/>
S - dół <br/>
D - prawo <br/>
B - otwarcie plecaka w którym mamy książki (badz tez nie jak zadnej jeszcze nie kupilismy) <br/>
F - interakcja z NPC (wejście w rozmowe) <br/>
Spacja [przytrzymanie] - złapanie i przesuwanie puzzla/pinezki <br/>
LPM (lewy przycisk myszy) - klikanie w sklepie -> kupowanie książek, otwieranie książek z inventory etc 

### 2.3 Wykorzystane rzeczy
W pliku wykorzystane.txt będziemy umieszczać linki i nazwy rzeczy które bierzemy do projektu aby potem je w zakładce Credits uwzględnić

### 2.4 Wersja Unity:
2018.3.12f1 

### 2.5 Wersja .NET Framework:
v 4.7.1 
