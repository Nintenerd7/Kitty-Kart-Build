using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sardine_Spawner : MonoBehaviour
{

    public Transform Defence;//pivot point
    public GameObject DefenceObject;
    public GameObject DefencePos;
    GameObject child;

void Defend()
{
child = Instantiate(DefenceObject, Defence.position, Defence.rotation);//shoots projectile
child.transform.parent = Defence;
child.name = "Sardine";

}

public  void Block()
    {
        switch(Item_Randomizer.is_Usable)
        {
          case true:
          DefencePos.SetActive(true);
          Projectile_Controller();
          break;

          case false:
          DefencePos.SetActive(false);
          break;
        }
    }    
    void Projectile_Controller()
    {
     if (Input.GetKey(KeyCode.J))//mouse press
     {
       Defend();
     }
     else if(Input.GetKeyUp(KeyCode.J))
     {
       Item_Randomizer.is_Usable = false;//return false once released.
     }
    }

}
