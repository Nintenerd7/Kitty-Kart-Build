using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk : MonoBehaviour
{
    public bool isDashing;
    // Update is called once per frame
   public void Dash()
    {
          if(Input.GetKey(KeyCode.J))
        {
         StartCoroutine(DashBoost());
        }
    }

    public IEnumerator DashBoost()
    {
 
         isDashing = true;
         yield return new WaitForSeconds(0.4f);

      
         isDashing = false;
    }
}
