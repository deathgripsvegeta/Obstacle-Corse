using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpinnies : MonoBehaviour
{
    [SerializeField] private float _xAngle = 0;
    [SerializeField] private float _yAngle = 0;
    [SerializeField] private float _zAngle = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_xAngle, _yAngle, _zAngle);
    }
}
