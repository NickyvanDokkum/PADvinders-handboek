using UnityEngine;

public class InstantiationExample : MonoBehaviour
{
    public GameObject baseKaart;
    private GameObject[] meerdereKaarten = new GameObject[2];
    [SerializeField] public Transform hand;
    private int amount;
    void Start()
    {
        KaartInfo.eventnaam = "bbb";
        meerdereKaarten = new GameObject[KaartInfo.GetCardAmount()];
        for (int eventKaartAmount = 0; eventKaartAmount < meerdereKaarten.Length; eventKaartAmount++)
        {
            GameObject objekkie = Instantiate(baseKaart, new Vector3(0, 0, 0), Quaternion.identity, hand);
            objekkie.GetComponent<KaartInfo>().kaartID = eventKaartAmount;
            meerdereKaarten[eventKaartAmount] = objekkie;
        }

    }
}
