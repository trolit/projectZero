using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    // This file stores all texts that can be shown 
    // during minigame loading phase

    public class TextStorage : MonoBehaviour
    {
        public static List<string> Texts { get; set; }

        private void Awake()
        {
            Texts = new List<string>();

            if (LevelLoader.CrossSceneInformation.Contains("C#"))
            {
                Texts = AddCsharpDataToTexts();
                Debug.Log($"Successfully added C# data ({Texts.Count}) to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("Java"))
            {
                Texts = AddJavaDataToTexts();
                Debug.Log($"Successfully added Java data ({Texts.Count}) to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("JS"))
            {
                Texts = AddJSDataToTexts();
                Debug.Log($"Successfully added JavaScript data ({Texts.Count}) to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("PHP"))
            {
                Texts = AddPhpDataToTexts();
                Debug.Log($"Successfully added PHP data ({Texts.Count}) to Texts");
            }
            else if (LevelLoader.CrossSceneInformation.Contains("HTML"))
            {
                Texts = AddHtmlDataToTexts();
                Debug.Log($"Successfully added HTML data ({Texts.Count}) to Texts");
            }
            else
            {
                Debug.LogWarning("Nothing was added to Texts!");
            }
        }

        List<string> AddCsharpDataToTexts()
        {
           return new List<string>
           {
               "Microsoft pierwszy raz wspomniał nazwę C# w 1988 roku",
               "Składnia języka C# jest podobna do języków z rodziny C jak Java, C, C++",
               "C# jest dobrym językiem do projektowania gier. Wykorzystać go można w popularnym środowisku Unity.",
               "Starszy brat C#, język C++ jest używany w silniku Unreal Engine.",
               "Project Zero jest grą napisaną w języku C#, w środowisku Unity (rok 2019).",
               "Przeciążanie metod polega na tym, że tworzymy taką samą metodę tylko z inną liczbą parametrów. \n np. void policz(int a), void policz(int a, int b)",
               "Jednym z najnowszych frameworków, które Microsoft rozwija to Blazor, który pozwala na budowanie stron przy pomocy C#!",
               "Język C# należy do platformy .NET",
               "C# jest językiem obiektowym.",
               "L w SOLID oznacza zasadę podstawienia Liskov. W skrócie oznacza to tyle, żeby nie tworzyć klas, których funkcje możemy wywołać w obiektach, które nie powinny mieć tych funkcji, bo jest to nielogiczne np. płytaCD i obliczLiczbeStron().",
               "I w SOLID oznacza zasadę segregacji interfejsów. Lepiej więcej mniejszych, niż jeden ogólny.",
               "D w SOLID oznacza zasadę odwrócenia zależności. Wysokopoziomowe moduły nie powinny zależeć od niskopoziomowych.",
               "Moduły wysokiego poziomu decydują o funkcjonowaniu aplikacji (jest to najczęściej warstwa, z którą użytkownik ma do czynienia).",
               "Moduły niskiego poziomu to cała infrastruktura, która umożliwia działanie warstwy wysokopoziomowej.",
               "Moduł to inaczej klasa.",
               "Interfejs w aplikacjach biznesowych stosuje się w tzw. Dependency Injection (wstrzykiwaniu zależności), aby mieć schludny kod.",
               "Słówko kluczowe static przypinamy do klasy/zmiennej/metody, jeżeli chcemy móc odwoływać się do tej rzeczy bez konieczności tworzenia obiektu.",
               "Metody można przesłaniać. Warunkiem jest oznaczenie metody bazowej jako virtual a metody, która ją przesłania - override.",
               "Lista nie wymaga rozmiaru podczas deklaracji, natomiast tablica tak.",
               "Przykładowa deklaracja listy: List<T> nazwa = new List<T>(); gdzie T to typ listy",
               "Przykładowa deklaracja tablicy (bez inicjalizacji): T[] nazwa = new T[rozmiarTablicy]; gdzie T to typ tablicy",
               "Klasa to typ ogólny, który określa cechy, a nie ich wartości. Mówiąc prosto - klasa jest przepisem na tworzenie obiektów.",
               "Obiekt to instancja klasy, konkretny byt z rzeczywistości np. BMW to obiekt klasy Samochód",
               "W języku C#, klasa może dziedziczyć po maksymalnie jednej klasie, natomiast może implementować wiele interfejsów.",
               "Przewagą języka C# jest potężne środowisko programistyczne - Visual Studio, tzw. IDE",
               "MVC to wzorzec projektowy, mający na celu ułatwienie zarządzania aplikacją biznesową.",
               "Wzorzec projektowy to sprawdzony sposób/przepis na schemat projektowania aplkacji np. MVVM, Repozytorium.",
               "Modyfikator dostępu to ustawienie, w jakim zakresie element bądź typ jest dostępny. Wyróżniamy 4: public, protected, internal, private.",
               "słówko sealed stosujemy do klasy, którą chcemy zabezpieczyć przed nieumyślnym dziedziczeniu. Wtedy jest to tzw. klasa finalna.",
               "Klasą abstrakcyjną nazywamy klasę, która stanowi koncept do budowania dalszych klas.",
               "Public to modyfikator dostępu, który przetłumaczymy: dostępny wszędzie i zawsze.",
               "Protected to modyfikator dostępu, który przetłumaczymy: tylko w bazowej i tych, które dziedziczą po bazowej.",
               "Private to modyfikator dostępu, który przetłumaczymy: tylko w tej klasie w której powstał element.",
               "Internal to modyfikator dostępu, który przetłumaczymy: tylko w obrębie namespace'a (przestrzeni nazw).",
               "Jeżeli stworzymy pole lub metodę i nie nadamy modyfikatora dostępu, to domyślnie będzie opatrzone modyfikatorem typu private.",
               "4 wyróżniki/filary obiektowości to: abstrakcja, hermetyzacja, dziedziczenie, polimorfizm.",
               "Klasy abstrakcyjne nie pozwalają na tworzenie obiektów.",
               "W interfejsie nie możemy zaimplementować metody, jedynie 'zadeklarować'.",
               "Konstruktor nazywa się tak samo jak klasa.",
               "Operator new ma za zadanie zainicjować obiekt (rezerwuje pamięć na stercie).",
               "Przestrzeń nazw (namespace) to zbiór klas, które na ogół mają jakiś wspólny cel do działania.",
               "Metody statyczne nie mają dostępu do pól niestatycznych!",
               "Garbage Collector niszczy obiekt i zwalnia pamięć po nich.",
               "Symbolem destruktora jest tylda czyli ~.",
               "Dziedziczenie, pozwala na rozszerzenie klas o nowe cechy bez powielania kodu.",
               "Klasa dziedziczona to klasa bazowa, a klasa dziedzicząca to klasa potomna.",
               "Klasa abstrakcyjna może zawierać stałe.",
               "Klasa abstrakcyjną tworzymy modyfikatorem abstract.",
               "Klasa abstrakcyjna może zawierać implementacje metod.",
               "W interfejsie nie wstawiamy pól.",
               "Interfejsy implementujemy, a klasy dziedziczymy.",
               "Interfejs może dziedziczyć po innym interfejsie.",
               "Klasa może implementować wiele interfejsów.",
               "Konstruktor to specjalna funkcja, która tworzy obiekty.",
               "Konstruktor można przeciążać. np. mając klasę Abc, mamy: Abc() { } i Abc(int a) { } itd.",
               "Gdy zdefiniujemy konstrukor to konstruktor domyślny nie jest automatycznie tworzony.",
               "W języku C# operatorem dziedziczenia, jak i implementacji interfejsów jest dwukropek.",
               "Inną nazwą dla funkcji jest podprogram albo procedura."
           };
        }

        List<string> AddJavaDataToTexts()
        {
            return new List<string>
            {
                "Początkową nazwą tego języka było Oak/dąb/. Nazwę wymyślił James Gosling na cześć wielkiego dębu, który widział z okna swojego biura w Sun Microsystems.",
                "Nazwa Oak musiała być zmieniona na Java, z racji że istniała już firma, która miała w swojej nazwie ten wyraz ",
                "Pomysł na nazwę Java wziął się z zamiłowania do jednego z gatunków kawy",
                "Język Java powstał przez przypadek.",
                "Java wywodzi się głównie z C++ oraz SmallTalk.",
                "Język ten został zaprojektowany i zaimplementowany w laboratoriach Sun Microsystems w Kalifornii pod kierownictwem Jamesa Goslinga",
                "Warto w czasach obecnych poznać jakieś frameworki. Dla języka Java np. Spring",
                "Eclipse to platforma, w której można tworzyć aplikacje w  m.in. języku Java.",
                "W języku Java, aby zastosować dziedziczenie używa się słówka: extends",
                "W języku Java, aby zaimplementować interfejs używa się słówka: implements",
                "W języku Java przy deklaracji zmiennej, trzeba podać typ tej zmiennej w sposób jawny.",
                "Słówko kluczowe final w przypadku klasy => nie można dziedziczyć po takiej klasie.",
                "Słówko kluczowe final w przypadku metody => metoda nie może być nadpisana.",
                "Słówko kluczowe final w przypadku pola => pole jest stałą.",
                "Słówko kluczowe final w przypadku zmiennej => wartość zmienniej nie może zostać zmieniona, kiedy zostanie coś do niej przypisane.",
                "Tablica to obiekt, który pozwala przechować kolekcję elementów w jednym miejscu.",
                "Słowo kluczowe, oznacza słowo, mające szczególne znaczenie w języku programowania.",
                "Java w 2018 roku w rankingu Tiobe Index zajmuje 1 miejsce pod względem popularności.",
                "Język Java ma swoją maskotkę i jest nią Duke.",
                "SOLID to założenia programowania obiektowego zaproponowane przez Roberta C. Martina.",
                "S w SOLID, oznacza zasadę jednej odpowiedzialności klas. Klasa powinna mieć tylko jedną odpowiedzialność np. WygenerujPDF",
                "O w SOLID, oznacza zasadę otwarte na rozbudowe / zamknięte na modyfikację.",
                "Definicja funkcji to jej konstrukcja (ciało funkcji), co robi.",
                "Deklaracja funkcji to poinformowanie kompilatora, żeby zarezerwował pamięć, bo będzie taka funkcja. Funkcje deklarujemy na przykład w interfejsie.",
                "break to instrukcja, która pozwala na wyjście z pętli. Oddziela także przypadki (ang. case) w instrukcji switch.",
                "continue to instrukcja, która w pętli pozwala pominąć dalszą część kodu pętli i przejście do kolejnej iteracji.",
                "Instrukcja switch to alternatywa na instrukcje warunkowe if. Nożna w niej utworzyć 'bloki' case. Każdy z bloków kończy się instrukcją break.",
                "Używanie instrukcji continue i break jest dobrą prakyką, bo zwiększa wydajność kodu. Jeżeli funkcja z pętlą osiągnęła swój cel w 5 iteracji ze 100, to nie ma potrzeby przechodzić pozostałych 95.",
                "W instrukcji switch, słówko kluczowe default oznacza blok, który się wykona jeżeli nie zostanie znalezione dopasowanie (coś jak else).",
                "Jeżeli chcesz przetestować kod to można skorzystać z tzw. try and catch. W try umieszczamy kod do przetestowania, a w catch kod, który ma zostać wykonany w przypadku wyłapania błędu w bloku try.",
                "Blok try..catch.. może zostać rozszerzony o blok nieobowiązkowy - finally. W tym bloku można umieścić kod, który wykona się niezależnie od wyniku try..catch..",
                "W wyjątkach (ang. exception) najkosztowniejszym elementem jest utworzenie(wyrzucenie) wyjątku. Jeżeli nie wyrzucasz setek/tysięcy wyjątków, to nie zauważysz dużej różnicy pod względem czasu operacji.",
                "Metoda to blok kodu, który jest wykonywany w momencie wywołania. Do metod można przekazywać dane, które nazywamy parametrami.",
                "Metoda musi być zadeklarowana i zdefiniowana w klasie.",
                "Oznaczając metodę słówkiem static mówimy, że należy ona do klasy, a nie do obiektu.",
                "void to słowo kluczowe, które informuje, że funkcja nie zwraca żadnej wartości.",
                "Parametry funkcji wewnątrz jej definicji traktujemy jako zmienne. Dla funkcji wyszukajProdukt(String nazwa), nazwa jest parametrem.",
            };
        }

        List<string> AddJSDataToTexts()
        {
            return new List<string>
            {
                "Język JavaScript zaraz obok HTML i CSS stanowi podstawę stron WWW",
                "JavaScript a Java różnią się znacząco - nie należy ich ze sobą utożsamiać.",
                "W tym języku oprócz weryfikacji równości wartości (==), mamy również dodatkową weryfikację zgodności typów (===).",
                "JavaScript nie ma typu integer (wszystkie liczby są typu float).",
                "Język JavaScript był rozwijany pod kodową nazwą: Mocha. Napisany został w ciągu 10 dni.",
                "W języku JavaScript nie podaje się typów parametrów funkcji.",
                "Język JavaScript ma prawie 20 lat (pojawił się w 1995).",
                "Język JavaScript jest językiem nietypowanym, co po angielsku zwie się - duck typing.",
                "JavaScript nie jest kompilowany, tylko interpretowany przez stronę.",
                "W języku JavaScript null jest obiektem.",
                "W języku JavaScript NaN (skrót od Not a Number) jest liczbą.",
                "Funkcje są przechowywane jako zmienne w języku JavaScript.",
                "JavaScript zaraz obok HTML i CSS to języki, które muszą znać wszyscy developerzy stron.",
                "Twórcą języka JavaScript jest Brendan Eich.",
                "Oficjalną nazwą języka JavaScript jest EMCAScript",
                "Funkcja String.length zwraca długość napisu.",
                "Funkcja String.indexOf(arg) zwraca indeks/pozycje pierwszego znaku tekstu znalezionego w napisie.",
                "Indeks w języku JavaScript jest liczony od 0.",
                "Funkcje String.search i String.indexOf(arg) nie są takie same.",
                "Funkcja String.replace(arg1, arg2), pozwala na zamianę podanej wartości arg1 na wartość arg2 w napisie.",
                "Funkcja String.toUpperCase() formatuje napis do dużych liter.",
                "Funkcja String.trim() pozwala pozbyć się w napisie biały znaków (spacji).",
                "Math.Pi pozwala uzyskać liczbę PI.",
                "Obiekt Math w JavaScript, pozwala na wykonywanie operacji matematycznych.",
                "Math.round(arg) pozwala uzyskać zaokrągloną liczbę całkowitą.",
                "Math.pow(arg1, arg2) pozwala podnieść liczbe arg1 do potęgi arg2.",
                "Math.floor(Math.random() * 100) + 1 zwróci losową liczbę całkowitą z przedziału od 1 do 100",
                "Zapis x += 1 to skrócenie operacji typu x = x + 1.",
                "Dobrą praktyką jest inicjalizacja zmiennych przy ich deklaracji np tablica: myArray = [], obiekt: myObject = {}.",
                "Dobrą praktyką jest dodawanie bloku default do konstrukcji switch."
            };
        }

        List<string> AddPhpDataToTexts()
        {
            return new List<string>
            {
                "Maskotką PHP jest wielki niebieski słoń. Dlaczego? Bo elePHPant (od ang. elephant)",
                "PHP to skrót od: Personal Home Page",
                "Z PHP korzysta ponad 244 milionów stron(>81%), stąd na ten język jest nadal duże zapotrzebowanie.",
                "W języku PHP możemy programować obiektowo, proceduralnie albo mieszając te dwa sposoby.",
                "Popularne projekty PHP: Symfony, Laravel, CodeIgniter, Faker",
                "Język PHP został opublikowany w roku 1995. Wstępnie był napisany w języku C.",
                "Facebook, Yahoo!, Flickr, Wikipedia korzystają z języka PHP.",
                "Jeżeli chcesz stworzyć tablice to skorzystaj ze składni języka array().",
                "Jednym z najcześćiej używanych środowisk do języka PHP jest Netbeans.",
                "Język PHP jest interpretowanym, skryptowym, językiem programowania.",
                "Funkcja, to blok kodu utworzony, aby wykonać określone zadanie.",
                "Stałą, w języku PHP, zdefiniować można za pomocą define.",
                "Pętla do..while różni się od pętli while, ponieważ wykona się przynajmniej jeden raz.",
                "Formularze np. kontaktowe, ankiety mogą być obsługiwane przez PHP - wiele stron jeszcze z nich korzysta.",
                "Dolara używa się w PHP do zmiennych, aby odróżnić je od stałych.",
                "PHP nie był tworzony początkowo po to, by być językiem programowania. Rasmus Lerdorf stworzył go, aby móc zarządzać swoją stroną internetową.",
                "Z początku PHP był znany jako PHP/FI, czyli Personal Home Page/Forms Interpreter.",
                "Początkowym Celem języka PHP była budowa prostych, dynamicznych aplikacji webowych i komunikacja z bazami danych.",
                "Najnowsza wersja PHP jest okraszona numerkiem 7 (PHP7).",
                "Skrypty PHP z reguły umieszcza się w plikach HTML.",
                "Cały kod języka PHP musi zawierać się między znacznikami <?php ?> (najbardziej zalecany sposób).",
                "Komentarz jednoliniowy można zapisać za pomocą // lub #.",
                "PHP obsługuje większość baz danych: MySQL, PostgreSQL, Oracle, MS SQL, DB2."
            };
        }

        List<string> AddHtmlDataToTexts()
        {
            return new List<string>
            {
                "W języku HTML powinniśmy zachowywać strukturę pliku.",
                "Im więcej znaczników zrobisz tym lepiej. Łatwiej jest wtedy stylować stronę (projektować interfejs) i ją ofunkcjonować.",
                "W języku HTML możemy zagnieżdżać skrypty JavaScript między znacznikami <script></script>.",
                "Język HTML jest językiem do tworzenia stron.",
                "Język HTML jest językiem znacznikowym.",
                "Jeżeli stosujemy znacznik <img src> powinniśmy dodać atrybut alt z tekstem, w razie gdyby zdjęcie nie zostało wczytane/już nie istniało.",
                "Najnowsza wersja języka HTML nosi numerek 5. (stan na rok 2019)",
                "Aby stworzyć tabelę, należy skorzystać ze znaczników m.in: table, tr, th, td",
                "W znaczniku <head> umieszczamy referencje do bibliotek, z których korzystamy.",
                "Według standardów każdy plik typu .html, powinien zaczynać się od linijki jakiego typu jest to strona HTML np. <!doctype html>",
                "Znaczniki i atrybuty w języku HTML, powinny być pisane z małych liter np. <section> a nie <SECTION>.",
                "HTML to skrót od ang. HyperText Markup Language",
                "Wszystkie elementy języka HTML mogą mieć atrybuty np. href.",
                "Atrybuty w języku HTML zawsze podaje się w znaczniku rozpoczynającym.",
                "Aby móc zdefiniować te same style dla kilku elementów strony, można skorzystać z atrybutu klasy (class).",
                "JavaScript sprawia, że strony HTML są bardziej dynamiczne i interaktywne.",
                "HTML został opublikowany po raz pierwszy w 1993 roku.",
                "Bootstrap jest frameworkiem, który rozszerza i ułatwia pracę z HTML i CSS.",
                "W HTML po dołączeniu biblioteki Font Awesome, możemy wrzucać fajne ikony. W czasach obecnych ikonki są bardzo popularne.",
                "Dodawanie, do znacznika audio czy wideo, atrybutu autoplay (automatyczne odtwarzanie) jest złą praktyką.",
                "HTML5 jest przyjazne dla urządzeń mobilnych.",
                "W języku HTML5, w znaczniku script nie trzeba specyfikować/wyszczególniać atrybutu type, bo JavaScript jest domyślnym językiem skryptowym w HTML."
            };
        }
    }
}
