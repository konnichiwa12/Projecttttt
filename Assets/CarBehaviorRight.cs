using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviorRight : MonoBehaviour
{
    // Start is called before the first frame update
    public int direction;
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + .2f, transform.position.y, transform.position.z);
        if (transform.position.x >= 33)
        {
            Destroy(gameObject);
        }
    }

}
