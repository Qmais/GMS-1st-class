using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        if (Input.GetKeyDown(KeyCode.RightArrow));
        transform.position = transform.position + Vector3.right;// new Vector3(1, 0, 0);
        
    }
}
