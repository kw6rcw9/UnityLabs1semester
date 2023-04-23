using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] GameObject _enemy; 
    [SerializeField] GameObject _startPos;
    EnemyView _detect;
   
    void Start()
    {
        
        _detect = _enemy.GetComponent<EnemyView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_detect.CanSeePlayer == true)
        {
            Invoke("Teleport", 0.5f);
        }
        
        
        
    }

    void Teleport()
    {
        transform.position = _startPos.transform.position;
        transform.GetComponent<Renderer>().material.color = Color.white;
    }


}
