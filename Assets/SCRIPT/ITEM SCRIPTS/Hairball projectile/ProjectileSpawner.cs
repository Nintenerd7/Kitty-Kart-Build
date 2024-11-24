using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProjectileSpawner : MonoBehaviour
{
    public Rigidbody projectile;//rigidbody of the projectile
    public GameObject Prefab;//gameobject 
    public Transform FirePoint;//pivot point
    public Transform Defence;//pivot point
    public GameObject DefenceObject;
    public GameObject DefencePos;
    public static Rigidbody clone;//cloning body

    public Item_Randomizer use;

   public void HairballValidation()
    {
      switch (PauseMenu.IsPaused)
      {
        case true:
        Debug.Log("NOPE");
        break;

        case false:
        CanShoot();//then checks if the Player has the item to use. 
        break;
      }
    }


    void shoot()//contains logic for the shooting command
    {
        clone = (Rigidbody)Instantiate(projectile, FirePoint.position, projectile.rotation);//shoots projectile

        clone.velocity = FirePoint.TransformDirection(Vector3.forward * 20);//allows player to shoot more than one bullet 
        Item_Randomizer.is_Usable = false;
        //shoot
    }
void Defend()
{
GameObject child = Instantiate(DefenceObject, Defence.position, Defence.rotation);//shoots projectile
child.transform.parent = Defence;
child.name = "instantiate";


}
    void CanShoot()
    {
        switch(Item_Randomizer.is_Usable)
        {
          case true:
          DefencePos.SetActive(true);
          Prefab.SetActive(true);
          Projectile_Controller();
          break;

          case false:
          DefencePos.SetActive(false);
          Prefab.SetActive(false);
          break;
        }
    }

    void Projectile_Controller()
    {
      if (Input.GetKey(KeyCode.J))//mouse press
     {
        shoot();
  
     }
     if (Input.GetKeyDown(KeyCode.L))//mouse press
     {
       Defend();
     }
     else if(Input.GetKeyUp(KeyCode.L))
     {
       Item_Randomizer.is_Usable = false;//return false once released.
       shoot();
     }
    }
}
