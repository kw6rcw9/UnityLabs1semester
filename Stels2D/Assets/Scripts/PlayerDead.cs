using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] GameObject _enemy; 
    [SerializeField] GameObject _startPos;
    [SerializeField] GameObject _gun;
   
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
            _gun.SetActive(true);
        if(transform.childCount > 0)
        Destroy(transform.GetChild(0).gameObject);

        transform.position = _startPos.transform.position;
        transform.GetComponent<Renderer>().material.color = Color.white;




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            transform.GetComponent<Renderer>().material.color = Color.red;
            Invoke("Teleport", 0.5f);

        }
        else if(collision.transform.tag == "Finish")
        {
            SceneManager.LoadScene(0);

        }
    }


}
