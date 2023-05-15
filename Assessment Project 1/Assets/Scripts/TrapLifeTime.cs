using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLifeTime : MonoBehaviour
{
    //Determines the duration of the trap before being destroyed
    public float lifetime = 10.0f;

    void Awake()
    {
        //Destroys enemy when lifeime limit reaches 10.0f
        Destroy(gameObject, lifetime);
    }

}
