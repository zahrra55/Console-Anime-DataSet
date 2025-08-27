# Console-Anime-DataSet

A simple C# console application demonstrating JSON-based data handling for anime records.

---

## Description

This project showcases a basic console app built using .NET 8 and C# 12. It allows you to manage a local JSON dataset (`animes.json`), offering the ability to load, view, add, and search anime entries. Ideal for learning or prototyping file I/O and JSON serialization with **System.Text.Json**.

---

## Features

- Load and parse anime data from `animes.json`
- Display all anime records in the console
- Add a new anime (prompted via console)
- Search anime by name
- JSON serialization/deserialization using `System.Text.Json`

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- C# 12 compatible environment (included in .NET 8)

---

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/zahrra55/Console-Anime-DataSet.git
   cd Console-Anime-DataSet


2. **Build the project**

   ```bash
   dotnet build
   ```

3. **Run the app**

   ```bash
   dotnet run --project AnimeApp.csproj
   ```

4. **Interact via console**

   * Choose to view, add, or search anime entries
   * Data is read from and saved back to `animes.json`

---

## Project Structure

```
/
├── Anime.cs           – Defines the Anime model
├── JsonHandler.cs     – Handles JSON file operations
├── Program.cs         – Main entry point & CLI logic
├── animes.json        – Sample dataset file
├── AnimeApp.sln       – Visual Studio / .NET solution
└── AnimeApp.csproj    – Project configuration file
```

---

## License

This project is released under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

## Contributing

Contributions are welcome! Feel free to:

* Improve search/filtering capabilities
* Add support for more complex queries or data validations
* Enhance CLI user experience

---

## Summary

A lightweight, educational console application for managing anime entries via JSON. Great for experimenting with modern C# and .NET features, file I/O, and serialization.

---

