using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0)*Time.deltaTime);
    }
}
