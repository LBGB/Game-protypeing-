using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class panelopener : MonoBehaviour
{
    public GameObject _Panel;

    public void OpenPanel()
    {
        _Panel.SetActive(true);
    }

    public void ClosedPanel()
    {
        _Panel.SetActive(false);
    }


}
