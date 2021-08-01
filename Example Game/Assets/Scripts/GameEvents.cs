using UnityEngine;
using UnityEngine.Events;

public static class GameEvents
{
    public static Event1 event1Name = new Event1();

}

public class Event1 : UnityEvent<Event1Data>{}
public class Event1Data{
    public float data;
    public Event1Data (float data) {
        this.data = data;
    }
}