# Instructions:

- Tested in Unity 2020.1.2f1
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
- Basic crouching without raycasting = COMPLETE


# To Do:

- Crouching (with raycasting extra) (These two aspects will be so when I crouch in a tunnel and stand up, that I do not go through the ceiling)
	- Ceiling raycast
- Have Camera act as parent object? I can't actually remember why I thought to do this initially but left it in here just incase. I think may have been something to do with the Ceiling raycast for when I crouch?
- Pick up objects, move object with player whilst holding and such throw objects (https://docs.unity3d.com/ScriptReference/Physics.OverlapSphere.html)
- Shooting projectiles from the player not using raycasting (I can use raycasting, but this means enemies and such can not dodge the bullet, so ideally don't use raycasting for this)

- Melee Attack from the player
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