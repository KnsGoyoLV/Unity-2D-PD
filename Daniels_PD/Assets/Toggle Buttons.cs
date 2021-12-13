using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleButtons : MonoBehaviour
{
    public GameObject Cepure;
    public GameObject Bikses;
    public GameObject Cimdi;


    public void CepureShow(bool variable)
    {
        Cepure.SetActive(variable);
    }public void BiksesShow(bool variable)
    {
        Bikses.SetActive(variable);
    }
    public void CimdiShow(bool variable)
    {
        Cimdi.SetActive(variable);
    }

}
