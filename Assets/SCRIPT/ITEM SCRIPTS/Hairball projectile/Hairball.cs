using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hairball : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(!Item_Randomizer.is_Usable)
        {
           Destroy(gameObject);
        }
    }
}
