using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{      

   private void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("Player"))
       {
           if(this.gameObject.tag == "finish")
           {
               GameManager.Instance.GameWon();
           }
       }
   }

}
