using UnityEngine;
using System.Collections;

public class Parameter<T> : ITitle
{
    [SerializeField]
    private T value { set; get; }
    
    [SerializeField]
    private string title;

    public string GetTitle()
    {
        return title;
    }

    public Parameter(string title, T value)
    {
        this.value = value;
        this.title = title;
    }
}
