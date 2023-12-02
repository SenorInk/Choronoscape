using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    // Start is called before the first frame update
    public void Close()
    {
        this.gameObject.SetActive(false);
    }
}
