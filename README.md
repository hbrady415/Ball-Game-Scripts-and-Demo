# Unity-Scripts

A few simple Unity scripts I wrote to help teach  game design to children using Unity and C# with Deleware Steam Academy on Outschool.

ColorChangeCube:

Script used to create a color changing cube that changes colors every 2 seconds which was used as a collectable item inside of a game created in the class, used to teach coroutines.

EnemyAI & lastCollider:

Purpose of this script is to make a simple enemyAI where when the player enters a certain range the enemy will begin to chase you and if you are reached the level is reset.

These scripts are designed so that you can place the enemyAI script into an object with a Nav Mesh set up and and a box collider that will control the range.  
lastCollider is added into the player so that you can detect which type of collider you have entered.  I used a capsule collider as the inside collider to reset the level 
and a box collider as the outside collider which dictated the range.  

