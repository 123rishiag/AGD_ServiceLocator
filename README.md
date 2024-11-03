# Angry Monkeys

Angry Monkeys is a tower defense game inspired by Bloons Tower Defense 6 (BTD6). The game involves strategically placing monkey towers to stop waves of enemy balloons. This project focuses on essential design patterns, with an emphasis on implementing Singleton, Service Locator, and Dependency Injection to manage game elements efficiently.

---

## Features

- **Monkey Towers**: Different monkey types with unique attributes and target preferences add strategic depth to the gameplay.
- **Varied Balloon Types**: Multiple balloon types, each with distinct speed, damage, rewards, and layered structure, challenge players to select the right monkey types.
- **Scriptable Objects**: Monkeys, Projectiles, Balloons, and their specific types and attributes are managed using Scriptable Objects for modularity and expandability.
- **Game Design Patterns**:
  - **Singleton**: Used to remove the disadvantages of dependencies in inspector-shared files.
  - **Service Locator**: Addresses the disadvantages of Singleton by centralizing access to services.
  - **Dependency Injection**: Replaces Service Locator, providing flexible dependency management for further decoupling.

---

## __Game Mechanics__

- **Monkey Types**: Each monkey has distinct attributes for varying strategic playstyles:
  - **Sharp Eye Monkey** - Moderate rotation speed (100), uses darts with moderate range (3) and moderate attack rate (0.5), costs 50, and targets only Red balloons.
  - **Ninja Monkey** - High rotation speed (150), uses shurikens with moderate range (4) and high attack rate (0.2), costs 150, and targets Red and Blue balloons.
  - **Sniper Monkey** - High rotation speed (150), uses bullets with long range (5) and very high attack rate (0.1), costs 300, and targets Red, Blue, and Metal balloons.

- **Projectile Types**: Projectile types vary in speed and damage for tailored effectiveness:
  - **Dart** - High speed (20) with low damage (1).
  - **Shuriken** - Moderate speed (10) with moderate damage (2).
  - **Bullet** - Low speed (8) with high damage (5).

- **Balloon Types**: Each balloon type has unique properties, including speed, damage, rewards, and the number of balloons it spawns when popped:
  - **Red Balloon** - Low damage (1), low reward (5), moderate speed (3), and bursts with no additional balloons generated.
  - **Blue Balloon** - Moderate damage (5), moderate reward (10), moderate speed (3), and bursts to release 5 Red balloons.
  - **Metal Balloon** - High damage (50), high reward (50), low speed (1), and bursts to release 5 Blue balloons.

- **Waves**: The game has 9 waves with increasing difficulty:
  - **Wave 1**: 10 Red balloons.
  - **Wave 2**: 4 Blue balloons.
  - **Wave 3**: 10 Blue balloons.
  - **Wave 4**: 3 Metal balloons.
  - **Wave 5**: 10 Metal balloons.
  - **Wave 6**: 15 Metal balloons.
  - **Wave 7**: 20 Metal balloons.
  - **Wave 8**: 25 Metal balloons.
  - **Wave 9**: 30 Metal balloons.

---

## __Project Structure__

- **GameService**: Coordinates and encapsulates the services below, ensuring streamlined interactions within the game.
  - **EventService**: Manages events within the game, such as map selection.
  - **MapService**: Manages game map layout and monkey placements.
  - **WaveService**: Controls balloon wave management and spawning logic.
  - **SoundService**: Manages sound effects and background music.
  - **PlayerService**: Handles player-related logic, including scores and health.
  - **UIService**: Manages UI components, including tower selection and score display.

---

## __Learning Outcomes__

- **Design Patterns**: Gained hands-on experience with key design patterns like Singleton, Service Locator, and Dependency Injection to manage game components effectively.
- **Modular Architecture**: Improved understanding of modular architecture by implementing patterns that allow for flexible, decoupled components.
- **Dependency Management**: Learned how to manage dependencies across different game services, enhancing scalability and maintainability.
- **Service-Oriented Structure**: Developed a service-oriented structure that encapsulates different functionalities under a centralized management system (GameService) for streamlined game logic.

---

## __Setting Up the Project__

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/123rishiag/AGD_ServiceLocator.git
   ```
2. Open the project in Unity.

---

## __Video Demo__

[__Watch the Video Demo__](https://www.loom.com/share/b3d6ca11dbf04b3ab043543845b6c550?sid=ef63eeb6-0e89-4bcc-b984-3ae746a4d48c)

## __Play Link__

[__Play the Game__](https://outscal.com/narishabhgarg/game/play-angry-monkeys-10-game)