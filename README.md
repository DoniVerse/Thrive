# Thrive - Mental Wellness Desktop Application

A comprehensive mental health and wellness desktop application designed to help users track their mood, practice mindfulness, and maintain their overall well-being through various integrated features.

## Features

### 🎯 Mood Tracking
- Track daily emotions and mood patterns
- Visual mood history with detailed analytics
- Monitor emotional trends over time

### 📝 Personal Journal
- Private digital journal for thoughts and reflections
- Secure storage of personal entries
- Easy-to-use interface for daily writing

### 🧘‍♀️ Wellness Exercises
- Guided meditation sessions
- Yoga and tai chi video tutorials
- Breathing exercises and mindfulness practices
- Pilates workouts for physical wellness

### 🎵 Relaxation Sound Library
- Curated collection of calming soundtracks
- Nature sounds and ambient music
- Built-in media player for seamless playback

### 👤 User Management
- Secure user authentication system
- Personalized profiles and settings
- Data privacy and protection

## Technology Stack

- **Framework**: .NET 8.0 Windows Forms
- **Language**: C#
- **Database**: MySQL/MariaDB
- **UI Components**: Siticone UI Framework
- **Audio**: NAudio library
- **Security**: BCrypt.NET for password hashing
- **Media**: Windows Media Player integration

## Prerequisites

- Windows 10 or later
- .NET 8.0 Runtime
- MySQL/MariaDB Server
- Visual Studio 2022 or Visual Studio Code

## Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/thrive.git
   cd thrive
   ```

2. **Database Setup**
   - Install MySQL/MariaDB on your system
   - Create a database named `thrive`
   - Import the provided SQL schema:
     ```sql
   mysql -u root -p thrive < "thrive (1).sql"
     ```

3. **Configure Database Connection**
   - Update the connection string in `user.cs` if needed:
   ```csharp
   private string connectionString = "server=localhost;database=thrive;user=root;password=;";
   ```

4. **Build and Run**
   - Open the project in Visual Studio
   - Restore NuGet packages
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5)

## Usage

### Getting Started
1. Launch the application
2. Register a new account or login with existing credentials
3. Explore the dashboard to access all features

### Mood Tracking
- Click "Mood Tracker" from the dashboard
- Select your current mood from the available options
- View your mood history in the analytics section

### Journaling
- Access the journal from the dashboard
- Write your thoughts and feelings
- Entries are automatically saved to your profile

### Wellness Exercises
- Navigate to the exercise section
- Choose from available videos (yoga, meditation, tai chi, etc.)
- Follow along with the guided sessions

### Sound Therapy
- Open the media player from the dashboard
- Browse the sound library
- Play relaxing tracks for meditation or focus

## Database Schema

The application uses five main tables:
- `user` - Stores user accounts and authentication data
- `moodtracker` - Records daily mood entries
- `journal` - Saves personal journal entries
- `excerise` - Contains exercise video links
- `sound` - Stores audio file paths for relaxation

## Security Features

- Password hashing using BCrypt
- Input validation for email addresses
- SQL injection protection through parameterized queries
- Secure session management

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Support

For support, please open an issue in the repository or contact the development team.

---

**Thrive** - Your personal companion for mental wellness and self-care.