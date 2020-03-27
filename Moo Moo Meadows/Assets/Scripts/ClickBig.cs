using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBig : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public Vector2 middle;
    GameObject gezoomdeKaart;
    [SerializeField] public Transform hands;

    public void OnPointerExit(PointerEventData eventData)
    {
        Destroy(gezoomdeKaart);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        gezoomdeKaart = Instantiate(gameObject, new Vector2(Screen.width / 2, Screen.height / 2), transform.rotation, hands);
        gezoomdeKaart.transform.localScale = new Vector2(2, 2);
    }
}
