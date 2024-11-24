using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Box_Operator : MonoBehaviour
{
    public GameObject ItemSlot;
    public Item_Randomizer item;
     
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        switch(Item_Randomizer.itemcheck)
        {
            case false:
         ItemSlot.SetActive(true);
        item.Randomizer();
        Destroy(gameObject); 
        break;

        case true:
        Destroy(gameObject);
        break; 
        }  
    }
    //on trigger enter here
}
