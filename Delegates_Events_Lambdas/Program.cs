// This is our custom delegate definition. 
// A delegate is a type that can reference methods with a specific signature. 
// In this case, it takes a single string parameter and returns void (no return value).
public delegate void PrintMessage(string message);

class Delegate
{
    public static void Main(string[] args)
    {
        // Demonstrating how to use a built-in method with a delegate.
        // We can assign any method (in this case, Console.WriteLine) that matches the delegate's signature.
        // Console.WriteLine is a method that takes a string as a parameter and returns void (matching the PrintMessage delegate signature).
        
        // Here, print1 is a delegate instance that is assigned to Console.WriteLine.
        PrintMessage print1 = Console.WriteLine;
        
        // Now, when we call print1("Nice Learning"), it invokes the Console.WriteLine method.
        // This is equivalent to calling Console.WriteLine("Nice Learning").
        print1("Nice Learning");

        // Demonstrating how to use a custom method with a delegate.
        // print2 is another delegate instance, but this time it points to a custom method named PrintMessageConsole.
        // PrintMessageConsole is a method that also takes a string parameter and returns void, matching the PrintMessage delegate signature.
        
        PrintMessage print2 = PrintMessageConsole; // print2 now points to the PrintMessageConsole method
        
        // When we invoke print2 with a string, it internally calls the PrintMessageConsole method.
        // This is equivalent to calling PrintMessageConsole("Again Nice Learning").
        print2("Again Nice Learning");





        // Defining a lambda expression and assigning it to a variable
        // 'Func<int, int, int>' specifies a delegate type that takes two integers (int, int) and returns an integer (int).
        // The lambda expression '(a, b) => a + b' defines the functionality: adding the two integers together.
        Func<int, int, int> add = (a, b) => a + b;

        // Calling the lambda expression by passing two integers (3 and 4) as arguments.
        // The lambda expression will add these numbers together and return the result (7).
        // The result is then passed to Console.WriteLine to display the output.
        Console.WriteLine(add(3, 4));  // Outputs: 7

        // Subscribe to the event with a lambda expression that will be called when the event is triggered
        OnNotify += (msg) => Console.WriteLine($"Event Triggered: {msg}");

        // Trigger the event, which will invoke all the subscribed handlers
        TriggerEvent();
    }

    // This is our custom method that matches the delegate signature.
    // It takes a string parameter and prints it to the console.
    // The method can be used by any delegate of type PrintMessage because it matches the signature (string -> void).
    public static void PrintMessageConsole(string message)
    {
        Console.WriteLine(message); // Outputs the message to the console.
    }


    // Declare a delegate that matches the signature of event handlers
    // This delegate takes a string parameter and returns void.
    public delegate void NotifyEventHandler(string message);

    // Declare the event based on the delegate
    public static event NotifyEventHandler OnNotify;

    // Define a method to trigger the event
    public static void TriggerEvent()
    {
        // Safely invoke the event if there are subscribers
        OnNotify?.Invoke("User logged in!");
    }
}

