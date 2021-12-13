using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per fram
    void Update()
    {
        
    }

    public GameObject man1;
    public GameObject man2;
    public GameObject changeButton;
    public Sprite[] pictureArray;

    public void function(int number)
    {
       if(number== 0)
         changeButton.GetComponent<Image>().sprite = pictureArray[0];
       if(number == 1)
         changeButton.GetComponent<Image>().sprite = pictureArray[1];
    }
}
