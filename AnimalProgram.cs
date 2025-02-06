
class Animal {
    private string name;
    private int age;

    public string Name {
        get { return name; }
        set {
            if (value != null && value.Length > 0) {
                name = value;
            } else {
                Console.WriteLine("Invalid name");
                name = "Unknown";
            }
        }
    }

    public int Age {
        get { return age; }
        set {
            if (value >= 0 && value <= 50) {
                age = value;
            } else {
                Console.WriteLine("Invalid age");
                age = 0;
            }
        }
    }

    public Animal() {
        name = "Unknown";
        age = 0;
    }

    public Animal(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public Animal(Animal animal) {
        name = animal.name;
        age = animal.age;
    }

    public override string ToString() {
        return "Animal Name: " + name + ", Age: " + age;
    }
}

class Dog : Animal {
    private string breed;

    public string Breed {
        get { return breed; }
        set {
            if (value != null && value.Length > 0) {
                breed = value;
            } else {
                Console.WriteLine("Invalid breed");
                breed = "Unknown";
            }
        }
    }

    public Dog() : base() {
        breed = "Unknown";
    }

    public Dog(string name, int age, string breed) : base(name, age) {
        this.breed = breed;
    }

    public Dog(Dog dog) : base(dog) {
        breed = dog.breed;
    }

    public override string ToString() {
        return base.ToString() + ", Breed: " + breed + ", Sound: " + BarkSound();
    }

    public string BarkSound() {
        switch (breed) {
            case "Husky": return "Awoo! 🐺";
            case "Bulldog": return "Woof! 🐶";
            default: return "Bark!🐕";
        }
    }
}

class AnimalProgram {
    static void Main() {
        string name, breed;
        int age;

        Console.WriteLine("Please fill out the following information for your dog:");

        while (true) {
            Console.Write("Enter Dog Name: ");
            name = Console.ReadLine() ?? "";
            if (name != null && name.Length > 0) {
                break;
            }
            Console.WriteLine("Invalid name");
        }

        while (true) {
            Console.Write("Enter Dog Age: ");
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out age) && age >= 0 && age <= 50)
                break;
            Console.WriteLine("Invalid age");
        }

        while (true) {
            Console.Write("Enter Dog Breed: ");
            breed = Console.ReadLine() ?? "";
            if (breed != null && breed.Length > 0) {
                break;
            }
            Console.WriteLine("Invalid breed");
        }

        Dog dog = new Dog(name, age, breed);
        Console.WriteLine("Dog Details: ");
        Console.WriteLine(dog);

        Dog copy = new Dog(dog);
        Console.WriteLine("Copied Dog Details: ");
        Console.WriteLine(copy);
    }
}