using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungsBehaviorScript : MonoBehaviour
{
    public float speed = 15.0f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
 
    }
}
