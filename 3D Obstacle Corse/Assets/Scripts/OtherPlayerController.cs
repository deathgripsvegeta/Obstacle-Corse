using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlayerController : MonoBehaviour
{
    [SerializeField]private float _moveSpeed = 10f;
    [SerializeField]private float _rotationSpeed = 10f;
    [SerializeField]private Rigidbody _playerRB;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 forwardInput = transform.forward * Input.GetAxis("Vertical");

        _playerRB.AddForce(forwardInput * _moveSpeed, ForceMode.Acceleration);
        transform.Rotate(Vector3.up, horizontalInput * _rotationSpeed * Time.deltaTime);
    }
    void Movement()
    {
        float xValue=Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue=Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0f, zValue);
    }
}
