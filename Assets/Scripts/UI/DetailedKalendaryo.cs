using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailedKalendaryo : MonoBehaviour
{
    public GameObject activeGameObject;


    void Awake()
    {
        
    }
    public void ActivateObject()
    {
        activeGameObject.SetActive(true);
    }
    public void Close()
    {
        activeGameObject.SetActive(false);
    }

}
