using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private ABonus _bonus;
    
    
    private void Start()
    {


        _bonus = new SpeedBonus();
        



    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(Coroutine());


    }
    
    IEnumerator Coroutine()
    {
        
        yield return new WaitForSeconds(3f);
     
        
    }
}
