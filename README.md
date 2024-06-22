# AR Spinner Multiplayer Game

Welcome to the AR Spinner Multiplayer Game project! This README will guide you through the process of setting up, developing, and contributing to this Unity-based augmented reality (AR) game. The game features a multiplayer environment where players can interact with AR spinners in real-time.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction

AR Spinner Multiplayer Game is an innovative and interactive game designed using Unity and AR technologies. The game allows players to compete in a multiplayer setting, where each player controls an AR spinner. The goal is to achieve the highest spin speed and maintain it longer than the opponents.

## Features

- **Augmented Reality:** Utilizes AR to bring spinners into the real world.
- **Multiplayer Support:** Play with friends in real-time.
- **Interactive Gameplay:** Spin your AR spinner by interacting with your device.
- **Cross-Platform:** Supports both Android and iOS devices.

## Requirements

- Unity 2020.3 or later
- AR Foundation package
- ARCore XR Plugin for Android
- ARKit XR Plugin for iOS
- Photon Unity Networking (PUN) 2 for multiplayer functionality
- Android or iOS device with AR capabilities

## Installation

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/your-username/AR-Spinner-Multiplayer-Game.git
    cd AR-Spinner-Multiplayer-Game
    ```

2. **Open the Project in Unity:**

    Launch Unity Hub, click on the "Add" button, and select the project folder.

3. **Install Dependencies:**

    Ensure that AR Foundation, ARCore XR Plugin, ARKit XR Plugin, and Photon Unity Networking (PUN) 2 are installed via the Unity Package Manager.

4. **Build Settings:**

    - **Android:** Ensure ARCore is set up and enabled.
    - **iOS:** Ensure ARKit is set up and enabled.

## Usage

1. **Setup AR and Multiplayer:**

    - Configure your AR Foundation settings according to the platform (ARCore for Android, ARKit for iOS).
    - Setup Photon PUN 2 for networking. Create a Photon App ID from the Photon Dashboard and add it to the PhotonServerSettings in Unity.

2. **Run the Game:**

    - Connect your device via USB.
    - Select the appropriate build target (Android or iOS).
    - Build and run the project on your device.

3. **Gameplay:**

    - Point your device to a flat surface to initialize the AR environment.
    - Once the spinner appears, interact with it by swiping on your screen.
    - Invite friends to join the game and compete in real-time.

## Project Structure

- **AR:** Contains AR-related assets and scripts.
- **Photon:** Contains Photon PUN 2 assets and scripts for multiplayer functionality.
- **Scripts:** Contains C# scripts for game logic and AR interactions.
- **Prefabs:** Contains reusable game objects like the AR spinner.
- **Scenes:** Contains the game scenes.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.

Please ensure that your contributions adhere to the project's coding standards and conventions.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions, issues, or suggestions, please open an issue in the repository or contact the project maintainer:

- **Your Name**
- **Email:** chaubao.work@gmail.com
- **GitHub:** [banhsbao](https://github.com/banhsbao)

Enjoy spinning in augmented reality! 🚀

---

**Note:** Replace placeholders like `banhsbao`, `https://github.com/banhsbao`, and any other necessary details with your actual information before using this README.
