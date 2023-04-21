using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject _player;
    Rigidbody2D _rigidbody;
    [SerializeField] float _speed = 4;
    void Start()
    {
        
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector2.left * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector2.right * _speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector2.up * _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(Vector2.down * _speed);
        }


    }
}
