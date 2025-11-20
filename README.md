# Route 404: Data Packet Adventure

A hyper-casual mobile game where players control a data packet navigating through a network to reach the target router while avoiding interceptors and managing interferences.

## Overview

Route 404 is a level-based mobile arcade game that brings computer networking concepts to life through engaging gameplay. Players guide a data packet through digital highways, dodging threats and overcoming network obstacles in a race against time to deliver critical information.

## Target Audience

- **Casual Mobile Gamers**: Players seeking quick, engaging gameplay sessions.
- **Tech Enthusiasts & Cybersecurity Fans**: Those interested in networking concepts presented interactively.
- **General Audience**: Easy-to-learn mechanics accessible to players of all ages.

## Key Features

### Gameplay Mechanics

- **Realistic Network-Themed Obstacles**:
  - Interferences: Weaken packet life and simulate signal noise.
  - Interceptors: Cause packet loss, simulating security threats.
- **Progressive Challenges**: Each level represents different network environments (LAN, WAN, Internet Backbone) with increasing difficulty.
- **Simple Controls**: Mobile-optimized swipe mechanics designed for one-handed play.

### Advanced Networking Features (Educational Mechanics)

This project integrates core Computer Networks concepts into gameplay mechanics:

- **Encryption System**:
  - Mechanic: Encrypt packets to resist interceptors.
  - Trade-off: Reduced speed or increased packet size vs. immunity to capture.

- **Packet Headers**:
  - Mechanic: Attach headers for security or routing efficiency.
  - Trade-off: Heavier packet movement (latency simulation).

- **Data Fragmentation & Reassembly**:
  - Mechanic: Breakdown of packets into smaller chunks to navigate narrow bandwidths, merging at reassembly nodes.
  - Risk: Loss of individual chunks results in data corruption.

- **Time Division Multiplexing (TDM)**:
  - Mechanic: Time-slots where the packet can only move during specific windows.

- **Frequency Division Multiplexing (FDM)**:
  - Mechanic: Frequency channels provide different path options (lanes) to avoid congestion.

## Story and Setting

### The Story

In a vast digital landscape, a lone data packet encounters a critical mission—to deliver vital information from one router to another without being lost or corrupted. The network is riddled with interferences that drain energy and interceptors that threaten to erase data.

### The World

A stylized representation of computer networks featuring glowing data highways, futuristic neon-lit pathways, and environments ranging from local LANs to vast internet backbones.

## Controls

| Action | Control Input |
|--------|---------------|
| Change Route | Swipe Left / Right |
| Speed Boost | Tap & Hold |
| Select Channel (FDM) | Swipe Up / Down |

## Technical Stack

- **Engine**: Unity (2022 LTS or higher)
- **Language**: C#
- **Primary Platform**: Android
- **Secondary Platform**: iOS (Planned)

### Key Technologies

- Unity NavMesh for pathfinding
- Particle Systems for visual effects
- Mobile Touch Input System

## Project Structure

```
Route404/
├── Assets/
│   ├── Scripts/
│   │   ├── Player/
│   │   ├── Enemies/
│   │   ├── Managers/
│   │   └── Utilities/
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Materials/
│   ├── Textures/
│   └── Audio/
├── ProjectSettings/
├── Packages/
└── README.md
```

## Getting Started

### Prerequisites

- Unity 2022.3 LTS or higher
- Android SDK (for mobile builds)
- Git

### Installation

1. Clone the repository:
```bash
git clone https://github.com/YOUR-USERNAME/Route404.git
cd Route404
```

2. Open in Unity:
   - Launch Unity Hub.
   - Click "Add project from disk".
   - Select the Route404 folder.

3. Run the game:
   - Open Scenes/MainMenu.
   - Press the Play button in the Unity Editor.

### Building for Android

1. Switch platform: File > Build Settings > Android > Switch Platform.
2. Configure player: Edit > Project Settings > Player > Android Settings.
3. Build APK: File > Build Settings > Build.

## Roadmap

### Phase 1: Core Development (Completed)
- [x] Basic player movement
- [x] Obstacle system
- [x] Level progression

### Phase 2: Advanced Features (In Progress)
- [ ] Encryption mechanic
- [ ] Header system
- [ ] Data fragmentation
- [ ] TDM/FDM mechanics

### Phase 3: Polish & Release (Planned)
- [ ] Sound effects and music
- [ ] Performance optimization
- [ ] Tutorial system
- [ ] Google Play Store release

## Development Team

**University**: FAST NUCES, Lahore  
**Course**: Computer Networks (Spring 2025)  
**Instructor**: Ms. Saba Ghani

| Name | Roll No. | Role |
|------|----------|------|
| Aiman Ahzaz | 22L-7830 | Developer |
| Ali Imran | 22L-7854 | Developer |
| Mohammad Usama | 22L-7913 | Developer |
| Manal Bukhari | 22L-7917 | Developer |
| Zaman Rafiq | 22L-7955 | Developer |

## Contributing

Contributions are welcome. Please follow these guidelines:

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

## License

This project is developed as part of academic coursework at FAST NUCES.

## Acknowledgments

- Ms. Saba Ghani for project guidance and mentorship.
- Unity Community for technical assistance.
- Visual References: Data Wing, #DRIVE, Subway Surfers.
