using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter > 900)
        {
            SceneManager.LoadScene("proj");
        }
    }
}
