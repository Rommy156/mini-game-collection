# Ricochet Rumble
# 1. **Introduction**
Ricochet Rumble expands on the game `Pong` by transforming the ball into a ticking time bomb that becomes increasingly unstable as players rally.

The game explores whether adding pressure, chaos, and strategic risk enhances engagement beyond the original Pong’s simplicity.
<img width="526" height="296" alt="Picture1" src="https://github.com/user-attachments/assets/a354d833-bb9e-4f44-9c95-bbe0794bc333" />
<img width="250" height="366" alt="images" src="https://github.com/user-attachments/assets/07223298-bb42-42ae-aeb0-35dd005f018a" />


# 2. **Gameplay**
Ricochet Rumble is designed as a 2D arcade, two-player competitive duel in which players use paddles to deflect an explosive projectile. Instead of a normal ball, players are managing a bomb with a shortening timer, forcing them into high-pressure volleys where every hit matters.

* Deflect the bomb while anticipating ricochets off reflective walls

* Special abilities include Big Paddle, Slow Ball, Speed Up Paddle Movement

* Avoid the bomb from passing through the vertical walls

# 3. **Objective Statement**
An arcade experience that amplifies tension, challenge, and engagement by replacing Pong’s static ball with a volatile, random path, encouraging players to balance precision, risk, and adaptability.
## 3.1 Goals
* Create tension and suspense through the ticking timer mechanic

* Create moments of panic, excitement, and rapid adaptation

* Deliver the thrill of managing a dangerous object under pressure

* Reinvent classic pong using mechanics that increase unpredictability, player agency, and strategic decisions

# 4. Design Rationale
## Vision
We envision Ricochet Rumble as a modern, chaotic evolution of `Pong`. It's a fast, competitive arcade experience that maintains Pong’s accessibility while adding depth, unpredictability, and emotional tension. The introduction of a ticking explosive object creates a “hot potato” dynamic that forces rapid decision-making and transforms every volley into a moment of mounting pressure.

### 4.1 Evaluates complexity vs. simplicity:
* Tests whether meaningful complexity (bomb timer, ricochets, control scramble) enhances engagement or overloads the original simplicity of `Pong`.

* Maintains a familiar core (paddles + bouncing object) while adding layered decision-making.

### 4.2 Encourage clever, skill-based play

* Players feel smart when predicting ricochet angles and using arena geometry to their advantage.

* Reflective walls, tight corridors, and teleporters create opportunities for advanced trick shots.

* Encourages planned setups, baiting strategies, and creative use of ability power-ups.

* Supports both casual play (simple controls) and competitive mastery (high skill ceiling).

### 4.3 Escalate difficulty 

* Later arenas add more reflective surfaces, tighter chokepoints, and special abilities.

* Environmental hazards (momentary force fields or shifting walls) keep players adapting.

* Faster ricochet physics and increased bomb volatility raise the skill ceiling.

* Ensures constant adaptation and prevents repetitive gameplay.


# 5. Core Loop & System Overview
## 5.1 Match Structure

* A match is divided into continuous rallies where players deflect the bomb until ball goes through one of vertical wall.

* When the bomb goes through the wall, the round ends and a point is awarded.

* Matches continue until one player reaches 10 points.

## 5.2  Loop
###  1. Bomb Spawn

* Bomb appears at the center with a full timer.

* Initial speed is moderate and direction is random.

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

* The unaffected player gains a point.

**Explosion:** Screen shake or flash for feedback

### 5. Reset

* Arena returns to default state.

* Bomb respawns at the center.

* Next round starts.

## 5.3 Difficulty Scaling
### 1. Easy

* Few reflective panels

* Slower bomb travel speed

* More access to special abilities

* Low chaos, high clarity

### 2. Hard

* More complex ricochet angles

* Special abilities appear less frequently

* Higher pressure and faster pacing

### 3. Impeccable
* Tight corridors force unpredictable bounces

* Ricochets become dangerous and difficult to track

* Arena hazards rotate, flicker, or shift

* Bomb timer shortens faster each volley

* Peak intensity and decision pressure
  

# 6. Power Up Systems
## Overview
Power-ups spawn at set intervals or at random positions inside the arena. Only one power-up may be active at a time to avoid overwhelming the core Pong-style gameplay.
## 6.1 Power-Up Types

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
* Mechanics inspired by classic `Pong` (Atari, 1972)  


# 8. Team Members
* Allen:  Project Manager | Documentation | Programmer asst.
* Sergio: Programmer | Documentation asst.
* Jon-Marc: Programmer
