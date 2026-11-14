# VR-Saber-Prototype-Part-2
VR-Saber-Prototype-Part_2
# VR Saber Prototype — Part 2

### Immersive Rhythm-Based VR Game

A virtual reality rhythm game developed using **Unity 6, C# and the XR Interaction Toolkit (XRI)** for the **Meta Quest 2**.

This project was developed as part of Assessment 3 for the Virtual, Augmented and Spatial Computing module at Technological University of the Shannon (TUS).

## Project Overview

VR Saber Prototype expands upon an earlier cube-slicing interaction developed during Assessment 2, transforming it into a complete 90-second VR gameplay experience.

Inspired by *Beat Saber*, players use two motion-tracked virtual sabers to strike approaching cubes, accumulate points and build consecutive hit combinations.

The project explores Human–Computer Interaction (HCI), immersive design and the integration of visual, auditory and haptic feedback.

## Features

- **Dual-controller interaction:** Virtual sabers respond to the player's physical hand movements.
- **Moving targets:** Cubes spawn and travel towards the player.
- **Collision detection:** Successful strikes cause cubes to split into separate pieces.
- **Visual feedback:** Particle sparks appear when cubes are struck.
- **Audio feedback:** Background music and impact sounds accompany gameplay.
- **Haptic feedback:** Controller vibration reinforces successful strikes.
- **Score tracking:** Each successful strike awards 10 points.
- **Combo system:** Consecutive hits increase the combo counter, which resets when a cube is missed.
- **Timed gameplay:** Each session lasts approximately 90 seconds.
- **Results screen:** Displays the final score and highest combo achieved.

## Technologies Used

- Unity 6
- C#
- XR Interaction Toolkit
- OpenXR
- Meta Quest 2
- TextMeshPro
- Unity Particle System
- Unity Physics

## Controls

| Action | Control |
|---|---|
| Move left saber | Left Quest controller |
| Move right saber | Right Quest controller |
| Strike cubes | Swing either saber into an approaching cube |
| View score and combo | In-game display |
| View final results | Automatically displayed at the end of the session |

## Installation and Setup

### Requirements

- Unity 6 with Android Build Support
- XR Interaction Toolkit and OpenXR
- Meta Quest 2 headset
- USB-C connection for headset deployment

### Running the Project

1. Clone or download this repository.
2. Open Unity Hub.
3. Select **Add project from disk** and locate the downloaded project folder.
4. Open the project using a compatible Unity 6 Editor.
5. Open the `SaberGame_MovingCubes` scene from the Assets/Scenes folder.
6. Ensure the Android build target and XR settings are configured for Meta Quest.
7. Connect the headset and deploy the application using Unity's Build and Run functionality.

## Evaluation and Testing

The application was developed through iterative testing in the Unity Editor and directly on the Meta Quest 2.

Testing focused on:

- Controller tracking and collision detection
- Cube spawning and movement
- Visual, audio and haptic feedback
- Score and combo accuracy
- Missed-target detection
- Results-screen visibility
- Android build performance

Development challenges included resolving audio playback problems on the headset, correcting combo-reset behaviour and preventing gameplay interface elements from appearing behind the final results panel.

The completed application was successfully tested on the Meta Quest 2. Evaluation was limited to developer testing rather than external participants.

## Future Improvements

Potential future developments include:

- More accurate synchronisation between cube spawning and musical beats
- Adjustable difficulty levels
- Additional accessibility options
- Further evaluation with external participants

## Author

Harper Alexander

Creative Digital Computing  
Technological University of the Shannon (TUS)

## Project Status

**Completed — Part 2, November 2026**

The Unity source files are included in this repository. The Android APK, demonstration video, project report and evaluation evidence are provided separately as part of the university assessment submission.
