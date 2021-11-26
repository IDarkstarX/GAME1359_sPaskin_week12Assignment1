using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpTarget : MonoBehaviour
{

    [SerializeField]
    Transform[] paths;
    Transform nextPath;
    int pathIndex = 0;

    [SerializeField]
    float speed;
    [SerializeField]
    float dist;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, nextPath.position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, nextPath.position) < dist)
        {
            pathIndex++;
            if(pathIndex >= paths.Length)
            {
                pathIndex = 0;
            }
            UpdateTarget();
        }
    }

    void UpdateTarget()
    {
        nextPath = paths[pathIndex];
    }
}
