using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
   private float _radius = 6.4f;
     private float _angle = 49f;
    [SerializeField] private LayerMask _targetMask;
    [SerializeField] private LayerMask _obstructionMask;
    [SerializeField] private GameObject _target;

    [SerializeField] private bool _canSeePlayer;
    public bool CanSeePlayer { get { return _canSeePlayer; } }
    private GameObject _player;
    public GameObject Player => _player;

    private void Update()
    {
        FieldOfViewCheck();
    }


    private void FieldOfViewCheck()
    {
        Collider2D rangeCheck = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), _radius, _targetMask);

        if (rangeCheck != null)
        {
            Transform target = rangeCheck.transform;
            Vector2 directionToTarget = (target.position - transform.position).normalized;

            if (Vector2.Angle(transform.up, directionToTarget) < _angle / 2)
            {
                float distanceToTarget = Vector2.Distance(transform.position, target.position);

                if (!Physics2D.Raycast(transform.position, directionToTarget, distanceToTarget, _obstructionMask))
                {
                    _target.gameObject.GetComponent<Renderer>().material.color = Color.red;

                    SeePlayer(true, target.gameObject);
                }
                else
                    SeePlayer(false);
            }
            else
                SeePlayer(false);

        }
        else if (_canSeePlayer)
        {
            SeePlayer(false);
        }
    }

    private void SeePlayer(bool see, GameObject player = null)
    {
        _canSeePlayer = see;
        _player = player;
    }

    private void OnDrawGizmos()
    {
        
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + DirectionFromAngle(-transform.eulerAngles.z, -_angle / 2) * _radius);
        Gizmos.DrawLine(transform.position, transform.position + DirectionFromAngle(-transform.eulerAngles.z, _angle / 2) * _radius);

        //if (_canSeePlayer)
        //{
        //    Gizmos.color = Color.green;
        //    //Gizmos.DrawLine(transform.position, Player.transform.position);
        //}
    }
    private Vector3 DirectionFromAngle(float eulerY, float angleInDegrees)
    {
        angleInDegrees += eulerY;
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
}
