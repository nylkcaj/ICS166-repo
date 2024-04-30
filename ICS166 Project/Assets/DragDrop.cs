using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject foodItem;


    private RectTransform rectTransform;
    private Transform itemTransform;
    private GameObject currentItem;
    private Collider2D foodCollider;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        Vector3 mousePos = Input.mousePosition;
        Vector3 itemPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

        itemTransform.transform.position = itemPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        foodCollider.enabled = true;

        Debug.Log("Collider.enabled = " + foodCollider.enabled);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

        Vector3 mousePos = Input.mousePosition;
        Vector3 itemPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));


        currentItem = Instantiate(foodItem, itemPosition, Quaternion.identity);

        itemTransform = currentItem.GetComponent<Transform>();

        foodCollider = currentItem.GetComponent<Collider2D>();

        foodCollider.enabled = false;

        Debug.Log("Collider.enabled = " + foodCollider.enabled);
    }

}
