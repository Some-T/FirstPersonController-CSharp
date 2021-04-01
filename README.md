# Instructions:

- Tested in Unity 2021.1.1f1
- Requires ProBuilder to be installed from the Unity package manager.
- Open Main Unity scene and utilise and modify the first person controller as you wish, utilising ProBuilder will make it easy to modify and prototype according to your game.


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
- Make Jumping more fluid = COMPLETE
- Crouching wit raycasting ceiling check = COMPLETE


# To Do:

- Pick up objects, move object with player whilst holding and such throw objects.
	- Todo still for this:
		- Stop the issue, where it is picking up the object on the corner of it.
		- Do it so I press E key again and it drops the object, still allowing me to run and walk with the object when holding it.
		- Throw the object
		- Stop object changing size, when I crouch with the object, I have disabled picking up an object and to drop it when crouching but it still changes the scale / size of the object slightly.
			- It is also doing this slightly when normally picking up an object but not as much.
		- Need to fix automatically dropping the object when crouching, and disabling picking up objects completely when crouching, currently it is only letting me crouch just after I have picked up an object, no longer when I have no object at all.
- Interact with objects, e.g. pressing a button
- Picking up a gun of some sort then:
	- Shooting projectiles from the player not using raycasting (I can use raycasting, but this means enemies and such can not dodge the bullet, so ideally don't use raycasting for this) do as a laser shooting, so then I don't have to bother with arm animations and such, e.g. could be like its shooting two beams consistently from the players eyes, but the beams move physical objects as well as destroy after a while (when life of object reaches 0) could do press key once shoots two laser bullets from the eyes, hold key down shoots laser beams from the eyes. (Gun will have unlimited ammo or be a laser gun)
	- Drop gun
- Picking up a Melee weapon then 
	- Melee Attack from the player (e.g. hitting an object with a stick)
	- Drop melee weapon
- Tweak gravity for when player jumps.
- Tweak speed possibly?
- Clean up code, add comments in and sort into sections where possible so I know what each part of the code is doing.


# Current Issues To Solve:

- Player sticks to the wall when running and jumping into it.



## No longer issues, solved:

~- When crouched in the tunnel, if I jump (pressing space bar) the player will clip through the ceiling slightly.~

~~- Player is able to look through walls and solid objects when running right into them up close, thus if going in at the right angle can still go through walls and solid objects. This issue can be seen in the following video:~~
	~~- i.gyazo.com/ad45ef9e231fd2f9ec6d4cf76889aece.mp4~~

~~- I believe the player going through wall issue is now resolved, however to solve this I have begun implementing velocity for player movement which has now had the following effect to which I believe my code to be incorrect, basically the player is not moving in the direction the camera is facing.~~

**For the below two issues, Freezing the Y rotation, for some reason? Seemed to solve them and stop them from happening:**

~~- Player can run on the walls currently, even adding an higher mass does not prevent this, would a shapecast or raycast solve this issue perhaps?~~

~~- As per the below video, the player even just by sprinting or walking, after a short while will start moving on its own without any key presses, I find  when the player collides with an object it will set this off mostly instantaneously.~~
	~~- i.gyazo.com/f5dc989e3f832f0632003e842d850cc8.mp4~~