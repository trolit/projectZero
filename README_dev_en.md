## Menu
<p align="left">
 <a href="https://github.com/trolit/projectZero/blob/master/README_en.md"><img src="https://img.shields.io/badge/User%20documentation-gray?color=6B5B95&style=for-the-badge&logo=lgtm"></a> </br>
 <a href="https://github.com/trolit/projectZero/blob/master/README_dev_en.md"><img src="https://img.shields.io/badge/Developer%20documentation%20(you%20are%20here)-gray?color=009B77&style=for-the-badge&logo=dev.to" style="max-height: 550px;"></a> <br/>
 <a href="https://github.com/trolit/projectZero/blob/master/COMPILE_en.md"><img src="https://img.shields.io/badge/Project%20compilation%20in%20Unity-gray?color=B565A7&style=for-the-badge&logo=unity" style="max-height: 550px;"></a> <br/>
 <a href="https://github.com/trolit/projectZero/blob/master/SHOWCASE_en.md"><img src="https://img.shields.io/badge/Gifs%20from%20game-gray?color=955251&style=for-the-badge&logo=big%20cartel" style="max-height: 550px;"></a> <br/>
 <a href="https://github.com/trolit/projectZero/blob/master/CREDITS_en.md"><img src="https://img.shields.io/badge/Credits-gray?color=5B5EA6&style=for-the-badge&logo=showpad" style="max-height: 550px;"></a>
</p>

## Documentation

### Cloning Repository
- Download GitHub Desktop: https://desktop.github.com/
- Fork the repository.
- Open GitHub Desktop and Clone repository.
- View information on compiling the project via <a href="https://github.com/trolit/projectZero/blob/master/COMPILE_en.md">this link<a>
- To make a pull request, changes can be made on a forked repository, or a new branch in the repo.

### Curiosities
- Time passed between start and end date(including free days): 162 days(5 months and 9 days), thats 44,38% of the 2019 year
- Source lines of code equals +/- 6000 (value without empty lines)
- Scripts dir contains 101 files
- 42 music tracks were used, to hear them all you would need 2 hours and 23 minutes
- The longest thing to do was environment designing for each minigame level
- The most tiring work to do for us was projecting minigames with trees (especially for PHP lang)
- Adding developer console was the best idea to faster testing times
- Prizes for medals, ProjectZero map overview and additional character were not planned from the start
- We wanted C# land to be lived by humans, but we did not find any interesting asset
- The most advanced script is NPCHandler
- Most problems were with setting up Pickup script for Puzzle minigame but was edited and now it looks solid
- Thanks to starting the project early, we managed to finish it
- Project reached 45 discussions over GitHub, 3 of them were marked as bugs
- Time to ring Project Zero map using the shortest path and fastest character(Slime Rabbit) - 1min 47sec
- Time to ring all paths of Project Zero map with Slime Rabbit character - 4min 30sec
- Project includes 92 graphics, 30 Unity assets
- HUD inspiraction was from TC: Rainbow Six Siege game
- Playable version contains 52 scenes, project also contains additionat scenes for game cover
- We wanted to make backpack work like box in which books are stored but due to time limit, we took lighter variant and created panel with all books.

### Mechanic
<p align="justify">
:small_orange_diamond: Player creates character by giving name, choosing available model and assigning points to attributes from basic pool. These actions are not mandatory and player has full freedom. <br/>
:small_orange_diamond: The game is taking place on the map in which is divided into lands that can be visited. Each of the land is represented by specific language and terrain. On each land player can find living beings that are interactable(NPCs) if player attribute level is suitable. <br/>
:small_orange_diamond: NPCs have tasks which player can solve. By approaching the task we mean playing minigame that is accessible to player. More details on each minigame type were described later in that document. <br/>
:small_orange_diamond: Money and information are given if minigame level is passed. In puzzle game there are no penalties. In the remaining minigame types mistakes matter. Content in summarizations depend on minigame type. <br/>
:small_orange_diamond: Money can be spent in stores. <br/>
:small_orange_diamond: Each land has bookstore. <br/>
:small_orange_diamond: Book contains information for specific language. Reading it first time will increase character attribute level and unlock more tasks to complete.  <br/>
:small_orange_diamond: The game target is to meet/remind raised elements. <br/>
:small_orange_diamond: Game is done in 100% when player finishes all available minigame levels(not by one approach). <br/>
:small_orange_diamond: It's impossible to lose game with the need to start a new one. <br/>
:small_orange_diamond: Maze is minigame that can be repeated if obtained results are not satisfying. 
</p>

### Land types, terrain, beings
| Language | Terrain type | Being type |
| :---:  | :---: | :---: |
| C# | woody (spring style) | dog |
| Java | waste | cat |
| HTML | mountainous | rabbit |
| JavaScript | winter | penguin |
| PHP | woody (autumn style) | mouse | 

### Minigames
Here you will find details about implementend minigames.

#### Skyscraper
<p align="justify">
Here player's character is positioned on the top of "skyscraper" which is built from several levels. Each level consists of question and 4 answers that can be selected. When player chooses wrong answer, it does not affect skyscraper construction. Choosing correct answer will make current section disappear. Minigame is played until reaching ground.
</p>

#### Pinpin
<p align="justify">
Pinpin is similiar to skyscraper, however here, player must select correct code fragment from the given language. To select code fragment, player must drag drawing pin to the area of code and then stand on the button that verifies decision. Mistakes count to the amount of currency that can be won.
</p>

