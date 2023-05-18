using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerView : MonoBehaviour
{
    [SerializeField] private LayerMask mask;
    [SerializeField] private LayerMask obsMask;
    private Rigidbody2D _rb;
    [SerializeField] private GameObject _enemy;
    private Vector3 _direction;
    private Vector3 _point;
    //private RaycastHit2D _hit;
    private Ray2D _ray;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 1)
        {
            Debug.DrawRay(transform.position, transform.right * 100, Color.green);

            if (Input.GetMouseButtonDown(0))
            {
                _point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                _direction = _point - transform.position;
                _direction.Normalize();
                LookAtPoint();
                float _direction2 = Vector2.Distance(transform.position, _enemy.transform.position);
                if (!Physics2D.Raycast(transform.position, _direction, _direction2, obsMask))
                {
                    if(_enemy != null)
                    {
                        _enemy.gameObject.GetComponent<Renderer>().material.color = Color.red;
                        Invoke("Distroy", 0.5f);

                    }


                }
                
                //_hit.collider.transform.GetComponent<Renderer>().material.color = Color.red;
                //if (_hit.collider == _enemy)
                // _enemy.transform.GetComponent<Renderer>().material.color = Color.red;

            }
        }
    }

    void Distroy()
    {
        _enemy.SetActive(false);

    }
    void LookAtPoint()
    {
        float angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        _rb.rotation = angle;
    }
}
