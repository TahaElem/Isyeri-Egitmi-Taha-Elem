using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sart_ifadeleri : MonoBehaviour
{
    int a = 1;
    private void Start()
    {
        if (a == 1)
        {
            Debug.Log("a De�i�keni 1'e e�ittir.");
        }

        else if (a == 2)
        {
            Debug.Log("a de�i�keni 2'ye e�ittir.");
        }

        else if (a == 3)
        {
            Debug.Log("a de�i�keni 3'e e�ittir.");
        }

        else 
        {
            Debug.Log("a de�i�keni 1'e e�it de�ildir.");
        }

        // random ile de�i�ken kontrol�

        a = Random.Range(0, 6);
        Debug.Log(a);

        if (a==1)
        {
            Debug.Log("a= 1");

        }
        
        else if(a==2)
        {
            Debug.Log("a= 2");
        }
        else if(a>=3)
        {
            Debug.Log("a >= 1");
        }
        else
        {
            Debug.Log("a= 0");
        }


    }
}
