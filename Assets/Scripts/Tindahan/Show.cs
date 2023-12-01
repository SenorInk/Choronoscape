using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject activeGameObject;
    public GameObject activeGameObject1;
    public GameObject activeGameObject2;


    void Awake()
    {
        activeGameObject.SetActive(false);
        activeGameObject1.SetActive(false);
        activeGameObject2.SetActive(false);
    }
    public void ActivateObject()
    {

        if (activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
            activeGameObject1.SetActive(true);
            activeGameObject2.SetActive(true);

        }
        else
        {
            activeGameObject.SetActive(false);
            activeGameObject1.SetActive(false);
            activeGameObject2.SetActive(false);
        }

    }

    public void Weapons()
    {
        activeGameObject.SetActive(true);
    }

    public void Ensembles()
    {
        activeGameObject1.SetActive(true);
    }

    public void Abilities()
    {
        activeGameObject2.SetActive(true);
    }

}
