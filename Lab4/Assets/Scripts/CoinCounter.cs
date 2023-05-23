using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text coinText;
    public static int coin;
    void Update(){
        coinText.text = " " + coin;
    }
}
