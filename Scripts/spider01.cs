using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider01 : MonoBehaviour
{
    public float speed = 2f;
    public float otherspeed = 6f;
    public float dist;

    [SerializeField] private GameObject egg;


    void Update()
    {
        var step =  speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, egg.transform.position, step);
        
    if(dist < 20)
        {
            var otherstep =  otherspeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, egg.transform.position, step);
        }


    }
}
