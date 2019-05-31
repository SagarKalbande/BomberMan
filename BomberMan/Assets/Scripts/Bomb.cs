using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("entered");
        if (other.tag == "brick")
        {
            Debug.Log(other.gameObject);
            Destroy(other.gameObject);
            
        }
    }
}
