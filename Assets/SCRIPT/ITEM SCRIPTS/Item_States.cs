using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_States : MonoBehaviour
{
    public Item ItemBox;//allows class to access the Enum state
    // Start is called before the first frame update
    public ProjectileSpawner hairball;
    public Sardine_Spawner sardine;

    public Milk boost;
    // Update is called once per frame
    void Update()
    {
        switch(ItemBox)//Switch statement for enum state types 
        {
          case Item.Sardine://Idle state
          sardine.Block();
          break;
          case Item.Hairball://Chase State
          hairball.HairballValidation();
          break;

          case Item.Milk://Chase State
          boost.Dash();
          break;
        }
    }
    public enum Item
    {
        Sardine,//when  the enemy is idle
        Hairball,//enemy starts following the players position

        Milk,
    }
}
