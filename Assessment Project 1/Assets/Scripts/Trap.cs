using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        // If trap collides with enemy, destroy it
        if (other.gameObject.name == "Enemy(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
