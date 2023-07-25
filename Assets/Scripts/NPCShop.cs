using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShop : MonoBehaviour
{
    public GameObject ShopUI;
    private bool show = false;
    //private Dialogue script;
    public GameObject ui;

    void Start()
    {
        //script = ui.GetComponent<Dialogue>(); 
    }

    void Update()
    {
        if(show)
        {
            ShopUI.SetActive(true);
            //script.ShopUI
        }
        else
        {
            ShopUI.SetActive(true);
        }
        
    }

    private void OntriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                show = !show;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        show = false;
    }
}
