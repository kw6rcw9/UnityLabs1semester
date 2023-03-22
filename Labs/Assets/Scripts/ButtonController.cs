using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] Image[] _image;
    [SerializeField] Button _button;
    private int n = 0;
    
    void Start()
    {
        _image[0].color = new Color(1, 1, 0);
        
        _button.onClick.AddListener(ColorChange);
        
    }
    private void Awake()
    {
    }


    public void ColorChange()
    {
        if(n == _image.Length-1)
        {
            n = 0;
            _image[n].color = new Color(1, 1, 0);
            _image[_image.Length - 1].color = new Color(0, 1, 0);
            

        }
        else
        {
            
            _image[n+1].color = new Color(1,1,0);
            _image[n].color = new Color(0, 1, 0);
             n++;

        }

    }
}
