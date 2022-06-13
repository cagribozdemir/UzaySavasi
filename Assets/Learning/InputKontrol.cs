using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontrol : MonoBehaviour
{
    [SerializeField]
    GameObject astreoidPrefab;

    List<GameObject> asteroidList = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log(Input.mousePosition);

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            for (int i = 0; i < 100; i++)
            {
                asteroidList.Add(Instantiate(astreoidPrefab, position, Quaternion.identity));
            }
            
        }

        //if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("Pressed left click.");
        //}

        if (Input.GetMouseButtonDown(1))
        {
            
            Debug.Log(asteroidList.Count);

            foreach (GameObject asteroid in asteroidList)
            {
                Destroy(asteroid);
            }

            asteroidList.Clear();

            //for (int i = 0; i < asteroidList.Count; i++)
            //{
            //    Destroy(asteroidList[i]);
            //}
        }

        //if (Input.GetMouseButton(2))
        //{
        //    Debug.Log("Pressed middle click.");
        //}

    }
}
