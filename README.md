# Starlight
2D Platformer and Shooter

Starlight is a personal project I developed in 2021. The gameplay includes player controlled movement in a 2D level space. The level space includes platforming and obstacles for the player to navigate, as well as 4 different enemy types each with unique behaviors and reactions to the player. There are 3 main levels with a final boss fight at the end of the third level.

# The Player
> The player will control the main character using 'a' and 'd' to move left and right, space bar to jump, and left click to shoot the weapon. The player also has the ability to cling onto walls. Upon shooting the weapon the character will fire a projectile object in the direction the player is facing which will be destroyed once it comes into contact will a wall or enemy. If the bullet hits an enemy it will deal 20 damage. The palyer will be tasked with killing enemies and platforming through each level. 

# Enemies
1. Crab  
>The crab enemy is the most simple of the 4. The crab will simply patrol back and forth in its set space with a speed which can vary throughout the game. If the player comes into contact with the crab's hit box they will take damage. The crab sits with the most health of all the enemies in the game with 250 health and will take damage once hit by the players bullet projectile and once killed will it will drop a healing orb for the player.

2. Octapus
>The octapus enemy is a floating enemy that once the player enters it's attack range it will begin to move towards and chase the player. If the player comes into contact with the octapus' hit box they will take damage. The octapus sits with the least health of all the enemies in the game with 100 health and will take damage when hit by the players bullet projectile and once killed will it will drop a healing orb for the player.

3. UFO
>The UFO enemy behaves similarly to the crab in that it will patrol back and forth in it's spot floating in the air. Unlike the crab, the UFO will move into an attack state when the player enters it's trigger zone, when this happens the UFO will fire projectiles at the player which will damage the player on contact. These projectiles are able to be shot by the player to destroy them. In addition to the projectiles the UFO can damge the player on physical contact. The UFO sits in the middle with 200 health and will take damage when hit by player bullet projectiles and once killed will it will drop a healing orb for the player.

4. Jumper
>The jumper enemy behaves similarly to the octapus such that when the player enters its attack range it will begin to chase the player. When the jumper enters the attack state it will begin to start jumping towards the player and will damage the player on contact. The jumper sits in the middle with 150 health and will take damage when hit by player bullet projectiles and once killed will it will drop a healing orb for the player.

5. Final Boss
>The final boss arrives at the end of the game. It is a larger and stronger version of the octapus. Upon the start of the boss fight the boss will begin to chase the player throughout the boss room until defeated. This will be a bit of a challenge for the player due to the boss sitting at 1500 health. Once the player defeats the boss it will spawn a portal for the player to use to complete the game.

# Health and Healing Orbs
> The player will start with 100 health which is represented by the green health bar in the bottom left of the screen. If the player takes damage from any enemy they will take 20 damage giving them 5 hits before death. To counter this as the player kills enemies they will drop healing orbs. Each healing orb can be collected and will replenish 20 health back to the player.

# Level Failure and Completion
> To complete each level the player will move to the right in the world space combatting enemies and jumping accross various platforms. If the player takes too much damage from enemies or falls off the platforms then the will die which will cause the GameManager to restart the level. If the player successfully reaches the end of the level they will reach a teleporter station or a portal that will trigger the GameManager to move them to the next level.
