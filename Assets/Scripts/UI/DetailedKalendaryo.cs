using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailedKalendaryo : MonoBehaviour
{
    public GameObject activeGameObject;


    void Awake()
    {
        activeGameObject.SetActive(false);
    }
    public void ActivateObject()
    {

        if(activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
            
        }
        else
        {
            activeGameObject.SetActive(false);
        }

    }

    public void Return()
    {
        activeGameObject.SetActive(false);
    }
}
