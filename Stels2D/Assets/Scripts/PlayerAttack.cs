using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private LayerMask mask;
    [SerializeField] private LayerMask obstructionMask;
     
    [SerializeField] private Transform _enemy;

    private Vector3 _direction;
    private Vector3 _point;
    //private RaycastHit2D _hit;
    private Ray2D _ray;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, -transform.up * 100, Color.green);  
        RaycastHit2D _hit = Physics2D.Raycast(transform.position, -transform.up * 100, Mathf.Infinity);
        if (Input.GetMouseButtonDown(0))
        {
            if(_hit.collider != null && Physics2D.Raycast(transform.position, -transform.up * 100, Mathf.Infinity, obstructionMask))


           

                _hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;


           

        }
    }

    

   

}
