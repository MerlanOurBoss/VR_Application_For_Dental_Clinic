# Stamo — VR Dental Anesthesia Simulator

**Stamo** is a Unity-based VR training application for practicing local anesthesia techniques in dentistry. The user stands in a virtual dental office, picks up a cartridge syringe, inserts the needle at a target point on a patient model, delivers the anesthetic, and earns points for each completed injection.

## Features

- 15 injection points grouped into 6 types of anesthesia.
- A grabbable syringe with a readout of the remaining volume in milliliters.
- On-model guidance: injection point markers and a panel listing the techniques in Russian and English.
- The syringe locks at the required angle when the needle reaches a point.
- Scoring and a sound cue on each successful injection.
- Syringe sterilization, cartridge replacement, and syringe disposal in a bin.
- Physics-based hands that collide with objects in the scene.
- The patient model opens its mouth when the player approaches.

## Anesthesia techniques

| Anesthesia | Points | Score per point |
|---|:---:|:---:|
| Infiltration anesthesia | 6 | 50–100 |
| Incisive nerve block | 1 | 100 |
| Posterior Superior Alveolar Nerve Block (tuberal) | 2 | 100 |
| Nasopalatine nerve block | 2 | 75 |
| Mental nerve block | 2 | 75 |
| Inferior Alveolar Nerve Block (mandibular; palpation and apodactylic methods) | 2 | 200 |

The maximum total for completing all points is **1450**.

## How an injection works

1. Press **Add syringe** on the panel to create a syringe and a cartridge.
2. Pick up the syringe and bring it into contact with the cartridge, which then installs into the syringe.
3. Move the needle to the marker of the desired point. The syringe locks into the correct position.
4. Hold the activate button to deliver the anesthetic. The point counts once more than 0.4 ml has been delivered.
5. A full cartridge holds 2.0 ml. If 0.4 ml or less remains in the syringe, a **Not enough** message appears and the cartridge must be replaced.

## Controls

The application uses VR headset controllers.

| Action | Control |
|---|---|
| Pick up an object | Controller grip (XR Grab) |
| Deliver anesthetic | Activate while holding the syringe (the trigger by default in XR Interaction Toolkit) |
| Sterilize the syringe | **B** button |
| Refill the cartridge | **A** button |
| Move | Controller thumbstick |
| Exit | **Exit** button on the panel |

## Tech stack

| Component | Version |
|---|---|
| Unity | 2021.3.16f1 (LTS) |
| Universal Render Pipeline | 12.1.8 |
| XR Interaction Toolkit | 2.0.4 |
| XR Plugin Management | 4.2.0 |
| OpenXR Plugin | 1.5.3 |
| Oculus XR Plugin | 3.2.2 |
| Post Processing | 3.2.2 |
| TextMeshPro | 3.0.6 |

UniGLTF is included in the project for importing glTF models.

## Requirements

- Unity **2021.3.16f1** with the **Android Build Support** module (Android SDK, NDK, and OpenJDK).
- An Oculus/Meta Quest headset: Oculus Quest support is enabled in the OpenXR settings for Android.
- Android 7.0 or later (API 24; target API 30), ARM64 architecture, IL2CPP backend.

## Getting started

```bash
git clone https://github.com/MerlanOurBoss/VR_Application_For_Dental_Clinic.git
```

1. Open the project folder in Unity Hub with editor version 2021.3.16f1. The first import may take a while.
2. Open the scene `Assets/Scenes/SampleScene.unity`, the only scene in the build.

### Building for Quest

1. Enable developer mode on the headset and connect it to your computer via USB.
2. In **File → Build Settings**, select the **Android** platform and click **Switch Platform**.
3. In **Project Settings → Player → Publishing Settings**, enter the keystore and alias passwords, or create your own keystore. The project is configured to use `user.keystore` with the alias `merlan`.
4. Click **Build And Run**.

## Project structure

```text
Assets/
├── Scenes/          # SampleScene and baked lighting
├── Scripts/         # Simulator logic
├── Prefabs/         # Syringe, cartridge, controllers, injection point markers (Dots)
├── Model/           # Office, patient, and instrument models, animations
├── Materials/       # Materials
├── Sound/           # Sound effects
├── AllSkyFree/      # Skyboxes
└── Custom asstest/  # XR settings, Oculus Hands Physics, UniGLTF, fonts
```

### Main scripts

| Script | Purpose |
|---|---|
| `SyringeInput` | Handles all injection points: syringe position, volume checks, scoring |
| `Injection` | Plunger movement and anesthetic consumption |
| `SterilizeSyringe`, `SterilizeField` | Syringe sterilization and volume reset |
| `AddAmpula` | Installs the cartridge in the syringe |
| `CreateSyringe` | Creates a new syringe and cartridge |
| `Syringe` | Shows the marker of the selected injection point |
| `ColliderFreeze` | Completes a point: hides the marker and updates its panel icon |
| `ScoreImplementiing` | Tracks and displays the score |
| `MakeInjection` | Highlights the gum on needle contact |
| `HeadOpenMouth` | Opens the patient's mouth when the player approaches |
| `LeftHandMove` | Animates the left hand when the syringe approaches |
| `HandPhysics` | Makes the physics hands follow the controllers |
| `CharacterControl` | Player movement and gravity |
| `Bin` | Syringe disposal |
| `ExitButton` | Exits the application |

## Author

[MerlanOurBoss](https://github.com/MerlanOurBoss)
