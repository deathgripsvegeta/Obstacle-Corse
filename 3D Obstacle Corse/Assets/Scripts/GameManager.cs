using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Transform PlayerBear;
    public TextMeshProUGUI health;
    private Vector3 _startPos;

    [SerializeField] public float healthPoints = 5;

    [SerializeField] public bool _isGameActive = false;
    private void Awake()
    {
        Instance = this;    
    }

    // Start is called before the first frame update
    void Start()
    {
        Beginning();
    }

    // Update is called once per frame
    void Update()
    {
        health.text = healthPoints.ToString();
    }
    public void GameStart()
    {
        _startPos = PlayerBear.position;
        Time.timeScale = 1;
        _isGameActive = true;
        healthPoints = 5;
        GameStartPanel.gameObject.SetActive(false);
        DeathPanel.gameObject.SetActive(false);
        GameWonPanel.SetActive(false);
    }
    public void GameWon()
    {
        Time.timeScale = 0;
        GameWonPanel.SetActive(true);
        _isGameActive = false;
    }
    public void GameLost()
    {
        DeathPanel.gameObject.SetActive(true);
        _isGameActive = false;
        Debug.Log("dead");
    }
    
    public void Beginning()
    {
        
        GameStartPanel.gameObject.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void ReplayButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
