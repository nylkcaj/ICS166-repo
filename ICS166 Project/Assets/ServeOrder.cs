using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ServeOrder : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    private Vector3 originalPos;


    private void Awake()
    {
        originalPos = transform.position;
    }

    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
        transform.position = originalPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Customer")
        {
            DoughSpawner.isServed.Invoke();
            Destroy(gameObject);
        }
        else
        {
            transform.position = originalPos;
        }

    }

    
}
