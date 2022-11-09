using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spidergroup : MonoBehaviour
{
    
    [SerializeField] private GameObject egg;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject mumspider;
    public float dist;
    public float speed = 6f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, egg.transform.position);
        
        if(dist < 20)
        {
            var step =  speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, egg.transform.position, step);
        }

    }
}
