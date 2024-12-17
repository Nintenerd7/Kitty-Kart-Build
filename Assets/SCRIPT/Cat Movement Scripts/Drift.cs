using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drift : MonoBehaviour
{
    //drift guidelines:
    //- Control = Left click
    //When pressed player jumps a little then tilts the Kart into a direction
    //after drifting for a few seconds the boost speed increases
    //after realeasing the input the player will get a boost

    public PlayerController Controls;
        //drifting variables
   // public GameObject Particle;
    public bool isDrifting;
   
   public void Drift_Calc(float Boost_Speed)
   {
      Controls.SpeedCap += Boost_Speed;
   }

   public IEnumerator Drifting_QUEUE()
   {
   yield return new WaitForSeconds(3);
   Drift_Calc(1f);
    yield return new WaitForSeconds(3);
   Drift_Calc(2f);
    if(Input.GetMouseButtonUp(0))
    {
      Debug.Log("Not Drifting");
      isDrifting = false;
      yield break;
    }
   }

}
