using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoughSpawner : MonoBehaviour
{
    public GameObject newDough;

    public static DoughSpawner main;

    public static UnityEvent isServed = new UnityEvent();

    private void Awake()
    {
        main = this;
        isServed.AddListener(OrderServed);
    }

    public void OrderServed()
    {
        Instantiate(newDough);
    }
}
