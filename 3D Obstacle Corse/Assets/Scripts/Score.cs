using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{      
    public TextMeshProUGUI health;
    public GameObject DeathPanel;
    [SerializeField] public float healthPoints = 5;
    [SerializeField] private int _hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            _hits++;
            
        }
        if(healthPoints < _hits)
        {
            DeathPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

}
