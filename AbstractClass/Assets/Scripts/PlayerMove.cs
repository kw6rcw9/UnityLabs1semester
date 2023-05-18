using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private AMovement _aMovement;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _aMovement = gameObject.AddComponent<PlatformerMovement>();
        _aMovement.Prepare(_rb);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            _aMovement = gameObject.AddComponent<TopDownMovement>();
            _aMovement.Prepare(_rb);
        }
        _rb.velocity = _aMovement.MoveDirection();
        if (Input.GetKeyDown(KeyCode.D))
        {
            _aMovement.DebugMovement();
        }

    }
}
