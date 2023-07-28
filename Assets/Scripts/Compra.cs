using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Compra : MonoBehaviour
{
    [Header("UI Text")]
    public TMP_Text saldo;
    public TMP_Text txtAviso;

    [Header("Buttons")]
    public Button btnSlot1;
    public Button btnSlot2;
    public Button btnSlot3;
    public Button btnSlot4;
    public Button btnSlot5;
    public Button btnSlot6;

    public CoinController scriptcoin;

    [Header("Tendero")]
    public float gananciaTendero = 0;
    public TMP_Text txtGanancia;
    public TMP_Text avisoCompra;

    private float prenda1 = 10f;
    private float prenda2 = 14f;
    private float prenda3 = 20f;
    private float prenda4 = 18f;
    private float prenda5 = 24f;
    private float prenda6 = 8f;

    public void CompraItem1()
    {
        if (scriptcoin.monedas == prenda1)
        {
            scriptcoin.monedas -= prenda1;
            saldo.text = "" + scriptcoin.monedas;
            btnSlot1.interactable = false;
            gananciaTendero += prenda1;
            StartCoroutine(Agradecimiento());
        }
        else
        {
            StartCoroutine(InfoSaldo());
        }
    }

    public void CompraItem2()
    {
        if (scriptcoin.monedas == prenda2)
        {
            scriptcoin.monedas -= prenda2;
            saldo.text = "" + scriptcoin.monedas;
            btnSlot2.interactable = false;
            gananciaTendero += prenda2;
            StartCoroutine(Agradecimiento());
        }
        else
        {
            StartCoroutine(InfoSaldo());
        }
    }

    public void CompraItem3()
    {
        if (scriptcoin.monedas == prenda3)
        {
            scriptcoin.monedas -= prenda3;
            saldo.text = "" + scriptcoin.monedas;
            btnSlot3.interactable = false;
            gananciaTendero += prenda3;
            StartCoroutine(Agradecimiento());
        }
        else
        {
            StartCoroutine(InfoSaldo());
        }
    }

    public void CompraItem4()
    {
        if (scriptcoin.monedas == prenda4)
        {
            scriptcoin.monedas -= prenda4;
            saldo.text = "" + scriptcoin.monedas;
            btnSlot4.interactable = false;
            gananciaTendero += prenda4;
            StartCoroutine(Agradecimiento());
        }
        else
        {
            StartCoroutine(InfoSaldo());
        }
    }

    public void CompraItem5()
    {
        if (scriptcoin.monedas == prenda5)
        {
            scriptcoin.monedas -= prenda5;
            saldo.text = "" + scriptcoin.monedas;
            btnSlot5.interactable = false;
            gananciaTendero += prenda5;
            StartCoroutine(Agradecimiento());
            Debug.Log(prenda5);
        }
        else
        {
            StartCoroutine(InfoSaldo());
        }
    }

    public void CompraItem6()
    {
        if (scriptcoin.monedas >= prenda6)
        {
            scriptcoin.monedas -= prenda6;
            saldo.text = "" + scriptcoin.monedas;
            btnSlot6.interactable = false;
            gananciaTendero += prenda6;
            StartCoroutine(Agradecimiento());
        }
        else
        {
            StartCoroutine(InfoSaldo());
        }
    }

    IEnumerator InfoSaldo()
    {
        txtAviso.text = "Saldo insuficiente";
        yield return new WaitForSeconds(1f);
        txtAviso.text = "";
    }

    IEnumerator Agradecimiento()
    {
        txtGanancia.text = "$ " + gananciaTendero;
        avisoCompra.text = "Gracias por su compra!";
        yield return new WaitForSeconds(2f);
        avisoCompra.text = "";
    }
}