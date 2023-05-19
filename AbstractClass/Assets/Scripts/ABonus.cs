using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class ABonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bonus");
    }

    public virtual void SpeedBoost(Rigidbody2D rb)
    {
        Debug.Log("");
    }
}

public class SpeedBonus : ABonus
{
    private float  _speed = 2f;
    public override void SpeedBoost(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(rb.velocity.x * _speed, rb.velocity.y * _speed);
    }

    public void StopBoost(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        
    }

  
}

public class InvisBonus : ABonus
{
    public void Invis(GameObject player)
    {
        player.GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, 0.3f);

    }
    public void StopInvis(GameObject player)
    {
        player.GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, 1f);

    }
}