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