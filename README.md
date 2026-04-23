# C# Console Maze Game

A small C# console game where the player moves through a maze, collects fruits, and stores them in a bag inventory.

## Project Overview
This project is a beginner-friendly console game built in C#. The player starts at a fixed position and moves around the map using the arrow keys. At the beginning of each session, the program randomly selects one of two maps and places three fruits on free cells. When the player reaches a fruit, it is collected and added to the bag.

## Features
- Random selection between two different maps
- Player movement with arrow keys
- Wall collision handling
- Random fruit placement on valid cells
- Simple bag inventory display
- Console-based rendering loop

## Gameplay
- `@` — player
- `#` — wall
- `X` — fruit
- `o` — visited cell after fruit collection

The main goal is to move through the maze and collect fruits.

## Controls
- `↑` Move up
- `↓` Move down
- `←` Move left
- `→` Move right

## How to Run
1. Create a new **C# Console App** project in Visual Studio or VS Code.
2. Replace the generated `Program.cs` with the file from this repository.
3. Build and run the project.
4. Use the arrow keys to move around the map.

## Code Structure
- `Program` class
  - Initializes the game
  - Selects a random map
  - Places fruits
  - Handles input, movement, and rendering
- `Maps` class
  - Stores two predefined game maps as 2D character arrays

## What This Project Demonstrates
- Working with 2D arrays in C#
- Console rendering and cursor positioning
- Keyboard input handling
- Basic game loop logic
- Simple state management in a console application

## Possible Improvements
- Add a win condition after collecting all fruits
- Fix and improve bag logic for cleaner inventory display
- Prevent repeated `Random()` creation inside loops
- Add score counter and timer
- Add enemy movement or obstacles
- Split the code into multiple files for cleaner structure
- Add restart and exit options

## Tech Stack
- C#
- .NET Console Application

## Portfolio Note
This project is a simple example of game logic and console application development in C#. It is suitable as an entry-level GitHub portfolio project to demonstrate control flow, input handling, and basic object organization.
