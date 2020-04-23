using UnityEngine;

public class InstantiationExample : MonoBehaviour
{
    public GameObject baseKaart;
    private GameObject[] meerdereKaarten = new GameObject[2];
    [SerializeField] public Transform hand;
    
    void Start()
    {
        KaartInfo.eventnaam = "bbb";
        for (int eventKaartAmount = 0; eventKaartAmount < meerdereKaarten.Length; eventKaartAmount++)
        {
            GameObject objekkie = Instantiate(baseKaart, new Vector3(0, 0, 0), Quaternion.identity, hand);
            objekkie.GetComponent<KaartInfo>().kaartID = eventKaartAmount;
            meerdereKaarten[eventKaartAmount] = objekkie;
        }

    }
}
