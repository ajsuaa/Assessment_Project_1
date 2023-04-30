using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //enemy following player
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    private GameObject trap;
    // Start is called before the first frame update
    void Start()
    {
        //enemy following player
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //enemy following player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with traps, destroy it
        if (other.gameObject.name == "Trap(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
