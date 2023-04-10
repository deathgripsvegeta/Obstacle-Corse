using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlayerController : MonoBehaviour
{
    [SerializeField]private float _moveSpeed = 10f;
    [SerializeField]private GameObject _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        

    }
    void Movement()
    {
        float xValue=Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue=Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0f, zValue);
    }
}
