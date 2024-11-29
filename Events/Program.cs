using System;
// Define a delegate (method signature) that will be used for the event
public delegate void NotifyEventHandler(string message);

class Program
{
    // Define an event using the delegate
    public static event NotifyEventHandler OnNotify;

    static void Main(string[] args)
    {
        // Subscribe to the event with a handler method
        OnNotify += NotifyHandler;

        // Trigger the event
        TriggerEvent("Hello, this is an event-driven notification!");

        // Unsubscribe from the event
        OnNotify -= NotifyHandler;

        // Trigger the event again (this time, no handler will be called)
        TriggerEvent("This message won't be handled as we unsubscribed.");
    }

    // Method that triggers the event
    public static void TriggerEvent(string message)
    {
        // Check if there are any subscribers before triggering the event
        OnNotify?.Invoke(message);
    }

    // Handler method that matches the delegate signature
    public static void NotifyHandler(string message)
    {
        Console.WriteLine("Event triggered: " + message);
    }
}