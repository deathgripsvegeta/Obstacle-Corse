using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject PausePanel;
    public GameObject GameStartPanel;
    public GameObject GameWonPanel;
    public GameObject DeathPanel;
    public GameObject Player;
    [SerializeField] public bool _isGameActive;
    void Awake() 
    {
        Instance = this;
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool GameStart()
    {
        return _isGameActive;
    }
    public void GameWon()
    {
        Time.timeScale = 0;
        GameWonPanel.SetActive(true);
    }
}
