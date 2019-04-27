using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameters
{
    public Parameter<float> Energy;
    public Parameter<float> Temperature;
    public Parameter<float> Ethernet;
    public Parameter<float> Time;

    public Parameters()
    {
        this.Energy = new Parameter<float>("Energy", 100);
        this.Temperature = new Parameter<float>("Temperature", 20);
        this.Ethernet = new Parameter<float>("Ethernet", 20);
        this.Time = new Parameter<float>("Time", 1);
    }
}
