# LoremGen 📝

## Introduction 🌟
LoremGen is a lightweight, easy-to-use utility written in .NET for generating Lorem Ipsum text.
It can produce individual words and paragraphs of pseudo-Latin text commonly used as placeholder text in publishing, graphic design, and development.

## Features 🚀
- Generate any number of Lorem Ipsum words. 📋
- Generate any number of Lorem Ipsum paragraphs with a random number of words. 📄
- Seed-based generation for repeatable results. 🔁

## Getting Started 🏁

### Requirements 📋
- .NET compatible environment 💻

### Installation 🔧
This utility is part of a .NET application. To utilize its functionalities, ensure you include it within your .NET project.

### Usage 🛠️
LoremGen can generate words and paragraphs with customizable lengths and an optional seed for repeatable results.

#### Generating Words 📝
To generate a specific number of Lorem Ipsum words:

```csharp
const int totalWords = 5;
var words = LoremGen.LoremGen.Words(totalWords);
Console.WriteLine("Generated words: {0}", string.Join(" ", words));
```

#### Generating Paragraphs 📄
To generate a specific number of Lorem Ipsum paragraphs:

```csharp
const int totalParagraphs = 1;
var paragraph = LoremGen.LoremGen.Paragraphs(totalParagraphs).First();
Console.WriteLine("Generated paragraph: {0}", paragraph);
```

### Custom Seed 🔑
Both `Words` and `Paragraphs` methods accept an optional `seed` parameter to generate repeatable text sequences.

## Contributing 🤝
Contributions to LoremGen are welcome! Please submit any bugs, suggestions, or improvements through the project's issue tracker or submit a pull request.

## License 📄
LoremGen is licensed under the MIT License. For more details, please look at the LICENSE file at the root of the project.
