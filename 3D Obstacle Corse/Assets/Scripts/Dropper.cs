using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer _renderer;
    Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        _renderer.enabled = false;
        _rigidbody.useGravity = false;
    }
    [SerializeField] private float _timeToWait = 3f;
    // Update is called once per frame
    void Update()
    {
        if(_timeToWait < Time.time)
        {
            _renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }

}
