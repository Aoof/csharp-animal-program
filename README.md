# C# Animal Program

A small console program that practises classes, inheritance and input validation in C#. Written for a course at Collège LaSalle (February 2025).

## What it does
1. Asks for a dog's name, age and breed, and keeps asking until each value is valid (age must be 0 to 50).
2. Creates a `Dog` and prints its details, including a bark that depends on the breed (Husky, Bulldog or any other).
3. Copies the dog with a copy constructor and prints the copy.

## Concepts shown
- A base class `Animal` and a derived class `Dog`
- Properties with validation in their setters
- Default, parameterized and copy constructors, chained with `base(...)`
- Overriding `ToString()`

## Run it
Requires the [.NET 9 SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/Aoof/csharp-animal-program.git
cd csharp-animal-program
dotnet run
```

## Example
```
Please fill out the following information for your dog:
Enter Dog Name: Luna
Enter Dog Age: 3
Enter Dog Breed: Husky
Dog Details:
Animal Name: Luna, Age: 3, Breed: Husky, Sound: Awoo! 🐺
```

## Author
Abdulrahman (Aoof) Mousa · [aoof.ca](https://aoof.ca)
