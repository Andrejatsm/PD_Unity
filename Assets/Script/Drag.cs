using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler , IEndDragHandler, IDragHandler
{
    private RectTransform rTransform;
    private Vector2 ogtransform;
    public Canvas canv;

    public GameObject target;
    public GameObject targets;
    public GameObject targets2;

    private void Start()
    {
        rTransform = GetComponent<RectTransform>();
        ogtransform = rTransform.position;
    }

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Izdarits kliksis uz velkama objekta!");
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Uzsakta vilksana!");
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0+rTransform.rect.width/2, Screen.width - rTransform.rect.width/2);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0 + rTransform.rect.height / 2, Screen.height - rTransform.rect.height / 2);

        rTransform.position = mousePosition;
        Debug.Log("x=" + mousePosition.x + " un y=" + mousePosition.y);

    }

    public void OnEndDrag(PointerEventData data)
    {
        if (GetComponent<BoxCollider2D>().bounds.Intersects(target.GetComponent<BoxCollider2D>().bounds))
        {
            target.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
            target.GetComponent<Image>().color = Color.white;
        }
        


        rTransform.position = ogtransform;
        Debug.Log("Objekts atlaists.");
    }


}
