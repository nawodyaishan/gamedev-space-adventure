# Space Shooter Adventure

2D Sci-Fi space shooter video game developed using Unity Game Engine and C# programming language. Developed using "The Most Comprehensive Guide To Unity Game Development Vol 1" course by Awesome Tuts.

## Player_Scripts

### PlayerMoveKeyboard.cs

This script handles the movement of the player using the keyboard.

#### Public Variables

- **speed:** The speed of the player's movement. Default value is 600f.

#### Private Variables

- **myBody:** The rigidbody component of the player.

#### Private Methods

- **Awake():** Gets the rigidbody component of the player.
- **FixedUpdate():** Calls the HandleMovement() method in every fixed update.
- **HandleMovement():** Handles the movement of the player based on the input keys.

### EngineFires.cs

This script handles the engine fires of the player's ship.

#### Public Variables

- **engineFires:** The particle system components of the engine fires.
- **enginePower:** The power of the engine fires. Default value is 10.

#### Private Methods

- **Update():** Calls the HandleFireEngine() method in every update.
- **HandleFireEngine():** Handles the emission of engine fire particles based on the input keys.
- **EmiEngineFireParticle(int engineIndex, int enginePower):** Emits engine fire particles for the given engine index and power.

## Gameplay_Controller

### Collector.cs

This script handles the collision of the player's projectiles, meteors, and collectibles.

#### Private Methods

- **OnTriggerEnter2D(Collider2D collision):** Destroys the collided object if it's a meteor or a collectible. Sets the collided object to inactive if it's a projectile.

---

## EnemyMovement

### Public Fields
- `bool moveOnX`: Whether the enemy should move on the X-axis or not.
- `bool moveOnY`: Whether the enemy should move on the Y-axis or not.
- `float minX`: The minimum position of the enemy on the X-axis.
- `float maxX`: The maximum position of the enemy on the X-axis.
- `float minY`: The minimum position of the enemy on the Y-axis.
- `float maxY`: The maximum position of the enemy on the Y-axis.
- `float moveSpeed`: The speed at which the enemy moves.
- `float horizontalMovementTreshold`: The maximum distance the enemy can move from its initial position on the X-axis.
- `float verticalMovementTreshold`: The maximum distance the enemy can move from its initial position on the Y-axis.

### Private Fields
- `Vector3 tempMovement_Horizontal`: A temporary vector used to store the enemy's position while moving horizontally.
- `Vector3 tempMovement_Vertical`: A temporary vector used to store the enemy's position while moving vertically.
- `bool moveLeft`: Whether the enemy is moving left or not.
- `bool moveUp`: Whether the enemy is moving up or not.

### Private Methods
- `void HandleEnemyMovementHorizontal()`: Handles the enemy's horizontal movement.
- `void HandleEnemyMovementVertical()`: Handles the enemy's vertical movement.

## EnemyMovementInPoints

### Public Fields
- `Transform[] movementPoints`: An array of points the enemy can move towards.
- `float moveSpeed`: The speed at which the enemy moves.
- `bool moveRandomly`: Whether the enemy should move towards a random point or not.

### Private Fields
- `int currentMoveIndex`: The index of the current point the enemy is moving towards.
- `Vector3 targetPosition`: The position of the current point the enemy is moving towards.

### Private Methods
- `void SetTargetPosition()`: Sets the target position to the next point in the `movementPoints` array.
- `void SelectRandomPosition()`: Selects a random point from the `movementPoints` array as the target position.
- `void SelectPointToPointPosition()`: Selects the next point in the `movementPoints` array as the target position.

## EnemyMovementRandom

### Public Fields
- `float minX`: The minimum position of the enemy on the X-axis.
- `float maxX`: The maximum position of the enemy on the X-axis.
- `float minY`: The minimum position of the enemy on the Y-axis.
- `float maxY`: The maximum position of the enemy on the Y-axis.
- `float moveSpeed`: The speed at which the enemy moves.

### Private Fields
- `Vector3 targetPosition`: The position the enemy is moving towards.

### Private Methods
- `void SetTargetPosition()`: Sets the target position to a random position within the `minX`, `maxX`, `minY`, and `maxY` bounds.



### `TagManager` class

#### `PLAYER_PROJECTILE_HOLDER_TAG`

The tag for the object that holds all of the player's projectiles.

#### `ENEMY_PROJECTILE_HOLDER_TAG`

The tag for the object that holds all of the enemy's projectiles.

#### `PRIJECTILE_TAG`

The tag for all types of projectiles in the game.

#### `ENEMY_TAG`

The tag for all enemies in the game.

#### `PLYAER_TAG`

The tag for the player object in the game.

#### `METEOR_TAG`

The tag for all meteors in the game.

#### `UNTAGGED_TAG`

The tag for all objects in the game that do not have a tag assigned to them.

#### `PLAYER_HEALTH_SLIDER_TAG`

The tag for the player's health slider object.

#### `COLLECTABLE_TAG`

The tag for all collectable objects in the game.

### `MeteorMovement` class

This class handles the movement and rotation of a meteor object.

#### `minSpeed`

The minimum speed the meteor can move at.

#### `maxSpeed`

The maximum speed the meteor can move at.

#### `speedX`

The current speed of the meteor on the X axis.

#### `speedY`

The current speed of the meteor on the Y axis.

#### `moveOnX`

A boolean that determines whether the meteor can move on the X axis.

#### `moveOnY`

A boolean that determines whether the meteor can move on the Y axis.

#### `minRotationSpeed`

The minimum rotation speed of the meteor.

#### `maxRotationSpeed`

The maximum rotation speed of the meteor.

#### `rotationSpeed`

The current rotation speed of the meteor.

#### `tempMovement`

A Vector3 that holds the current position of the meteor.

#### `zRotation`

The current rotation of the meteor on the Z axis.

#### `Awake()`

A Unity method that is called when the script instance is being loaded.

#### `Start()`

A Unity method that is called before the first frame update.

#### `Update()`

A Unity method that is called once per frame. It updates the movement and rotation of the meteor.

#### `RotateMeteor()`

A method that rotates the meteor based on its rotation speed.

#### `HandleMovementY()`

A method that handles the movement of the meteor on the Y axis.

#### `HandleMovementX()`

A method that handles the movement of the meteor on the X axis.

### `MeteorSpawner` class

This class handles the spawning of meteor objects.

#### `meteors`

An array of meteor objects to spawn.

#### `minX`

The minimum X position where the meteor can spawn.

#### `maxX`

The maximum X position where the meteor can spawn.

#### `minSpawnNo`

The minimum number of meteors to spawn.

#### `maxSpawnNo`

The maximum number of meteors to spawn.

#### `minSpawnInterval`

The minimum interval between each wave of meteors.

#### `maxSpawnInterval`

The maximum interval between each wave of meteors.

#### `randomSpawnNumber`

The number of meteors to spawn in the current wave.

#### `randomSpawnPosition`

A Vector3 that holds the random position where the meteor will spawn.

#### `Awake()`

A Unity method that is called when the script instance is being loaded.

#### `Start()`

A Unity method that is called before the first frame update. It starts spawning meteors.

#### `Update()`

A Unity method that is called once per frame.

#### `SpawnMeteors()`

A method that spawns a wave of meteors. It is called recursively with a random interval between each wave.
