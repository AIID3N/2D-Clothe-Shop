using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjetoController : MonoBehaviour, IPointerDownHandler
{
    int precio = 1;
    int cantidad = 1;
    public GameObject objetoUtilizablePlayer;
    GameObject Player;

    

    void Start()
    {
        Player = GameObject.Find("Player"); 
    }

    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        int monedasDisponibles = Player.GetComponent<MonedaController>().monedas;
        if(monedasDisponibles>=precio)
        {
            monedasDisponibles -= precio;
            Player.GetComponent<MonedaController>().monedas = monedasDisponibles;

            GameObject panelInventarioPlayer = GameObject.Find("PanelInventarioPlayer");

            for (int a= 0; a<7;a++)
            {
                if(panelInventarioPlayer.transform.GetChild(a).childCount<1)
                {
                    GameObject objetoComprado = Instantiate(objetoUtilizablePlayer,new Vector2(0, 0),transform.rotation);
                    objetoComprado.transform.SetParent(panelInventarioPlayer.transform.GetChild(a).gameObject.transform, false);
                    Player.GetComponent<MonedaController>().RefreshUI();
                    break;
                }
            }
        }
    }


}
