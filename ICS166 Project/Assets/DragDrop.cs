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
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");

        Vector3 mousePos = Input.mousePosition;
        Vector3 itemPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

        itemTransform = Instantiate(foodItem, itemPosition, Quaternion.identity).GetComponent<Transform>();

    }

}
