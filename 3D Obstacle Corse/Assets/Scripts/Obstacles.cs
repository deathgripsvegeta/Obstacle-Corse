using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Obstacles : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {  
           if(GameManager.Instance.healthPoints > 0)
           {
               GameManager.Instance.healthPoints--;
           }
           else
           {
                GameManager.Instance.GameLost();
           }
        }
        
        
        

    }
    
}
