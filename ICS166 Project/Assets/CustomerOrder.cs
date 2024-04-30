using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrder : MonoBehaviour
{
    public int reward = 10;
    private bool isOrderFulfilled = false;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food") && !isOrderFulfilled)
        {
            isOrderFulfilled = true;
            Destroy(other.gameObject);

        }

    }
}
