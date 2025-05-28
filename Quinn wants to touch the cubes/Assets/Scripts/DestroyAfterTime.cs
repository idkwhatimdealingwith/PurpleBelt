using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Destruction Timer")]
    // after this time, the object will be destroyed
    public float timeToDestruction; 
    // Start is called before the first frame update
    void Start()
    {
        //Execute function based on timetoDestruction
        Invoke("DestroyObject", timeToDestruction);
    }

    void DestroyObject()
        
    {
        //Destory Gameobject 
        Destroy(gameObject);
    }
}

