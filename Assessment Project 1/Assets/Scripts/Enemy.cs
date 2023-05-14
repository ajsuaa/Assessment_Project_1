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
        //Allows enemy to constantly find player
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy goes to player's direction
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

    }

    private void OnCollisionEnter(Collision other)
    {
        // When enemy collides with trap, destroy it 
        if (other.gameObject.name == "Trap(Clone)")
        {
            Destroy(gameObject);
        }

       //When the enemy is out of bounds and is falling, destroy it
        if (transform.position.y < -1)
        { 
        Destroy (gameObject);
        }

     
    }
}
