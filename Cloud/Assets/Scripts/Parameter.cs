using UnityEngine;
using System.Collections;

public class Parameter<T> : ITitle
{
    [SerializeField]
    private T value;
    
    [SerializeField]
    private string title;

    public string GetTitle()
    {
        return title;
    }

    public T GetValue()
    {
        return value;
    }

    public Parameter(string title, T value)
    {
        this.value = value;
        this.title = title;
    }
}
