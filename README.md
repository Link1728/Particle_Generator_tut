# Particle_Generator_tut
Code for a MonoGame-based particle generation system. 

![example](Reference/example.png)

## Prerequisites
Before you can run this program, ensure that you have the following software installed and functional:
* One of the following operating systems: Windows 7, 8, 8.1, or 10.
* C++ 11
* MonoGame

## Running
1. Download the source code from this repository.
2. Compile and run the application.
3. In its current configuration, it produces a raining affect.

## File Summaries
Below is the list of each program file and a brief explanation of its role:
* [__Game1.cs__](Game1.cs) Dictates the game loop, as well as initialization of assets, updates, and the draw order.
* [__LeafGenerator.cs__](LeafGenerator.cs) Dictates the creation of leaf particles and the update.
* [__Leafs.cs__](Leafs.cs) Dictates the creation of a new leaf.
* [__ParticleGenerator.cs__](ParticleGenerator.cs) Dictates the creation of particles, the update, and draw of said particles.
* [__Program.cs__](Program.cs) Entry point for the application.
* [__Raindrops.cs__](Raindrops.cs) Dictates the creation of a new raindrop.

## Authors
*[**Brennan Sprague**](https://github.com/b-Sprague) - "Creator"
