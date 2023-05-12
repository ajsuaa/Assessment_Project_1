using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private Rigidbody playerRb;
    //boundarys for z axis (up and down)
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
    }

    //Moves the player based on arrow key input
    void MovePlayer()
    {
        //How the player is controlled (going horizontally and vertically,  move, left, up, down)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //applying the speed and stuff when controlling player model
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

        private void OnCollisionEnter(Collision other)
    {
        // When enemy collides with trap, destroy it 
        if (other.gameObject.name == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
