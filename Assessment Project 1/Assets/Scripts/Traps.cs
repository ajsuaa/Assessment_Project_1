using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public float lifetime = 10.0f;

    void Awake()
    {
        //Destroys enemy when lifeime limit reaches 10.0f
        Destroy(gameObject, lifetime);
    }


}
