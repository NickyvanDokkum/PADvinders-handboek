using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBig : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.transform.lossyScale);
        this.transform.localScale = new Vector3(3, 3);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(this.transform.lossyScale);
        this.transform.localScale = new Vector3(1, 1);
    }
}
