using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOne : MonoBehaviour
{
    void update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Get Component<Renderer>().material.color = Color.blue;
        }
    }
}
