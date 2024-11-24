using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sardine : MonoBehaviour
{
    void Update()
    {
                 if(!Item_Randomizer.is_Usable)
        {
            Item_Randomizer.itemcheck = false;
           Destroy(gameObject);
        }
    }
}
