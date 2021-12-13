using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputTexts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string teksts;

    public GameObject text_input;

    public GameObject Show_text;

    public void text_Save()
    {
        teksts = text_input.GetComponent<Text>().text;
        Show_text.GetComponent<Text>().text = "Supervaronis Oskars ir " + teksts.ToUpper() + " gadus vecs!";

    }




}
