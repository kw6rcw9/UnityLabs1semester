using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class AMovement : MonoBehaviour
 {
     public abstract Vector2 MoveDirection();

     public abstract void DebugMovement();
     public abstract void Prepare(Rigidbody2D rigidbody2D);



 }

// public class PlatformerMovement : AMovement
// {
//     public override Vector2 MoveDirection()
//     {
//         
//     }
//     
// }