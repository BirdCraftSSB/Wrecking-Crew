# Wrecking-Crew
Joshua Yap
100780233
odd

Controls

W - Up

A - Left

S - Down

D - Right

Space Bar - Jump

Left Mouse Button - Shoot (10 Ammo)

I consulted the lab materials for this assignment

I watched gameplay of Wrecking Crew Video Game for inspiration

Wrecking Crew has Mario and Luigi break blocks at construction site while avoiding various enemies. 
The scene depicts Mario represented by a bunny model destroying blocks. 

Singleton
In Wrecking Crew some blocks have more health than others so the singleton is used to determine how much more hits the player dealt to the blocks. 
When called the pattern first checks what block is present in the scene, then it asks how much health the block has. Depending on the block, 
the pattern tells the player how many more hits is required to break it by changing the colour of the block.

Observer
The observer is implemented into the blocks. 
When called it will look for the block prefabs the player selects, if the pattern cannot find the block it will end the action. 
When it finds the associated block object, it then looks if there is already a block in the scene
It will then allow the player to freely place more blocks until they decide to go back to the game.

Command
The Command pattern is allows the other patterns to function. It counts the amount of items (blocks) currently in the scene, as well as their positions. The command also allows the player to remove blocks from the scene using the undo function. It first looks at the block list, where it then calculates the amount of blocks in the scene. When the player presses right click it will redo the object removed before hand.
