using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int coins = 0;
    Text cointotal;

    // Start is called before the first frame update
    void Start()
    {
        cointotal = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cointotal.text = "" + coins + "/6";
    }
}
