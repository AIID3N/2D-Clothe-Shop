using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IconType
{
    None, // Valor para indicar que el slot del inventario est� vac�o
    Capota1,
    Traje1,
    Mascara,
    Capota2,
    Traje2,
    Cabello,

    // Puedes agregar m�s tipos de �conos aqu� seg�n sea necesario
}
public class Inventory : MonoBehaviour
{
    public GameObject closeInv;
    public Dialogue dialogue;
    //public GameObject uiDialogue;



    public GameObject[] tiendaSlots; // Asigna los botones de la tienda (con sus iconos) desde el editor de Unity
    public GameObject[] inventarioSlots; // Asigna los slots del inventario desde el editor de Unity

    public IconType[] inventarioIconos; // Almacena el tipo de �cono presente en cada slot del inventario

    [Header("Clothes Store")]
    public GameObject capota1, traje1, mascara, capota2, traje2, cabello;
    /*public GameObject traje1;
    public GameObject mascara;
    public GameObject capota2;
    public GameObject traje2;
    public GameObject cabello;
    */

    [Header("Clothes Original")]
    public GameObject hoodORG1;  
    public GameObject torsoORG1;
    public GameObject headORG;

    void Start()
    {
     //   dialogue = uiDialogue.GetComponent<Dialogue>();
    }

    void Update()
    {
        
    }

    public void CloseInventory()
    {
        closeInv.SetActive(false);
        //dialogue.storeActive = false;
        dialogue.dialoguePanel.SetActive(false);
        dialogue.player.SetActive(true);
    }

    public void MoverIcono(GameObject button)
    {
        // Obtener el �cono del bot�n de la tienda clicado
        GameObject icono = button.transform.GetChild(0).gameObject;

        // Buscar el primer slot vac�o del inventario
        int inventarioVacioIndex = -1;
        for (int i = 0; i < inventarioSlots.Length; i++)
        {
            if (inventarioSlots[i].transform.childCount == 0)
            {
                inventarioVacioIndex = i;
                break;
            }
        }

        if (inventarioVacioIndex != -1)
        {
            // Si se encontr� un slot vac�o en el inventario, mover el �cono y actualizar el inventarioIconos
            icono.transform.SetParent(inventarioSlots[inventarioVacioIndex].transform);
            icono.transform.localPosition = Vector3.zero;

            // Obtener el identificador del �cono
            IconInfo iconoInfo = icono.GetComponent<IconInfo>();
            inventarioIconos[inventarioVacioIndex] = iconoInfo.tipo; // Actualizar el inventarioIconos con el nuevo tipo de �cono en el slot del inventario
        }
        else
        {
            // Si todos los slots del inventario est�n ocupados, mostrar mensaje en la consola
            Debug.Log("Slots llenos");
        }
    }

    public void ActivarGameObjectEnInventario(int index)
    {
        if (inventarioIconos[index] != IconType.None)
        {
            // Activa el GameObject seg�n el tipo de �cono presente en el slot del inventario
            switch (inventarioIconos[index])
            {
                case IconType.Capota1:
                    capota1.SetActive(true);
                    hoodORG1.SetActive(false);
                    capota2.SetActive(false);
                    cabello.SetActive(false);// Activa el cubo
                    break;

                case IconType.Traje1:
                    traje1.SetActive(true);
                    torsoORG1.SetActive(false);
                    traje2.SetActive(false);// Activa la esfera
                    break;

                case IconType.Mascara:
                    mascara.SetActive(true);
                    headORG.SetActive(false);// Activa el plano
                    break;
                case IconType.Capota2:
                    capota2.SetActive(true);
                    hoodORG1.SetActive(false); 
                    capota1.SetActive(false);
                    cabello.SetActive(false);// Activa el cubo
                    break;

                case IconType.Traje2:
                    traje2.SetActive(true);
                    torsoORG1.SetActive(false);
                    traje1.SetActive(false);// Activa la esfera
                    break;

                case IconType.Cabello:
                    cabello.SetActive(true);
                    capota1.SetActive(false);
                    capota2.SetActive(false);
                    hoodORG1.SetActive(false);// Activa el plano
                    break;
            }
            Destroy(inventarioSlots[index].transform.GetChild(0).gameObject);
            inventarioIconos[index] = IconType.None;
        }
    }
}
