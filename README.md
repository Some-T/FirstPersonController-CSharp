# Instructions:

- Tested in Unity 2019.4.0f1 LTS
- Requires ProBuilder to be installed from the Unity package manager.
- Open Main Unity scene and utilise and modify the first person controller as you wish, utilising ProBuilder will make it easy to modify according to your game.


# Completed:

- Lock cursor = COMPLETE
- Mouse Look = COMPLETE
- Rotate Player = COMPLETE
- Camera Pitch = COMPLETE
- Clamp up and down = COMPLETE
- Speed = COMPLETE
- Movement = COMPLETE
- Jump = COMPLETE
- Ground Check = COMPLETE
- Hide crosshair = COMPLETE


# To Do:
- Jumping fine tuning
- Running and jumping
- Shooting projectiles from the player (Raycasting?)
- Have Camera act as parent object
- Crouching (with raycasting extra)
	- Ceiling raycast
- Melee Attack from the player
- Pick up objects (I believe raycasting is the best way to do this)
- Interact with objects, e.g. pressing a button


# Current Issues To Solve:

No current issues to solve!


## No longer issues, solved:

~~- Player is able to look through walls and solid objects when running right into them up close, thus if going in at the right angle can still go through walls and solid objects. This issue can be seen in the following video:~~

	~~- i.gyazo.com/ad45ef9e231fd2f9ec6d4cf76889aece.mp4~~

~~- I believe the player going through wall issue is now resolved, however to solve this I have begun implementing velocity for player movement which has now had the following effect to which I believe my code to be incorrect, basically the player is not moving in the direction the camera is facing.~~

**For the below two issues, Freezing the Y rotation, for some reason? Seemed to solve them and stop them from happening:**

~~- Player can run on the walls currently, even adding an higher mass does not prevent this, would a shapecast or raycast solve this issue perhaps?~~

~~- As per the below video, the player even just by sprinting or walking, after a short while will start moving on its own without any key presses, I find  when the player collides with an object it will set this off mostly instantaneously.~~
	~~- i.gyazo.com/f5dc989e3f832f0632003e842d850cc8.mp4~~