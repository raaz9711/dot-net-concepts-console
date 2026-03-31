
public class AFP
{
    // Action                    // () → void
// Action<T>                 // (T) → void
// Action<T1, T2>            // (T1, T2) → void
// // ... up to Action<T1 ... T16>

    Action greet = () => Console.WriteLine("Hello!");

    Action<string> LogMessage = (msg) => Console.WriteLine($"Logging param {msg}");

Action<int,int,int> PrintRoot = (a,b,c) =>
{
    var d = b*b - 4 * a * c;
    if(d == 0)
    {
        var root = ((-1 * b) / 2 * a);
        Console.WriteLine($"equal roots with same value = {root}");
    }
    else if(d > 0)
    {
    var D = Math.Sqrt(d);
    var root1 = (-1 * b + D)/(2*a);
    var root2 = (-1 * b - D)/(2*a);
    Console.WriteLine($"root 1  value = {root1} root 2  value = {root2}");
    }
    else
    {
        Console.WriteLine("Roots are imaginary numbers");
    }
};

// Func<TResult>             // () → TResult
// Func<T, TResult>          // (T) → TResult
// Func<T1, T2, TResult>     // (T1, T2) → TResult
// // Last type param is ALWAYS the return type
// Func Parameter Limit
// Func supports up to 16 input parameters + 1 return type, making it 17 type parameters total.

Func<float> getPi = () => 3.14f;


Func<int ,int,int> Sum = (a,b) => a + b;

Func<string,int> getLength = s => s.Length;


// 🔗 Chaining & Combining
// Action and Func support multicast via +=:

Action log = () => Console.WriteLine("Log A");

Func<int,int> sq = (s) => s*s;

Func<int,int> cube = (s) => s*s*s;

void Execute(Action act)
{
    Console.WriteLine("Start");
    act();
    Console.WriteLine("End");

}


T Transformer<T>(T value,Func<T,T> transformer)
{
    return transformer(value);
}


}