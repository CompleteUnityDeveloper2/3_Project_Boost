# Complete Unity Developer 2.0 - Section 3 - Planet Boost.

This is the long-awaited sequel to the Complete Unity Developer - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects, our latest teaching techniques,. You will benefit from the fact we have already taught over 250,000 students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo.

## By In This Section
Basic Particle Effects. Local version control. Basic UI & Menu. C# classes, function return values. Unity Components, coordinate systems, origins and anchor points, advanced prefabs. Level design. (Ref: PB_CU2)

## How To Build / Compile
This is a Unity project. If you're familiar with source control, then "clone this repo". Otherwise download the contents, and navigate to `Assets > Levels` then open any `.unity` file.

This branch is the course branch, each commit corresponds to a lecture in the course. The current state is our latest progress.

## Lecture List
Here are the lectures of the course for this section...

### 1 Welcome To Section 3 ###
1. This game is based on the old classic Thrust.
2. We'll be using Unity's physics engine.
3. Rick will be teaching design.

### 2 Project Boost Game Design ###
1. This game is based on the old classic Thrust.
2. We'll be using Unity's physics engine.
3. Rick will be teaching design.

### 3 Onion Design ###
1. Common game design challenges that we need to resolve.
2. What is onion design and how are we using it to inform priorities for developing our game.

### 4 Introducing Version Control ###
1. About version control and why we care.
2. How version control helps with game development.
3. Setting up Git and SourceTree with Unity.

### 5 Add Unity `.gitignore` Easily ###
1. What a `.gitignore` file is.
2. Unity's `Library` folder is a cache.
3. How to easily add a Unity `.gitignore`.

### 6 The Origin Of Our World ###
1. Which axis is right, forward and up in Unity.
2. Everything should be prefabbed.
3. How to create a material.
4. Setting our world origin.

### 7 Placeholder Art From Primitives ###
1. Guidelines for setting up compound game objects.
2. Using primitive shapes to create placeholder art.
3. Creating our first rocket ship!

### 8 Basic Input Binding ###
1. How to read direct from keys.
2. Testing key logic with the Console.
3. Preparing to launch our ship.

### 9 Physics and Rigidbodies ###
1. How to access a rigid body in Unity 2017.
2. Using `AddRelativeForce()`.
3. Adjusting mass to get our ship hovering!

### 9b Coordinate System Handedness ###
1. Some things in 2D and 3D have handedness.
2. This is important when making computer games (and drugs).
3. How to use your hands to predict rotations.

### 10 Using Time.deltaTime ###
1. Using a "Play Mode Tint".
2. How to make things frame-rate independent.
3. Using 'Time.deltaTime' to predict frame time.
4. Getting our ship rotating in space.

### 10b Instructor Hangout 3.1 ###
1. Why Git rather than Unity Collab (Jason).
2. Clarifying the handedness rule finger order.
3. Struggling SourceTree on Mac? Forum (Frank).
4. How to re-centre pivot point on rocket (Rory).
5. Adding box collider to odd shaped rocket (Andy).
6. Adding [Prefix] to Q&A question and comments.
7. Mad How Disease, and that 1000y old text!

### 11 Adding A Touch Of Audio ###
1. There's an Audio Listener on the Main Camera.
2. An Audio Source component makes sounds.
3. How to create and attach an Audio Clip.
4. Making sounds when the rocket thrutsts.

### 12 Resolving Movement Bugs ###
1. A minor code refactor.
2. Update our ship prefab.
3. Create new gameplay platforms.
4. Use Rigid Body Constraints.
5. Using `rigidBody.freezeRotation = true`
6. Adding some Drag to our ship.

### 13 Using SerializeField vs public ###
1. Multiply a vector by a float to change length.
2. `SerializeField` vs `public` to expose to Inspector.
3. Creating design "levers".
4. Tweaking our rocket movement.

