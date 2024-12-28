using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drfit_Mechanic : MonoBehaviour
{
    // this script is for the particle effects,trails and speed logic
    public Player_Controller boost;

    public void Blue_Boost()
    {
        boost.DriftPower = 2;
        Debug.Log("blue sparks");
    }
     public void Orange_Boost()
    {
        boost.DriftPower = 4;
        Debug.Log("orange sparks");
    }
     public void Purple_Boost()
    {
      boost.DriftPower = 6;
      Debug.Log("purple sparks");
    }

    public void Reset_Values()
    {
      boost.CanDrift = 1;
      boost.isDrifting = false;
      boost.jumpforce = 5f;
      boost.velocity = 2f;
      boost.SpeedCap = 2f;
    }
}
