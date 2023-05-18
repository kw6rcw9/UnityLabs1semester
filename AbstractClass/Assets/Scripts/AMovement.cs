using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

 public abstract class AMovement : MonoBehaviour
 {
     protected float horizontal;
     protected float vertical;
     protected float _speed = 3f;
     public abstract Vector2 MoveDirection();

     public abstract void DebugMovement();
     public abstract void Prepare(Rigidbody2D rb);



 }

public class PlatformerMovement : AMovement
{
    public override Vector2 MoveDirection()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal");
        return new Vector2(horizontal * _speed, vertical * _speed);
    }

    public override void DebugMovement()
    {
        Debug.Log("PlatformerMovement");
    }

    public override void Prepare(Rigidbody2D rb)
    {
        rb.gravityScale = 1f;

    }
    
}
public class TopDownMovement : AMovement
{
    public override Vector2 MoveDirection()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        
        return new Vector2(horizontal * _speed, vertical * _speed);
    }

    public override void DebugMovement()
    {
        Debug.Log("TopdownMovement");
    }

    public override void Prepare(Rigidbody2D rb)
    {
        rb.gravityScale = 0f;

    }
    
}