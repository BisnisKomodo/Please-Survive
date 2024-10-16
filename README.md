<table>
  <tr>
    <td align="left" width="50%">
      <img width="100%" alt="gif1" src="https://github.com/user-attachments/assets/2982a55d-ac57-40c0-9010-ed431de9b782">
    </td>
    <td align="right" width="50%">
      <img width="100%" alt="gif2" src="https://github.com/user-attachments/assets/49d16639-7622-4fa7-b6a7-2ec435449b3b">
    </td>
  </tr>
</table>

<p align="center">
  <img width="100%" alt="gif3" src="https://github.com/user-attachments/assets/1274a738-69dc-473f-8461-51d5d0efe947">
</p>

##  📜Scripts and Features

Top down shooter game as majority of game you found else where using simple scripting behavior for simple game. Some of the scripts are presented as follow

|  Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `HealthController.cs` | Responsible for the enemy health and also the player health |
| `PlayerDamagedInvincibility.cs` | Responsible for the invincible effect using coroutines |
| `EnemyMovement.cs`  | Responsible for the enemy ai behavior works in the game |
| `Collectables.cs`  | Responsible every item dropped by killing the zombies |
| `etc`  | |

<br>

## 🔴About
Please Survive, 2D top down shooter that rush yourself to a zombie apocalypse that keep spawning. You gotta kill them in order to survive the world. Each kills grant you score that makes the game even harder. I formulated a simple zombie enemy behavior, shooting scripts, Scoring system, animation system, gun system, and also the Healthcontroller. Here's a small portion details about Lightning Boy development presented
<br>

## 🕹️Play Game
The game was built using Unity Engine. Play the game from https://bisniskomodo.itch.io/please-survive. 
<br>

## 👤Developer
- Nicholas Van Lukman (Game Programmer)
<br>

## 📂Files description

```
├── Please Survives                   # Contain everything needed for Please Survive to works.
   ├── .vscode                        # Contains configuration files for Visual Studio Code (VSCode) when it's used as the code editor for the project.
      ├── extensions.json             # Contains settings and configurations for debugging, code formatting, and IntelliSense. This folder is related to Visual Studio Code integration.
      ├── launch.json                 # Contains the configuration necessary to start debugging Unity C# scripts within VSCode.                     
      ├── setting.json                # Contains workspace-specific settings for VSCode that are applied when working within the Unity project.
   ├── Assets                         # Contains every assets that have been worked with unity to create the game like the scripts and the art.
      ├── Art                         # Contains all the game art like the sprites, background, even the character.
      ├── Animation                   # Contains every animation clip and animator controller that played when the game start.
      ├── Sounds                      # Contains every sound used for the game like music and sound effects.
      ├── Scripts                     # Contains all scripts needed to make the gane get goings like PlayerMovement scripts.
      ├── Prefabs                     # Contains every pre-configured, reusable game object that you can instantiate (create copies of) in your game scene.
      ├── Scenes                      # Contains all scenes that exist in the game for it to interconnected with each other like MainMenu, Gameplay, etc
      ├── ThirdParty Packages         # Contains the Package Manager from unity registry or unity asset store assets for game purposes.
      ├── Lighting                    # Contains all the Universal Render Pipelines and all lighting for the game.
   ├── Packages                       # Contains game packages that responsible for managing external libraries and packages used in your project.
      ├── Manifest.json               # Contains the lists of all the packages that your project depends on and their versions.
      ├── Packages-lock.json          # Contains packages that ensuring your project always uses the same versions of all dependencies and their sub-dependencies.
   ├── Project Settings               # Contains the configuration of your game to control the quality settings, icon, or even the cursor settings
├── README.md                         # The description of Please Survive file from About til the developers and the contribution for this game.
```
<br>

<br>

## 🕹️Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement |
| Left Click             | Shooting              |
| Space             | Dash           |

<br>

