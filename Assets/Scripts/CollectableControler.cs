using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControler : MonoBehaviour
{
    
    public  static int CoinCount;
    public GameObject CoinCountDisplay;
    public GameObject CoinEndDisplay;

    void Update()
    {
        CoinCountDisplay.GetComponent<Text>().text = "" + CoinCount;
        CoinEndDisplay.GetComponent<Text>().text = "" + CoinCount;
    }
}
