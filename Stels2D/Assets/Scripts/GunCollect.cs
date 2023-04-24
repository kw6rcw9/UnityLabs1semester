using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCollect : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    [SerializeField] GameObject _player;
 
   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Instantiate(_gameObject, _player.transform);
        _gameObject.transform.position = _player.transform.position;
        
        _gameObject.transform.position = new Vector3(0.45f,0, 0);
        _gameObject.transform.rotation = Quaternion.Euler(0,0,90);
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }

}
