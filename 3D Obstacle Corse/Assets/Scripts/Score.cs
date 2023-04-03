using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{      
    public TextMeshProUGUI health;
    [SerializeField] public float healthPoints = 5;

    private void Start() 
    {
        health.text = healthPoints.ToString();
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "bad")
        {
            --healthPoints;
            
        }
        if(healthPoints==0)
        {
            GameManager.Instance.DeathPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

}
