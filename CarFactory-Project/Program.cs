using CarFactory_Project;
using System.ComponentModel;

bool exitProgram = false; // Flag toindicate if the program should exit
List<Car> carList = new List<Car>(); // List to hold created cars

while (!exitProgram)
{
    ValidEntry(); // Prompt the user for input and create cars if needed
}

// Display the list of cars before exiting the program
DisplayList(); // Display the list of cars

// Display a farewell message before exiting the program
Console.WriteLine("Thank you for using the Car Factory Program! Goodbye!");

    // Function to prompt user for car creation and handle invalid inputs
    void ValidEntry()
{
    bool isValidInput = false;
    while (!isValidInput)
    {
        try
        {
            Console.WriteLine("Do you want create a car ? (y/n)"); // Ask if the user wants to create a car
            string userInput = Console.ReadLine().ToLower(); // Read user input and convert to lowercase
            if (userInput == "y")
            {
                Console.WriteLine("Car creating...");
                CarCreation();  // Call function to create a car
                isValidInput = true;
            }
            else if (userInput == "n")
            {
                Console.WriteLine("Ending...");
                exitProgram = true; // Set flag to exit the program
                isValidInput = true;
            }
            else
            {
                throw new InputException("You entered a invalid input. Please enter y or n"); // Handle invalid input
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

// Function to create a new car and handle creation of multiple cars
void CarCreation()
{
CreateNewCarAgain:

    // Create a new car object and set its properties
    Car car = new Car
    {
        SerialNumber = GetValidIntInput("Enter the serial number : "), // Get valid serial number
        Brand = GetStringInput("Enter the car brand : "), // Get car brand
        Model = GetStringInput("Enter the car model : "), // Get car model
        Color = GetStringInput("Enter the car color : "), // Get car color
        DoorCount = GetValidIntInput("Enter the door count : "), // Get valid door count
    };

    carList.Add(car); // Add the crated car to the list

    bool isValidInput = false;
    while (!isValidInput)
    {

    
    Console.WriteLine("Do you want to create another car ? (y/n)"); // Ask if the user wants to create another car
        string userInput = Console.ReadLine().ToLower(); // Read user input and convert to lowercase
        if (userInput == "y")
        {
            isValidInput = true;
            goto CreateNewCarAgain; // If user wants to create another car, loop back to car creation
        }
        else if (userInput == "n") 
        {
            isValidInput = true;
            exitProgram = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'"); // Handle invalid input
        }
}

}

// Function to get string input from the user
string GetStringInput(string text)
{ 
    Console.WriteLine(text); // Prompt user with provided text
    return Console.ReadLine(); // Return user input
}

// Function to get valid integer input from the user
int GetValidIntInput(string text)
{
    int value;

RetryInput:
    Console.WriteLine(text); // Prompt user with provided text
    string userInput = Console.ReadLine(); // Read user input

    if (int.TryParse(userInput, out value))
    {
        return value; // Return valid integer value
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number."); // Handle invalid input
        goto RetryInput; // Retry input if invalid
    }

}

// Function to display the list of cars
void DisplayList()
{
    Console.WriteLine("List of cars : "); // Header for the list
    foreach (var cars in carList)
    {
        // Display car details
        Console.WriteLine($"Production Date : {cars.ProductDate}\nSerial Number : {cars.SerialNumber}\nBrand : {cars.Brand}\nModel : {cars.Model}\nColor : {cars.Color}\nDoor Count : {cars.DoorCount}\n");
    }
}
