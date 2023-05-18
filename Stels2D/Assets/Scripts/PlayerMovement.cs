using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject _startPos;
    private float _speed = 3;
    Rigidbody2D rb;
    private Vector2 _moveDirection;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = _startPos.transform.position;
    }


    private void FixedUpdate()
    {
        Move();
        
    }

    private void Update()
    {
        Inputs();
   
    }

    void Inputs()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        _moveDirection = new Vector2(x, y).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(_moveDirection.x * _speed, _moveDirection.y * _speed);

    }

}
