using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] GameObject _enemy; 
    [SerializeField] GameObject _startPos;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyView _detect = _enemy.GetComponent<EnemyView>();
        if(_detect.CanSeePlayer == true)
        {
            transform.position = _startPos.transform.position;
            transform.GetComponent<Renderer>().material.color = Color.white;
        }
        
        
        
    }


}
