## Menu
<p align="left">
 <a href="https://github.com/trolit/projectZero"><img src="https://img.shields.io/badge/Dokumentacja%20dla%20u%C5%BCytkownika-gray?color=6B5B95&style=for-the-badge&logo=lgtm"></a> </br>
 <a href="https://github.com/trolit/projectZero/blob/master/README_dev.md"><img src="https://img.shields.io/badge/DOKUMENTACJA%20DLA%20DEVELOPERA-gray?color=009B77&style=for-the-badge&logo=dev.to" style="max-height: 550px;"></a> <br/>
 <a href="https://github.com/trolit/projectZero/blob/master/COMPILE.md"><img src="https://img.shields.io/badge/KOMPILACJA%20PROJEKTU%20W%20UNITY%20(TU%20JESTE%C5%9A)-gray?color=B565A7&style=for-the-badge&logo=unity" style="max-height: 550px;"></a> <br/>
 <a href="https://github.com/trolit/projectZero/blob/master/SHOWCASE.md"><img src="https://img.shields.io/badge/Animowane%20zrzuty%20z%20gry-gray?color=955251&style=for-the-badge&logo=big%20cartel" style="max-height: 550px;"></a> <br/>
 <a href="https://github.com/trolit/projectZero/blob/master/CREDITS.md"><img src="https://img.shields.io/badge/UZNANIA-gray?color=5B5EA6&style=for-the-badge&logo=showpad" style="max-height: 550px;"></a>
</p>

## Jak otworzyć i skompilować Project Zero w Unity?

Po pobraniu repozytorium Project Zero (gałąź master), uruchom środowisko Unity (użyj wersji 2018.3.12f1 (64-bit) o ile to możliwe). W panelu użytkownika wybierz przycisk Open

<img src="https://github.com/trolit/projectZero/blob/storage/photos/howToCompile/howToCompile0.PNG" height="50"/>

Wskaż wypakowany z ```projectZero-master.zip``` katalog Project Zero i naciśnij przycisk 'Wybierz folder'.

<img src="https://github.com/trolit/projectZero/blob/storage/photos/howToCompile/howToCompile1.PNG" height="50"/>

Rozpocznie się proces importowania projektu do Unity, który może chwilę potrwać. Wraz z zakończeniem importu projektu ukaże się narzędzie Unity z pustą sceną. Jeżeli chcesz zbudować projekt i uzyskać aplikację wybierz z menu File opcję Build Settings. 

<img src="https://github.com/trolit/projectZero/blob/storage/photos/howToCompile/howToCompile2.png" height="50"/>

Ukaże Ci się panel w którym możesz zdecydować o szczegółach kompilacji. 

<img src="https://github.com/trolit/projectZero/blob/storage/photos/howToCompile/howToCompile3.png" height="50"/>

Upewnij się, że platforma jest ustawiona na Windows, typ systemu - x86 (dopuszcza wtedy architekturę i 32 i 64 bity) oraz, że metoda kompresji jest ustawiona na LZ4HC. Kolejno, naciśnij jeden z dwóch przycisków umieszczonych przy dolnej krawędzi okna - Build lub Build And Run. W obu przypadkach zostaniesz poproszony o podanie katalogu w którym będzie budowany projekt. Jeżeli wybierzesz opcję Build And Run, aplikacja po udanej kompilacji zostanie automatycznie uruchomiona. W katalogu w którym miała zostać umieszczona aplikacja znajdziesz też plik wykonywalny ProjectZero.exe, którym możesz uruchomić grę. 
