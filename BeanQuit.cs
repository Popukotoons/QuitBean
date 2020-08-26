using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beanquit : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}
