using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveDelay());
        Debug.Log("Coroutine running");
        
    }

    IEnumerable MoveDelay()
    {

    }

    void NewPosition()
    {

        //Need variable for x position and z position
        //Need random number, based off our parameters

        float xPos = Random.Range(-25.0f, 25.0f);
        float zPos = Random.Range(-25.0f, 25.0f);

        //Output X,Z: 24.023.9
        Debug.Log("X,Z: " + xPos.ToString("F2") + ", " + zPos.ToString("F2"));

        transform.position = new Vector3(xPos, 0.0f, zPos);

    }
}

