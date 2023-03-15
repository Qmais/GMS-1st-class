using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float delayTime = 0.1f;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(delayTime >= 5f)
        {
            Vector3 position = new Vector3(Random.Range(-8f, 8f), 6, 0);
            Instantiate(arrowPrefab, position, Quaternion.identity);
            delayTime = 0;
        }
        delayTime += Time.deltaTime;
    }
}
