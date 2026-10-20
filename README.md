# in-class-activities
## Devlogs
### W1
If the Camera is moved off of the Cat GameObject, the camera will not move along with the cat because it is now at the same level and will not move along with the cat's movement.
https://frenchfries666.itch.io/w1d1-in-class-activity
### W2
1. Because r,g,b variables are both decimal.
2. Since this is a collision, the number of times must be an integer.
3. No semicolon at the end.
### W3
#table 16

Activity1: 
1. input int and boolean, output string
2. input float, output void
3. input boolean, output bool

Activity2:

I think of a class as a person: a complete profile of traits and abilities that exists only on paper. A Component is the job that person gets hired for — the moment they are hired (instantiated), the profile becomes a working barista, cashier, or guard. Member variables are the person's traits, like charm or stamina. Methods are the full abilities they can perform, like making latte art or operating the register. 

Because it multiple 1.2 every single time.

### W4
Table 16
1. I added Rigidbodies to the Cat and the SoccerBall, but not to the Goal. A Rigidbody makes an object physical, so the cat can kick the ball and both can bounce off the wall — their colliders do not use Is Trigger. The Goal only has Is Trigger checked: it just needs to detect the ball entering while letting it pass through. It does not need a Rigidbody because it never moves, and gravity would pull it down.
2. At first the ball only spun in place and did not move forward when kicked. The problem was that Freeze Position X and Z were checked on its Rigidbody, so it was locked in place. Unchecking them fixed it. 
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
