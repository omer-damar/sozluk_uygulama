# English–Turkish Vocabulary Learning App

A collaborative desktop application designed to make vocabulary learning measurable and engaging. The app combines personal vocabulary management, a six-stage spaced-repetition system, progress analytics and word games in a C# Windows Forms interface.

## Key Features

- **User accounts:** registration, sign-in and password recovery
- **Vocabulary management:** add English words, Turkish meanings, example sentences and related images
- **Six-stage learning cycle:** mastered answers are reviewed after 1 day, 1 week, 1 month, 3 months, 6 months and 1 year
- **Adaptive quizzes:** an incorrect answer restarts that word's learning cycle
- **Custom study settings:** configure how many new words appear in a session
- **Progress analytics:** review learning performance by category and print reports
- **Learning games:** reinforce vocabulary with Wordle and Word Chain

## Tech Stack

- **Language:** C#
- **Desktop UI:** Windows Forms
- **Runtime:** .NET Framework 4.7.2
- **Database:** Microsoft SQL Server
- **Data access:** ADO.NET / System.Data.SqlClient

## Project Structure

- `Form*.cs` — application screens and UI workflows
- `DBManager.cs` — SQL Server connection management
- `Oturum.cs` — session-related state
- `Ayarlar.cs` — study preferences and application settings
- `database/` — database backup files used by the application

## Getting Started

### Requirements

- Windows
- Visual Studio with the **.NET desktop development** workload
- .NET Framework 4.7.2
- Microsoft SQL Server and SQL Server Management Studio

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/omer-damar/sozluk_uygulama.git
   ```

2. Open `İngilizce Türkçe Sözlük/Proje Deneme Yanılma.sln` in Visual Studio.
3. Restore the database backups in the `database/` directory using SQL Server Management Studio.
4. Open `DBManager.cs` and replace the local SQL Server instance name in the connection strings with your own instance.
5. Confirm that the restored databases are named `kullanici_bilgi` and `sozluk_vocabulary`.
6. Build and run the project from Visual Studio.

## Learning Model

Each word progresses through six successful reviews. Reviews are scheduled at increasingly longer intervals: **1 day → 1 week → 1 month → 3 months → 6 months → 1 year**. A wrong answer resets the progress for that word, helping reinforce long-term recall.

## Notes

This project was developed as a collaborative academic application. The current database configuration targets a local SQL Server instance and should be updated before running the project on another machine.

## Contributors

See the repository's [contributors page](https://github.com/omer-damar/sozluk_uygulama/graphs/contributors) for the full collaboration history.
