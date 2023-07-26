using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;


public class MonedaController : MonoBehaviour
{
    public int monedas = 0;
    GameObject texto;
    void Start()
    {
        texto = GameObject.Find("ContadorMonedas");
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Coin")
        {
            monedas++;
            RefreshUI();

            Destroy(collision.gameObject);
        }
    }

    public void RefreshUI()
    {
        texto.GetComponent<TextMeshProUGUI>().SetText(monedas + "");
    }
}
