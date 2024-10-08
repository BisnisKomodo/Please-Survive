## 🔴About
Lightning boy remains as my first simple game, inspired by Super Mario Bros where you gotta jump and avoid obstacle in order to reach to your winning places. I built the player movement system, Climbing System, Healthcontroller and the kill system for the player when falling to lava or touch nearby obstacle. Here's a small portion details about Lightning Boy development presented
<br>

## 🕹️Play Game
The game was built using Unity Engine. Play the game from https://bisniskomodo.itch.io/lightning-boy. 
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

## 📜Please Survive Scripts Example (EnemyMovement)
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationspeed;
    private Rigidbody2D rb2d;
    private ZombieSense playerAwarenessController;
    private Vector2 targetDirection;
    private float ChangeDirectionCooldown;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerAwarenessController = GetComponent<ZombieSense>();
        targetDirection = transform.up;
    }
    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        HandleRandomTargetDirection();
        HandlePlayerTargeting();
    }

    private void HandleRandomTargetDirection()
    {
        ChangeDirectionCooldown -= Time.deltaTime;
        if (ChangeDirectionCooldown <= 0)
        {
            float anglechange = Random.Range(-90f, 90f);
            Quaternion rotation = Quaternion.AngleAxis(anglechange, transform.forward);
            targetDirection = rotation * targetDirection;

            ChangeDirectionCooldown = Random.Range(1f, 2f);
        }
    }

    private void HandlePlayerTargeting()
    {
        if (playerAwarenessController.AwareOfPlayer)
        {
            targetDirection = playerAwarenessController.DirectionToPlayer;
        }
    }

    private void RotateTowardsTarget()
    {

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationspeed * Time.deltaTime);

        rb2d.SetRotation(rotation);
    }

    private void SetVelocity()
    {
        
         rb2d.velocity = transform.up * speed;
    }
}
```