### 14 Tagging Game Objects As Friendly ###
1. The pros and cons of using tags in Unity.
2. How to use `OnCollisionEnter()`.
3. Differentiating between collisions.

### 15 Basic Level Design ###
1. Tweak our camera to suit our design intention.
2. Design a simple game moment to form the basis of our level.
3. Add a backdrop.

### 16 Design Levers And Tuning ###
1. What design levers do we currently have at our disposal?
2. Some examples of extreme tuning.

### 17 Making A Second Level ###
1. Improving the look of our current level.
2. Creating a new scene to create a new level.

### 18 Prefabs In Detail ###
1. Understanding what happens when a new prefab is created.
2. Exploring when an instance gets changed if a prefab is updated.
3. Adding a landing pad prefab.

### 19 Level Loading & Scene Management ###
1. How to add scenes to the build order.
2. About the build index vs the scene name.
3. Why we need `using UnityEngine.SceneManagement`.
4. Using `SceneManager.LoadScene()`

### 20 Invoke() As A Coroutine Warm-up ###
1. How to fix scene getting dark on level load.
2. Creating an `enum` for our player state.
3. Using Unity's `Invoke()` to delay load.

### 21 Playing Multiple Audio Clips ###
1. You don't need a default audio clip on a source.
2. Use `[SerializeField] AudioClip clipName` to expose a clip.
3. Use `audioSource.PlayOneShot(clipName)` to play.
4. How to handle multiple audio clips.

### 22 Introducing Particle Effects ###
1. What a particle effect is.
2. How we designate which effect to play.
3. Using `ParticleSystem.Play()` to trigger effect.

### 23 Moving Platform Pattern ###
1. Using `[DisallowMultipleComponent]` attribute.
2. Using `[Range(0,1)]` attribute.
3. A pattern for moving platforms.

### 24 Mathf.Sin() For Movement Cycles ###
1. How to initialise a `Vector3`.
2. Using `Mathf.Sin()` for oscillation.
3. Getting your offsets right.
4. Making thrust frame-rate independent.

### 25 Protecting Against NaN ###
1. Use `Mathf.Epsilon` for floats.
2. Tidy code.
3. Remember our Discord chat server.

### 26 Organise Your Assets ###
1. Create new folders within our Assets directory.
2. Create new layout to help visualise all our assets.
3. Manage our hierarchy by using empty Game Objects.
4. Discover and address prefab linking issues.

### 27 Light Your Scene ###
1. Understand all of the lights currently impacting your scene.
2. Add point light and spotlight to your scene.
3. Add light to your player object.

### 28 Nested Prefab Joy ###
1. Challenge - understand how nested prefabs work using our rocket ship.
2. How Prefabs are copied as game objects when nested under a prefab.
3. Solution is to instantiate which we will cover in the next section.

### 29 Make Game Moments ###
1. Recap of all the design levers we now have at our disposal.
2. Examples of a number of game moments and level layouts.
3. Level flow options.
4. Challenge to capture your game moment using screen capture software and share.

### 30 Debug Keys & Builds ###
1. What debug keys are.
2. Why they are useful.
3. Setup debug keys to ignore collisions, and immediately load next level.
4. Using `Debug.isDebugBuild` to keep debug keys out of final player build.

### 31 Looping Through Levels ###
1. Use `SceneManager.GetActiveScene().buildIndex` to get current Scene in Unity 2017
2. `SceneManager.sceneCountInBuildSettings` to count scenes in build settings.
3. Why we can't yet record total levels won.

### 32 Sharing With Teaser Video ###
1. More details about build order.
2. Sharing with a teaser video.
3. Using OBS to record your teaser.

### 33 Spit & Polish ###
Note there were some off-screen changes by Rick before this video.
1. This is an open-ended video where we apply bugfixes and improvements.

### 34 Section 3 Wrap-Up ###
1. Great work in this section!
2. We covered a lot of great C#, Unity and Game Design territory this section.
3. Let's push on to the next section of the course.
