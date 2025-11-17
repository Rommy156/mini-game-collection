# Ricochet Rumble
# 1. **Introduction**
Ricochet Rumble expands on traditional pong by transforming the ball into a ticking time bomb that becomes increasingly unstable as players rally.

The game explores whether adding pressure, chaos, and strategic risk enhances engagement beyond the original Pong’s simplicity.
<img width="526" height="296" alt="Picture1" src="https://github.com/user-attachments/assets/a354d833-bb9e-4f44-9c95-bbe0794bc333" />
<img width="250" height="366" alt="images" src="https://github.com/user-attachments/assets/07223298-bb42-42ae-aeb0-35dd005f018a" />


# 2. **Gameplay**
Ricochet Rumble is designed as a 2D arcade, two-player competitive duel in which players use paddles to deflect an explosive projectile. Instead of a normal ball, players are managing a bomb with a shortening timer, forcing them into high-pressure volleys where every hit matters.
### Players must:

* Deflect the bomb while anticipating ricochets off reflective walls

* Special abilities include Big Paddle, Slow Ball, Speed Up Paddle Movement

* Avoid being caught on the side where the bomb explodes

# 3. **Objective Statement**
An arcade experience that amplifies tension, challenge, and engagement by replacing Pong’s static ball with a volatile, time-driven explosive object, encouraging players to balance precision, risk, and adaptability.
## Goals
* Create tension and suspense through the ticking timer mechanic

* Create moments of panic, excitement, and rapid adaptation

* Deliver the thrill of managing a dangerous object under pressure

* Reinvent classic pong using mechanics that increase unpredictability, player agency, and strategic decisions

# 4. Design Rationale
## Design Vision
We envision Ricochet Rumble as a modern, chaotic evolution of Pong. It's a fast, competitive arcade experience that maintains Pong’s accessibility while adding depth, unpredictability, and emotional tension. The introduction of a ticking explosive object creates a “hot potato” dynamic that forces rapid decision-making and transforms every volley into a moment of mounting pressure.

### Evaluates complexity vs. simplicity:
* Tests whether meaningful complexity (bomb timer, ricochets, control scramble) enhances engagement or overloads the original simplicity of Pong.

* Maintains a familiar core (paddles + bouncing object) while adding layered decision-making.

### Encourage clever, skill-based play

* Players feel smart when predicting ricochet angles and using arena geometry to their advantage.

* Reflective walls, tight corridors, and teleporters create opportunities for advanced trick shots.

* Encourages planned setups, baiting strategies, and creative use of ability power-ups.

* Supports both casual play (simple controls) and competitive mastery (high skill ceiling).

### Escalate difficulty through evolving arena features

* Later arenas add more reflective surfaces, tighter chokepoints, and special abilities.

* Environmental hazards (momentary force fields or shifting walls) keep players adapting.

* Faster ricochet physics and increased bomb volatility raise the skill ceiling.

* Ensures constant adaptation and prevents repetitive gameplay.


# 5. Core Loop & System Overview
## Match Structure

* A match is divided into continuous rallies where players deflect the bomb until the timer reaches zero.

* When the bomb explodes, the round ends and a point is awarded to the surviving player.

* Matches continue until one player reaches 10 points.

## Round Loop
###  1. Bomb Spawn

* Bomb appears at the center with a full timer.

* Initial speed is moderate.

### 2. Rally 

* Players hit the bomb back and forth.

**Each paddle hit:**

* Shortens bomb timer

* Increases bomb speed slightly

* Raises tension and danger


### 3. Escalation

* Environmental elements may shift unpredictably.

* Bomb countdown sound cues intensify as timer nears zero.

### 4. Explosion Event

* When the timer hits zero, the bomb explodes on the side of the screen it occupies.

* The affected player loses a point (or takes health damage).

**Explosion:** Screen shake or flash for feedback

### 5. Reset

* Arena returns to default state.

* Bomb respawns at the center.

* Next round starts.

## Difficulty Scaling
### Easy

* Few reflective panels

* Slower bomb travel speed

* More access to special abilities

* Low chaos, high clarity

### Hard

* More complex ricochet angles

* Special abilities appear less frequently

* Higher pressure and faster pacing

### Impeccable
* Tight corridors force unpredictable bounces

* Ricochets become dangerous and difficult to track

* Arena hazards rotate, flicker, or shift

* Bomb timer shortens faster each volley

* Peak intensity and decision pressure
  

# 6. Power Up Systems
## Overview
Power-ups spawn at set intervals or at random positions inside the arena. Only one power-up may be active at a time to avoid overwhelming the core Pong-style gameplay.
## Power-Up Types

### 1. Big Paddles
**Effect:** Temporary increase length of paddle
### Design Rationale
Reduces precision difficulty for a short period.
* **Duration:** 6–10 seconds
* **Visual Feedback:** Paddle scales up with a smooth stretch animation.
* **Audio Cue:** Low-pitch “extend” sound to communicate mass/strength.

### 2. Slow Ball
**Effect:** Reduces the bomb’s speed and ricochet velocity for a short duration.
### Design Rationale
Helps prevent rallies from becoming overwhelming in the match.
* **Duration:** 4-6 seconds
* **Visual Feedback:** Bomb glows blue and leaves a softer trail.
* **Audio Cue:** Lower ticking frequency to indicate reduced speed.

### 3. Speed Up Paddle Movement
**Effect:** Significantly increases paddle movement speed.
### Design Rationale
* Rewards fast decision-making and aggressive play styles.
* Creates exciting “last-second saves” that heighten player satisfaction and tension.
* **Duration:** 5-7 seconds
* **Visual Feedback:** Paddle leaves a motion-blur trail; slight distortion effect.
* **Audio Cue:** Swish or whoosh sound when moving.
 
# 7. References
* No Generated Assets/ Content used


# 8. Team Members
* Allen:  Project Manager | Documentation |
* Sergio: Programmer | Documentation
* Jon-Marc: Programmer
