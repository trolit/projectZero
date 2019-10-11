using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Game
{
    // This file stores all texts that can be shown 
    // during minigame loading phase

    public class TextStorage : MonoBehaviour
    {
        public static List<string> Texts { get; set; }

        void Awake()
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
               "Project Zero jest grą napisaną w języku C# w środowisku Unity (rok 2019).",
               "Przeciążanie metod polega na tym, że tworzymy taką samą metodę tylko z inną liczbą parametrów. \n np. void policz(int a), void policz(int a, int b)",
               "Jednym z najnowszych frameworków, które Microsoft rozwija to Blazor, który pozwala na budowanie stron przy pomocy C#!",
               "Język C# należy do platformy .NET",
               "C# jest językiem obiektowym.",
               "SOLID to zaproponowane przez Roberta C. Martina założenia programowania obiektowego.",
               "S w SOLID oznacza zasadę jednej odpowiedzialności klas. Klasa powinna mieć tylko jedną odpowiedzialność np. WygenerujPDF",
               "O w SOLID oznacza zasadę otwarte na rozbudowe / zamknięte na modyfikację.",
               "L w SOLID oznacza zasadę podstawienia Liskov. W skrócie oznacza to tyle żeby nie tworzyć klas, których funkcje możemy wywołać w obiektach, które nie powinny mieć tych funkcji bo jest to nielogiczne np. płytaCD i obliczLiczbeStron()",
               "I w SOLID oznacza zasadę segregacji interfejsów. Lepiej więcej mniejszych niż jeden ogólny.",
               "D w SOLID oznacza zasadę odwrócenia zależności. Wysokopoziomowe moduły nie powinny zależeć od niskopoziomowych.",
               "Moduły wysokiego poziomu decydują o funkcjonowaniu aplikacji (jest to najczęściej warstwa z, którą użytkownik ma do czynienia).",
               "Moduły niskiego poziomu to cała infrastruktura, która umożliwia działanie warstwy wysokopoziomowej.",
               "Moduł to inaczej klasa.",
               "Interfejs w aplikacjach biznesowych stosuje się w tzw. Dependency Injection (wstrzykiwaniu zależności) aby mieć schludny kod.",
               "Słówko kluczowe static przypinamy do klasy/zmiennej/metody jeżeli chcemy móc odwoływać się do tej rzeczy bez konieczności tworzenia obiektu.",
               "Metody można przesłaniać. Warunkiem jest oznaczenie metody bazowej jako virtual a metody, która ją przesłania - override.",
               "Lista nie wymaga rozmiaru podczas deklaracji natomiast tablica tak.",
               "Przykładowa deklaracja listy: List<T> nazwa = new List<T>(); gdzie T to typ listy",
               "Przykładowa deklaracja tablicy (bez inicjalizacji): T[] nazwa = new T[rozmiarTablicy]; gdzie T to typ tablicy",
               "Klasa to typ ogólny, który określa cechy a nie ich wartości. Mówiąc prosto - klasa jest przepisem na tworzenie obiektów.",
               "W języku C# klasa może dziedziczyć po maksymalnie jednej klasie, natomiast może implementować wiele interfejsów.",
               "Przewagą języka C# jest potężne środowisko programistyczne - Visual Studio, tzw. IDE",
               "MVC to wzorzec projektowy mający na celu ułatwienie zarządzania aplikacją biznesową.",
               "Wzorzec projektowy to sposób/przepis na schemat projeku aplkacji np. MVVM, Repozytorium.",
               "Modyfikator dostępu to ustawienie w jakim zakresie element bądź typ jest dostępny. Wyróżniamy 4: public, protected, internal, private.",
               "słówko sealed stosujemy do klasy, którą chcemy zabezpieczyć przed nieumyślnym dziedziczeniu.",
               "Klasą abstrakcyjną nazywamy klasę, która stanowi koncept do budowania dalszych klas.",
               "Public to modyfikator dostępu, który przetłumaczymy: dostępny wszędzie i zawsze.",
               "Protected to modyfikator dostępu, który przetłumaczymy: tylko w bazowej i tych, które dziedziczą po bazowej.",
               "Private to modyfikator dostępu, który przetłumaczymy: tylko w tej klasie w której powstał element.",
               "Package to modyfikator dostępu, który przetłumaczymy: tylko w obrębie namespace'a (przestrzeni nazw)."
           };
        }

        List<string> AddJavaDataToTexts()
        {
            return new List<string>
            {
                "Początkową nazwą tego języka było Oak/dąb/. Nazwę wymyślił James Gosling na cześć wielkiego dębu, który widział z okna swojego biura w Sun Microsystems.",
                "Nazwa Oak musiała być zmieniona z racji, że istniała już firma, która miała w swojej nazwie ten wyraz na Java. ",
                "Pomysł na nazwę Java wziął się z zamiłowania do jednego z gatunków kawy",
                "Język Java powstał przez przypadek.",
                "Java wywodzi się głównie z C++ oraz SmallTalk.",
                "Język ten został zaprojektowany i zaimplementowany w laboratoriach Sun Microsystems w Kalifornii pod kierownictwem Jamesa Goslinga",
                "Warto w czasach obecnych poznać jakieś frameworki. Dla języka Java np. Spring",
                "Eclipse to platforma w której można tworzyć aplikacje w  m.in. języku Java.",
                "W języku Java aby zastosować dziedziczenie między klasami używa się słówka: extends",
                "W języku Java aby zaimplementować interfejs używa się słówka: implements",
                "W języku Java przy deklaracji zmiennej trzeba podać typ tej zmiennej w sposób jawny.",
                "Słówko kluczowe final w przypadku klasy => nie można dziedziczyć po takiej klasie.",
                "Słówko kluczowe final w przypadku metody => metoda nie może być nadpisana.",
                "Słówko kluczowe final w przypadku pola => pole jest stałą.",
                "Słówko kluczowe final w przypadku zmiennej => wartość zmienniej nie może zostać zmieniona kiedy zostanie coś do niej przypisane.",
                "Tablica to obiekt, który pozwala przechować kolekcję elementów w jednym miejscu."
            };
        }

        List<string> AddJSDataToTexts()
        {
            return new List<string>
            {
                "Język JavaScript zaraz obok HTML i CSS stanowi podstawę stron WWW",
                "JavaScript a Java różnią się znacząco - nie należy ich ze sobą utożsamiać.",
                "W tym języku oprócz weryfikacji równości wartości (==) mamy również dodatkową weryfikację zgodności typów (===).",
                "JavaScript nie ma typu integer (wszystkie liczby są typu float).",
                "Język JavaScript był rozwijany pod kodową nazwą: Mocha. Napisany został w ciągu 10 dni.",
                "W języku JavaScript nie podaje się typów parametrów funkcji.",
                "Język JavaScript ma prawie 20 lat (pojawił się w 1995).",
                "Język JavaScript jest językiem nietypowanym co po angielsku zwie się - duck typing.",
                "JavaScript nie jest kompilowany tylko interpretowany przez stronę.",
                "W języku JavaScript null jest obiektem.",
                "W języku JavaScript NaN (skrót od Not a Number) jest liczbą.",
                "Funkcje są przechowywane jako zmienne w języku JavaScript."
            };
        }

        List<string> AddPhpDataToTexts()
        {
            return new List<string>
            {
                "Maskotką PHP jest wielki niebieski słoń.",
                "PHP to skrót od: Personal Home Page",
                "Z PHP korzysta ponad 244 milionów stron(>81%) stąd na ten język jest nadal duże zapotrzebowanie.",
                "W języku PHP możemy programować obiektowo, proceduralnie albo mieszając te dwa sposoby.",
                "Popularne projekty PHP: Symfony, Laravel, CodeIgniter, Faker",
                "Język PHP został opublikowany w roku 1995. Wstępnie był napisany w języku C.",
                "Jak widzimy znak dolara przy jakiejś nazwie to najpewniej jest to zmienna języka PHP.",
                "Facebook, Yahoo!, Flickr, Wikipedia korzystają z języka PHP.",
                "Jeżeli chcesz tworzyć tablicę to skorzystaj ze składni języka array().",
                "Jednym z najcześćiej używanych środowisk do języka PHP jest Netbeans.",
                "Język PHP jest interpretowanym, skryptowym, językiem programowania.",
                "Funkcja to blok kodu utworzony aby wykonać określone zadanie.",
                "Stałą w języku PHP zdefiniować można za pomocą define.)",
                "Pętla do..while różni się od pętli while ponieważ wykona się przynajmniej jeden raz",
                "Formularze np. kontaktowe, ankiety mogą być obsługiwane przez PHP?",
                "Dolara używa się w PHP do zmiennych aby odróżnić je od stałych?"
            };
        }

        List<string> AddHtmlDataToTexts()
        {
            return new List<string>
            {
                "W języku HTML powinniśmy pamiętać zawsze o podstawowej strukturze pliku.",
                "Im więcej znaczników zrobisz tym lepiej? Łatwiej jest wtedy stylować stronę (projektować interfejs) i ją ofunkcjonować.",
                "W języku HTML możemy zagnieżdżać skrypty JavaScript między znacznikami <script></script>.",
                "Język HTML jest językiem do tworzenia stron.",
                "Język HTML jest językiem znacznikowym.",
                "Jeżeli stosujemy znacznik <img src> powinniśmy dodać atrybut alt z tekstem w razie gdyby zdjęcie nie zostało wczytane/już nie istniało.",
                "Najnowsza wersja języka HTML nosi numerek 5. (stan na rok 2019)",
                "Aby stworzyć tabelę należy skorzystać ze znaczników m.in: table, tr, th, td?",
                "W znaczniku <head> umieszczamy referencje do bibliotek z których korzystamy.",
                "Według standardów każdy plik typu .html powinien zaczynać się od linijki jakiego typu jest to strona HTML np. <!doctype html>",
                "Znaczniki i atrybuty w języku HTML powinny być pisane z małych liter np. <section> a nie <SECTION>.",
                "HTML to skrót od ang. HyperText Markup Language",
                "Wszystkie elementy języka HTML mogą mieć atrybuty np. href.",
                "Atrybuty w języku HTML zawsze podaje się w znaczniku rozpoczynającym.",
                "Aby móc zdefiniować te same style dla kilku elementów strony można skorzystać ze znacznika klasy.",
                "JavaScript sprawia, że strony HTML są bardziej dynamiczne i interaktywne."
            };
        }
    }
}
