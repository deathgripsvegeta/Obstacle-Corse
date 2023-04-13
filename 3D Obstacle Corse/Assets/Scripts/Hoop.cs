using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            GameManager.Instance.GameWon();
        }
    }
}
