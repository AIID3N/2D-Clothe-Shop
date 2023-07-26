using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaController : MonoBehaviour
{
    public GameObject tiendaUI;
    

    void Start()
    {
        tiendaUI = GameObject.Find("InventarioTienda");
        tiendaUI.SetActive(false);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            ToggleTienda(1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ToggleTienda();
    }

    private void ToggleTienda(int a =0)
    {
        if (a == 1)
        {
            tiendaUI.SetActive(true);
        }
        else
        {
            tiendaUI.SetActive(false);
        }
    }
}
