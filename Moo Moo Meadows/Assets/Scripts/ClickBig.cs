using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBig : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        this.transform.localScale = new Vector2(3, 3);
       // this.transform.position = new Vector2(Screen.width / 2, Screen.height / 2);
    }
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log(this.transform.lossyScale);
    //    this.transform.localScale = new Vector3(3, 3);

    //}

    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    Debug.Log(this.transform.lossyScale);
    //    this.transform.localScale = new Vector3(1, 1);
    //}
}
