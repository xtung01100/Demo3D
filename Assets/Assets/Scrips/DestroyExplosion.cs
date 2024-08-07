using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    public int lifetime = 5;

    void Start()
    {
        Destroy(gameObject, lifetime);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
