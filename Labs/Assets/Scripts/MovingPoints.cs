using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPoints : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] private float _speed = 2;
    [SerializeField] private int _point = 0;

    void Start()
    {
        transform.position = _points[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        ToPointMove();
    }

    private void ToPointMove()
    {
        if (_point == _points.Length)
        {
            _point = 0;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, _points[_point].position, _speed * Time.deltaTime);
        
        if(transform.position == _points[_point].position)
        {
            _point++;
        }

        

    }
}
