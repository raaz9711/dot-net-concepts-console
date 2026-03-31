#### Learning Daily
**Day 1** 

Concept : 22/03/2026

- Action | Fire And Forget
- Func | Must return something
- Predicate | boolean check
- Action and Func support multicast via +=: 

```
T Transformer<T>(T value,Func<T,T> transformer)
{
    return transformer(value);
}
```

Concept : 31/03/2026

- Properties, Indexers, Operator Overloading

```
public class Inventory
{
    private string[] _items = new string[10];

    // indexer definition
    public string this[int index]
    {
        get => _items[index];
        set => _items[index] = value;
    }
}
```