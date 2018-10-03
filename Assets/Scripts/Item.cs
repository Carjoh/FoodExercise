using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName;
    public float value;
    public float weight;
    public float pricePerWeight;
    public Text texten;
    public string basicText = "VAD VILL DU HA NU DÅ?";

    public virtual void Start()
    {
        GetPricePerWeight();
        Debug.Log(pricePerWeight);
    }


    public virtual void OnMouseEnter()
    {
        texten.text = "Detta är " + itemName + ". Den kostar " + pricePerWeight + " per kg";
    }
    public void OnMouseExit()
    {
        texten.text = basicText;
    }

    public void GetPricePerWeight()
    {
        pricePerWeight = value / weight;
    }
    
}
