using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    public int monedas = 0;
    [SerializeField] private TMP_Text txtCoin;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            monedas=monedas+5;
            txtCoin.text = "" + monedas;

            Destroy(collision.gameObject);
        }
    }
}
