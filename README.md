# Starlight
2D Platformer and Shooter

Starlight is a personal project I developed in 2021. The gameplay includes player controlled movement in a 2D level space. The level space includes platforming and obstacles for the player to navigate, as well as 4 different enemy types each with unique behaviors and reactions to the player. There are 3 main levels with a final boss fight at the end of the third level.

# The Player
> Starlight is a personal project I developed in 2021. The gameplay includes player-controlled movement within a 2D environment. The levels feature platforming challenges and obstacles for the player to navigate, as well as four different enemy types, each with unique behaviors and reactions to the player. There are three main levels, culminating in a final boss fight at the end of the third level.

# Enemies
1. Crab  
>The crab enemy is the simplest of the four. It will patrol back and forth in its designated space, moving at a speed that can vary throughout the game. If the player comes into contact with the crab's hitbox, they will take damage. The crab has the most health of all the enemies, with 250 health. It will take damage when hit by the player's bullet projectile and, once killed, it will drop a healing orb for the player.

2. Octapus
>The octopus enemy is a floating creature that, once the player enters its attack range, will start moving toward and chasing the player. If the player comes into contact with the octopus's hitbox, they will take damage. The octopus has the least health of all the enemies, with 100 health. It will take damage when hit by the player's bullet projectile and, once killed, will drop a healing orb for the player.

3. UFO
>The UFO enemy behaves similarly to the crab in that it patrols back and forth in its spot, floating in the air. Unlike the crab, the UFO will enter an attack state when the player enters its trigger zone. When this happens, the UFO will fire projectiles at the player, damaging them on contact. These projectiles can be shot and destroyed by the player. In addition to the projectiles, the UFO can damage the player on physical contact. The UFO has 200 health, placing it in the middle in terms of health among the enemies. It will take damage when hit by the player's bullet projectiles and, once killed, will drop a healing orb for the player.

4. Jumper
>The jumper enemy behaves similarly to the octopus in that, when the player enters its attack range, it will begin chasing the player. When the jumper enters the attack state, it will start jumping toward the player and will damage them on contact. The jumper has 150 health, placing it in the middle in terms of health among the enemies. It will take damage when hit by the player's bullet projectiles and, once killed, will drop a healing orb for the player.

5. Final Boss
>The final boss appears at the end of the game. It is a larger and stronger version of the octopus. At the start of the boss fight, the boss will begin chasing the player throughout the boss room until defeated. This will be a challenge for the player due to the boss having 1500 health. Once defeated, the boss will spawn a portal that the player can use to complete the game.

# Health and Healing Orbs
> The player will start with 100 health, represented by the green health bar in the bottom left of the screen. If the player takes damage from any enemy, they will lose 20 health, allowing for 5 hits before death. To counter this, as the player kills enemies, they will drop healing orbs. Each healing orb can be collected to replenish 20 health.

# Level Failure and Completion
> To complete each level, the player will move to the right in the world space, combating enemies and jumping across various platforms. If the player takes too much damage from enemies or falls off the platforms, they will die, causing the GameManager to restart the level. If the player successfully reaches the end of the level, they will encounter a teleporter station or a portal, which will trigger the GameManager to move them to the next level.
