ECO
===

## The Goal
_**Set in a [science fiction](http://io9.com/5644381/what-are-the-ingredients-for-great-science-fiction) universe, the player takes on the role of an unnamed individual who is assisted by an artificial intelligence known as ECO. The player is given "room" descriptions and can then interact within the current room by written or spoken commands. Time-dependent sequences and full-fledged sound create a modern experience for the player as they explore and reveal a plot-twisting story.**_

## The Plan
The game will be broken into Chapters or Sections composed of "rooms" depending on our development process. A "room" can be any describable place, e.g. a grassy field, a long hallway, a quadrant in outer space. We plan to support localization for two languages, English and Spanish. We also hope to make this game accessible to visually impaired gamers (and the backbone for each of these goals is already set up!).

## Focus on Sound
To bring the classic text-based game experience to modern audiences, we hope to make use of a large amount of auditory feedback. That is, to have voice-overs, sound effects, and background music where appropriate. The story for this game is ideal because the largest amount of voice-over comes from ECO, the artificial intelligence. This means that we can simply record Microsoft Sam or Mary speaking, or we can have ECO's lines read dynamically with Microsoft's Speech API ([SAPI](http://msdn.microsoft.com/en-us/library/ee125663(v=vs.85).aspx)).

## Time-Dependent Sequences
Time-dependent sequences could be used to introduce a sense of urgency or excitement to the game. Imagine the sound of a heartbeat racing, or a bomb ticking, or a train approaching. Each of these could be used along side a visual/audible count down to reinforce the immediacy of the situation. The player would need to give their next command, or resolve the entire issue, before the countdown ends. To introduce the concept, the first time-dependent sequence could have a long countdown.

## Foreseeable Challenges
The hardest part in making this game will probably be the natural language processing involved. Anytime the player types in or speaks a command, we have to be able to find the usable nouns and verbs and generate the appropriate response. So, typing or saying "go left" will make the character do that in game, if it is a possible action within the specific room.