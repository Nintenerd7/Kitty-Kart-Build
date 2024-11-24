using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Randomizer : MonoBehaviour
{
    public GameObject[] Items = new GameObject [4];
    public Transform Itempos;
    public static bool is_Usable;
    public static bool Can_Defend;
    public GameObject ProjectileMech;
    private GameObject Child;
    public static bool itemcheck;
    public Item_States state;
    // Start is called before the first frame update
    void Start()
    {
        Child.transform.SetParent(this.transform);
    }

    public void Randomizer()
    {
            if (Random.Range(0, 8) <= 4)//if random range is more or equal to two
            {
                itemcheck = true;
                is_Usable = true;
                //instansiate sardine Icon
                Child = Instantiate(Items[0], Itempos.position, transform.rotation);
                state.ItemBox = Item_States.Item.Sardine;
                Debug.Log("Sardine");
            }
          else  if (Random.Range(0, 8) <= 6)//if random range is more or equal to two
            {
               itemcheck = true;
               is_Usable = true;
               state.ItemBox = Item_States.Item.Hairball;
               Child =  Instantiate(Items[1], Itempos.position, transform.rotation);
                Debug.Log("Hair ball");
            }
           else if (Random.Range(0, 8) <= 8)//if random range is more or equal to two
            {
                itemcheck = true;
                state.ItemBox = Item_States.Item.Milk;
                Child = Instantiate(Items[2], Itempos.position, transform.rotation);
                Debug.Log("Milk");
            }
    }

}
