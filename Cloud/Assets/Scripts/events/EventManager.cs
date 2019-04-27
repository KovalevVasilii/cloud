using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;

public class EventManager
{
    [SerializeField]
    private List<Event> eventPull = new List<Event> ();

    [SerializeField]
    protected const double EVENT_THRESHOLD_DAYS = 3;
    [SerializeField]
    protected const double EVENT_THRESHOLD_MINUTES = 60 * 24 * EVENT_THRESHOLD_DAYS;
    [SerializeField]
    private const double PROBABILITY_INCREMENT = 100 / EVENT_THRESHOLD_MINUTES;
 
    [SerializeField]
    private double PROBABILITY_VALUE = 0;

    [SerializeField]
    protected World world;

    public Thread worker;

    public EventManager(World world_)
    {
        world = world_;
        worker = new Thread(Work);
        worker.Start(world);
    }

    private void Work(object obj)
    {
        World world_ = (World)obj;
        while (true)
        {

        }
    }



    public void Start()
    {
        
    }

}
