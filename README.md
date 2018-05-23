projekt na GiKCzK w unity

/// WAŻNE ///
/*
To co jest poniżej jeszcze nie jest do
końca aktywne brakuje kilku ważnych
punktów dzięki którym będzie można
cokolwiek robić
*/
Co tu się dzieje:

mamy na początku scenę start posiada
ona kilka ważnych elementów:
MainCamera
Player
Timer
FinishingPoint
IngameUI
EventSystem

te elementy będą tworzyły całą mechanikę
gry i są podstawą do tworzenia poziomów.

Player - kuleczka którą się porusza i 
robi śmieszne rzeczy

Timer - zlokalizowany obiekt liczący czas
i punkty na potrzeby gry

FinishingPoint - dysk do którego dąży gracz
w celu przejścia poziomu

MainCamera - wiadomo

IngameUI - interface wyświetlający się w trakcie
gry

EventSystem - wiadomo

Gotowe assety:

HintTrigger - małe ustrojstwo które wyświetla podpowiedzi
po ustawieniu na planszę, ustalamy
rozmiar i w polu Hints Text w inspectorze
wybieramy tekst podpowiedzi
aby tekst się wyświetlił
potrzebny jest odpowiedni obiekt do tego
w tym celu rozwijamy IngameUI, dalej
rozwijamy GameMenu i przeciągamy
HintText w pole Text Box w inspektorze
podpowiedzi ustawiamy jako dzieci obiektu Hints

GroundLevel - trigger uruchamiający się jak kulka spadnie
poza planszę, wybieramy z assetów, dajemy odpowiednio
nisko pod planszą i ustawiamy rozmiar
w inpektorze ustawiamy jako Timer obiekt
Timer, End Menu to FailMenu z IngameUI a 
GameMenu to chyba jasne

Assety w folderze elementy(atm jeszcze go nie ma)
rampy, platformy itd w celu tworzenia toru przeszkód
bierzemy i ustawiamy jakieś ładne rzeczy, żeby było ładnie
i w miarę trudno Ustawiamy je jako dzieci pustego
obiektu LevelObjects

BigPowerup i SmallPowerup - 
obiekty które dodają odpowiednio po 15 i 10 sekund
graczowi do czasu gry, duże wypada ustawiać w
miejscach gdzie jest dodatkowy wysiłek sie dostać
Ustawiamy je jako dzieci pustego obiektu LevelObjects

Przed ustaleniem poziomu trudności sceny do leveli dodawajcie jako [imię][numer]