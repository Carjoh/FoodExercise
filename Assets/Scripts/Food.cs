using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consumable
{
    public float saturation;
    public bool isYummy;

    public override void OnMouseEnter()
    {
        texten.text = "Detta är " + itemName + ". Den kostar " + pricePerWeight + " per kg.";
    }
    public override void Use()
    {
        uses--;
        texten.text = "Du åt " + itemName + ". Nu kan du äta den " + uses + " gånger till.";

    }
    public override void NoUsesRemainingText()
    {
        texten.text = "Du kan inte äta " + itemName + " mer din apa";

    }
}
