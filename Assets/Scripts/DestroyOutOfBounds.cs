using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public int destroy_distance_food = 30;
    public int destroy_distance_animal = -20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z > destroy_distance_food)
        {
            Destroy(gameObject);
        } 

        else if(transform.position.z < destroy_distance_animal)
        {
            Destroy(gameObject);
        }

    }
}
