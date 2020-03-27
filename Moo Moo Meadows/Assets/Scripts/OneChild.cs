using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneChild : MonoBehaviour
{
    public int maxChildAmount = 1;
    public Transform hand;

    public void Hand() {

        hand = transform.parent.parent.Find("Hand");

    }

    void Update()
    {
        if (transform.childCount > maxChildAmount)
        {
            for (int i = maxChildAmount; i < transform.childCount; i++)
            {
                transform.GetChild(i).SetParent(hand);
            }
        }
    }
}
