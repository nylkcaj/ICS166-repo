using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Assemble : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dough")
        {
            gameObject.transform.parent = collision.gameObject.transform;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
