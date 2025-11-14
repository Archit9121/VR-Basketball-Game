# 🏀 VR Basketball Shooter

![Basketball Shooter Screenshot](https://via.placeholder.com/800x400.png?text=VR+Basketball+Shooter+Gameplay)  
*Realistic physics-based VR basketball simulation built in Unity*

---

## 📖 Project Overview

"The Basketball Shoot Game in Unity" is an immersive Virtual Reality (VR) application that simulates the real-world act of shooting a basketball. Unlike traditional games that rely on button presses, this project uses direct hand motion tracking via VR controllers to throw the ball with accurate velocity and spin — creating a natural, skill-based experience.

Built with Unity, XR Interaction Toolkit (XRI), and OpenXR, the game runs smoothly across standalone (Quest 2) and PCVR (Rift S, Index) platforms.

---

## ✨ Key Features

- Physics-Based Throwing  
  Velocity and angular velocity are sampled from the controller over a 60–80ms window for smooth, jitter-free throws.
  
- Realistic Scoring System  
  Dual trigger colliders (Entry + Score) ensure only valid "swish" or rim-in shots are counted.

- Haptic & Audio Feedback  
  Controller vibrations on grab, release, and score. 3D spatial audio for bounces, rim hits, and net swishes.

- Performance Optimized  
  - Object pooling eliminates GC stutters  
  - Fixed Timestep synced to display refresh rate  
  - 72 FPS on Quest 2 | 90–120 FPS on PCVR

- Modular Architecture  
  Clean separation: GameManager, BallController, HoopScorer, AudioManager, HapticFeedbackService

---

## 🎮 Gameplay

1. Grab a ball from the rack using the Grip button
2. Physically throw it toward the hoop
3. Score points with clean shots or bank shots
4. Feel haptic pulses and hear realistic sound effects

> *No buttons needed — just like real basketball!*

---

## 🛠 Tech Stack

| Technology | Purpose |
|----------|--------|
| Unity 2022+ | Core engine |
| XR Interaction Toolkit | Grab mechanics, input handling |
| OpenXR | Cross-platform VR support |
| Nvidia PhysX | Realistic ball physics |
| C# Scripting | Gameplay logic, pooling, scoring |

---

