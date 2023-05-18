using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private SpeedBonus _spBonus;
    private InvisBonus _invis;
    
    private void Start()
    {
        
        
        
        


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(Coroutine());


    }
    
    IEnumerator Coroutine()
    {
        _spBonus.SpeedBoost(rb);
        yield return new WaitForSeconds(3f);
        _spBonus.StopBoost(rb);
        
    }
}
