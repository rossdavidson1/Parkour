using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L2ScoreManager : MonoBehaviour
{

    public static int coins = 0;
    Text cointotal2;

    // Start is called before the first frame update
    void Start()
    {
        cointotal2 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cointotal2.text = "" + coins + "/6";
    }
}