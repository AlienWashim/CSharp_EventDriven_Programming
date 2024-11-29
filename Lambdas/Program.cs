class Lambda
{
    public static void Main(string[] args)
    {
        // Defining a lambda expression and assigning it to a variable
        // 'Func<int, int, int>' specifies a delegate type that takes two integers (int, int) and returns an integer (int).
        // The lambda expression '(a, b) => a + b' defines the functionality: adding the two integers together.
        Func<int, int, int> add = (a, b) => a + b;

        // Calling the lambda expression by passing two integers (3 and 4) as arguments.
        // The lambda expression will add these numbers together and return the result (7).
        // The result is then passed to Console.WriteLine to display the output.
        Console.WriteLine(add(3, 4));  // Outputs: 7
    }
}

