using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    public float uses;
    public float maxUses;

    public bool rotating;

    public SpriteRenderer shade;

    public override void Start()
    {
        shade = transform.GetChild(0).GetComponent<SpriteRenderer>();
        uses = maxUses;
        GetPricePerWeight();
        Debug.Log(pricePerWeight);
    }

    public void OnMouseUpAsButton()
    {
        if (uses > 0 && !rotating)
        {
            Use();
            StartCoroutine(Spin());
        }
        else if (rotating)
        {
            VäntaDenRoterar();
        }
        else
            NoUsesRemainingText();
    }
    public virtual void Use()
    {
        uses--;
        texten.text = "Du använde " + itemName + ". Nu kan du använda den " + uses + " gånger till";
    }
    public virtual void NoUsesRemainingText()
    {
        texten.text = "Du kan inte använda " + itemName + " mer :(";
    }

    public virtual void VäntaDenRoterar()
    {
        texten.text = "Vänta lite. Just nu roterar " + itemName;
    }

    public void Update()
    {
        if (rotating)
        {
            transform.Rotate(0, 0, 360 * Time.deltaTime);
            shade.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        else
        {
            transform.rotation = Quaternion.identity;
            shade.color = new Color(1, 1, 1);
        }
    }

    IEnumerator Spin()
    {
        rotating = true;
        yield return new WaitForSeconds(1);
        rotating = false;
    }
}
