using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    //Allows the enemy to gain momentum
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    private GameObject trap;
 


    // Start is called before the first frame update
    void Start()
    {
        //Allows enemy to find player's current location
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //Enemy moves towards the player's direction, the speed of the enemy depends on how far away the player is
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

    }

    private void OnCollisionEnter(Collision other)
    {
        // When enemy collides with a trap, destroy it 
        if (other.gameObject.name == "Trap(Clone)")
        {
            Destroy(gameObject);
        }    
    }
}

