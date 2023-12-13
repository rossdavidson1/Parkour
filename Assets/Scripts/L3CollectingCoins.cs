using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L3CollectingCoins : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            ScoreManager.coins = coins += 1;
            Col.gameObject.SetActive(false);
        }

        if (coins >= 6)
        {
            SceneManager.LoadSceneAsync(4);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