#### Puzzle
<p align="justify">
Typical minigame when it comes to programming. Player must set propely all given blocks of code in designated places. To make game easier for beginners, when puzzle block is set in correct place it will be marked and locked from further movement. On level solve player gets fixed currency amount and information about code that was laid. 
</p>

#### Maze
<p align="justify">
In maze minigame player must collect proper code fragments and evade bugs. Collecting bugs affect quality of summarization and amount of currency that can be won. Maze is a type that can be repeated if results are not satisfying(not if player already collected prize).
</p>

### Conceptual graphics
| Map template | Map example | Map e.g. with paths |
| :---:  | :---:  | :---:  |
| <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_0.png?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_1.jpg?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_2.jpg?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> |
| Skyscraper (side) | Skyscraper (top) | Menu |
| <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_3.png?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_4.png?raw=true" alt="Koncepcja mapy" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_5.jpg?raw=true" alt="Koncepcja menu" width="350px" height="140px"></img> | 
| Character creation | NPC (1) | NPC (2) |
| <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_6.jpg?raw=true" alt="Koncepcja tworzenia postaci" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_7.png?raw=true" alt="Koncepcja tworzenia postaci" width="350px" height="140px"></img> | <img src="https://github.com/trolit/projectZero/blob/storage/photos/con_8.png?raw=true" alt="Koncepcja tworzenia postaci" width="350px" height="140px"></img> |

### Game includes
:zero::zero: top down view gameplay <br/>
:zero::one: main world split into 5 lands </br>
:zero::two: different design style for each prepared land </br>
:zero::three: moving beings thanks to Unity navmesh technolog <br/>
:zero::four: interactable NPCs <br/>
:zero::five: panel with all books <br/>
:zero::six: character creator <br/>
:zero::seven: spendable currency in bookstores <br/>
:zero::eight: character knowledge progress by reading books <br/>
:zero::nine: minigame: quiz <br/>
:one::zero: minigame: maze <br/>
:one::one: minigame: pinpin <br/>
:one::two: minigame: puzzle <br/>
:one::three: 40 levels in total to pass <br/>
:one::four: 20 books to check <br/>
:one::five: more than 40 music tracks to hear <br/>
:one::six: minigames summarization and loading screens also with some knowledge <br/>
:one::seven: different design each of the minigame level <br/>
:one::eight: different musical setting in each of the minigame level <br/> 
:one::nine: adjustable settings <br/>
:two::zero: repetitiveness (it's not possible to pass all minigame levels during one approach) <br/>
:two::one: medals <br/>
:two::two: prizes for medals (for e.g. additional playable character) <br/>
:two::three: special icon designed for saving game status <br/>
:two::four: world map overview <br/>
:two::five: minimap in player's HUD while travelling through world <br/>
:two::six: developer console to test application <br/>

### Presentable lands colors
| Language | Color | Name in Unity | Sample |
| :---:  | :---:  | :---:  | :---: |
| C# | lime | lime | ![#00FF00](https://placehold.it/25/00FF00/000000?text=+) |
| JavaScript | cyan | cyan | ![#00ffff](https://placehold.it/25/00ffff/000000?text=+) |
| Java | yellow | yellow | ![#FFFF00](https://placehold.it/25/FFFF00/000000?text=+) |
| HTML | magenta | magenta | ![#ff00ff](https://placehold.it/25/ff00ff/000000?text=+) |
| PHP | orange | orange | ![#FFA500](https://placehold.it/25/FFA500/000000?text=+) |

### Controls
Keys might differ depending on minigame that is played or current location <br/>
W - forward <br/> 
A - left <br/>
S - backward <br/>
D - right <br/>
B - open/close books panel <br/>
F - interact with NPC  <br/>
Space [hold] - catch and move puzzle/drawing pin <br/>
LMB (left mouse button) - buying in shop, opening books etc.

### Materials
In CREDITS_en.md file you will find references to the elements that were used in the project: assets, music, graphics. They are showed also in game, in Credits section. Credits can be reached using <a href="">this link</a>.

### Editor configuration
**Warning!** To get correct view of 'Game' window in Unity, create profile with 1920x1080 resolution. Set it and then change Scale parameter to minimum assignable value.

If using Unity Hub, the <a href="https://unity.com/releases/editor/archive">Unity download archive<a> has a direct link for installing the Unity version.

### Unity tool version
2018.3.12f1 

### .NET Framework version
v 4.7.1 

### Screens
More photos from creating Project Zero can be found <a href="https://github.com/trolit/projectZero/issues/33">here</a> and <a href="https://github.com/trolit/projectZero/issues/29">here</a>.

### Videos from projecting
References to the recorded videos are available here: <a href="https://github.com/trolit/projectZero/issues/35">link</a>.

### Game analysis
Levels unlocking, prizes, penalties were described <a href="https://github.com/trolit/projectZero/issues/5">here</a>, books valuation <a href="https://github.com/trolit/projectZero/issues/38">here</a>.

### Keys
All used keys with description are described <a href="https://github.com/trolit/projectZero/issues/4" target="_blank">in this thread</a>.

### Summarizations
Summarizations content for maze/pinpin/puzzle minigames are available <a href="https://github.com/trolit/projectZero/issues/7">here</a>.

### Tasks
Tasks done for this project are documented <a href="https://github.com/trolit/projectZero/issues/2">here</a>.
