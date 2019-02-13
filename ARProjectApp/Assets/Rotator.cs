using UnityEngine;

using System.Collections;



/// <summary>

/// Author: Dylan Murphy

/// Date: 28/11/2017

/// Rotates sphere

/// </summary>



public class Rotator : MonoBehaviour
{



    public float speed;



    void Update()

    {

        transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * speed);

    }

}