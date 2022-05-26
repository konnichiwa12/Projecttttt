using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class carSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnableCarL;
    public GameObject spawnableCarR;

    System.Random rnd;
    void Start()
    {
        rnd = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        double randNum = rnd.NextDouble();
        if (randNum > 0.0140)
        {
            Debug.Log("No Car");
            return;
        }
        double direction = rnd.NextDouble();
        GameObject car = direction >= 0.5 ? Instantiate(spawnableCarL) : Instantiate(spawnableCarR);
        if (randNum <= .0035)
        {//spawn car in road 1
            Debug.Log("Spawn in road 1"); //Vector3(27.6200008,0.850000024,-40.9000015)
            if (direction >= 0.5)
            {
                car.transform.position = new Vector3(26.2000008f, 0.850000024f, -80.8000031f);
            }
            else
            {
                car.transform.position = new Vector3(-164f, 0.850000024f, -86.3000031f);
            }
        }
        else if (randNum <= .007)
        {//spawn car in road 2
            Debug.Log("Spawn in road 2"); //Vector3(27.6200008,0.850000024,9.10000038)
            if (direction >= 0.5)
            {
                car.transform.position = new Vector3(26.2000008f, 0.850000024f, -41f);
            }
            else
            {
                car.transform.position = new Vector3(-164f, 0.850000024f, -45.9000015f);
            }
        }
        else if (randNum <= .0105)
        {//spawn car in road 3
            Debug.Log("Spawn in road 3"); //Vector3(27.6200008,0.850000024,49.2999992)
            if (direction >= 0.5)
            {
                car.transform.position = new Vector3(26.2000008f, 0.850000024f, 9.30000019f);
            }
            else
            {
                car.transform.position = new Vector3(-164f, 0.850000024f, 4.0999999f);
            }
        }
        else if (randNum <= .0140)
        {//spawn car in road 4
            Debug.Log("Spawn in road 4"); //Vector3(27.6200008, 0.850000024, -80.4000015)
            if (direction >= 0.5)
            {
                car.transform.position = new Vector3(26.2000008f, 0.850000024f, 49f);
            }
            else
            {
                car.transform.position = new Vector3(-164f, 0.850000024f, 44f);
            }
        }
    }
}
