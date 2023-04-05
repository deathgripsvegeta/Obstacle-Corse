using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Obstacles : MonoBehaviour
{
    private void Update()
    {
        
    }  
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            gameObject.tag = "Hit";
        }
        if(other.gameObject.tag != "Player")
        {
            Debug.Log("player hit me.");
            
        }
        if(this.gameObject.tag != "Obstacle")
        {
            --GameManager.Instance.healthPoints;
            Debug.Log("-1");
            
        }
        if(GameManager.Instance.healthPoints==0)
        {
            /*GameManager.Instance.DeathPanel.gameObject.SetActive(true);
            Time.timeScale = 0;*/
            Debug.Log("dead");
        }
        /*if(other.gameObject.tag != "finish")
        {
            GameManager.Instance.GameWon();
        }*/

    }
    
}
