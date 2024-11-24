using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkSlot : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(!Item_Randomizer.is_Usable)
        {
            Item_Randomizer.itemcheck = false;
           Destroy(gameObject);
        } 
    }
}
