# StoneSoup
The story of Stone Soup has been a popular traveling folktale for centuries, with no clear origin. The earliest publishings come from Europe in the 1700’s, however it’s assumed to be much older given the diverse number of variations in the story’s setup that exist across multiple cultures today. 

For our iteration we chose [this](https://www.learningtogive.org/sites/default/files/handouts/Story_Stone_Soup.pdf) simplified telling which features a wandering soldier in search of food and a place to spend the night. He holds nothing but a pot and stone on his person, but uses their charisma and wit to convince a small village, who are reluctant to share their waning resources, that they can make a delicious soup using only a magic stone. It intrigues the villagers and eventually convinces everyone to contribute a bit of their resources to collectively help create a delicious soup that feeds everyone. The story expresses the power of sharing, charisma and collaboration for the greater good as opposed to isolated survival of the fittest.

Our attempt in creating a game from this then, revolved around 3 aspects: traveling/exploration of the world to establish setting, interaction with villagers and progression to emphasize communication/collaboration, and collection of items for cooking and as a way for players to express agency in the narrative.

# IDEATION/PROTOTYPING:

Our initial outline for this game began as a 2D platformer, where the traveler navigates through a set of obstacles to reach town and retrieve elements for the soup. This however did not align with the communal theme we wanted to explore of Stone Soup, as it would be counterintuitive to centralize community around a game about movement.

The second iteration was designed to be a visual narrative, incorporating rpg elements and inventory management for story progression, much like an Ace Attorney, or [Emily is Away](https://www.youtube.com/watch?v=Ns4rWyTuErA) style of storytelling. Ultimately this felt too flat as a platform for us to convey the themes of Stone Soup’s story accurately and lacked a way for the player to move around and explore the environment.

This article on [Super Mario Bros.](https://origin-blog.mediatemple.net/design-creative/what-super-mario-taught-us-about-ux/), provided through class, was a really interesting read and touched on the importance of consistent design in games, particularly on the use of grid patterns for level structures. I took this into consideration when thinking about the geometry of the game. In the end we landed on a top down, 2D rpg-style game. A lot of inspiration and design elements for our game mimic popular titles like [Pokémon](https://corporate.pokemon.com/en-us/) and [Undertale](https://undertale.com/about/); particularly the movement system and dialogue structure. These types of games typically progress linearly and lend themselves well to chronological storytelling and worldbuilding. It provides just enough tools for players to traverse the world of our story, voluntary objectives to interact with, and an inventory system to collect and track their progress. 

Some considerations that came up were about the control schemes. What if the player is on a keyboard? What if they cannot use the directional arrows or are using an analog stick/ controller, how would they move

Another big consideration was visibility; How to indicate to the player that they would be able to interact with certain elements in  the world. Signifiers large enough to direct the player, but not too large that it distracts too from the core gameplay. 

# GAME BUILD: 

Our project began with the collection of assets, which we obtained through itch.io, linked [here](https://pixel-boy.itch.io/ninja-adventure-asset-pack). We felt that a pixel style for the graphics would be a great way of echoing that antique, folktale feel of Stone Soup into a modern but retro adaptation. This asset pack eased much of the design process through the use of tile mapping, which is basically a technique that uses pixel sprites like an artists’ palette, allowing you to customize and draw onto different layers of the world intuitively. 

To tackle accessibility of the controller, rather than hard-coding for each type of input (up, down, left right) we used the unity input package system, which automatically reads information from the keyboard’s directional arrows, WASD keys, and any connected controller inputs. This extends usability to much more than just one kind of controller.

The next step was to create the other characters of the world as well as the dialogue interface to interact with them. Placing the characters was easy enough, but dialogue was not. Alot of back and forth attempts occurred until we eventually figured out how to use prefabs to make multiple NPC’s, and then attach different lines of text to each of them. Afterwards we created a reader that would animate the text onto the screen for the player smoothly. 

The greatest obstacle here was how to adjust the dialog to react to player progression in the world, specifically after visiting objectives. Constructing an event system that  reads and responds to actions was very confusing. This ultimately became the wall that halted our progress further. We created a temporary workaround for playtesting that simply reads a predetermined set of lines for each interactable object. We also added music to add to the mood of the world and distract a little bit from the bugs.

Currently, users compliment Stone Story for its visually pleasing style. They noted the details of the world, character, and dialogue boxes. Users found little difficulty in locating and interacting with the objectives marked “Z” above them, or in following the dialogue and progressing the story. These experiences fall flat however when all objectives are essentially “completed” and nothing happens. There is no advancement or feedback afterwards. This emphasized the weight of  responsive design. 

There are also some camera bugs and jittering that needs calibration. In further iterations we would obviously establish a more dynamic dialogue system, since it is essentially the story driver of our game. We would also add cutscenes in the beginning, end, and to certain checkpoints for some diversity in the narration and as a break from holding down the controls. 

# HURDLE TRACKER:

Problem: Difficulty incorporating the assembled player animation walk cycle with the appropriate movement system.
    Solution: used [this](https://www.youtube.com/watch?v=DQY62meLVCk&list=PLaaFfzxy_80HtVvBnpK_IjSC8_Y9AOhuP&index=2) video to research, understand and implement the unity input system and assign the animations to respond to player input on arrow keys AND wasd keys

Problem: Lack of understanding on how to create layers of interaction (i.e. tilemaps) and world construction using a grid style structure.
    Solution: used [this](https://www.youtube.com/watch?v=UId0mwanBZg&list=PLaaFfzxy_80HtVvBnpK_IjSC8_Y9AOhuP&index=4) video to understand and implement 5 different layers of the game that the player will view and interact with. 

Problem: Started the implementation of a dialogue system for NPC’s and environmental objects, but struggled (greatly and extensively) on how to construct a responsive system that could adjust to player events and progress to create a cohesive chronological narrative.
    Attempt: My first attempt was to add an event tracker for the dialogue system that would read if a player had performed a certain action or traveled to a specific location on the map, and then respond accordingly to their progress. This failed miserably multiple times. Given the type of dialogue I implemented previously, it was confusing to figure out how to adapt that into a fully fledged game mechanic.
    Solution: A temporary solution here was to use my skills in animation to create a cheap cutscene that bridges the gap between the game and the story in place of a more concrete interaction.
