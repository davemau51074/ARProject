using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //GameObject[] m_stairs;
    // List<GameObject> stairs;
   // GameObject stairs;
    public GameObject cube;
    public GameObject currentStairs;
    public GameObject lastStairs;
    public GameObject nextStairs;
    public GameObject stairObj;
    int timer = 0;
    Vector3 m_lastPos;
    Vector3 m_lastPosRot;

    int stairCount = 0;

   // ArrayList<GameObject> stairs;

	// Use this for initialization
	void Start () {

        m_lastPos = new Vector3(100, 0, 0);
        //Debug.Log("Spawning: " + currentStairs.name);
        
        spawn();

    }
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < 1; i++)
        {
            timer += 1;

            if (timer >= 100)
            {
                spawn();

                timer = 0;
            }
        }

    }

    public void spawn()
    {
        Vector3 newPos = m_lastPos;
        Vector3 newRot = m_lastPosRot;
      //  lastStairs = Instantiate(currentStairs, new Vector3(transform.rotate.x, transform.rotate.y - newPos.z, 1));
        newPos.z -= lastStairs.GetComponent<BoxCollider>().bounds.size.y;
        m_lastPosRot = lastStairs.transform.rotation.ToEuler();
        m_lastPosRot.x += (float)3.14 / 2;
        transform.Rotate(Vector3.right * 30);
        lastStairs = Instantiate(currentStairs, new Vector3(transform.position.x, transform.position.y - newPos.z, 1),
        lastStairs.transform.rotation);

        //stairs.Add((GameObject)Instantiate(stairObj, new Vector3(transform.position.x, transform.position.y - newPos.z, 1)));

        //stairs.Add(Instantiate(stairObj, new Vector3(transform.position.x, transform.position.y - newPos.z, 1), Quaternion.identity));

        //if (stairCount > 1)
        //{
        //    stairs.Add(Instantiate(stairObj, new Vector3(transform.position.x, transform.position.y - newPos.z, 1), Quaternion.identity));
        //}


        //stairCount++;



        // for (int i = 0; i <= 3; i++)
        //  {
        //      stairs[i] =  
        //  }

    }


}
