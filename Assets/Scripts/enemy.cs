using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float hp=100f;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 void OnTriggerEnter(Collider other)
    {
        hp-=25;       
          if (hp<=0)
{    
    Destroy(gameObject);
}
    }
 
}
