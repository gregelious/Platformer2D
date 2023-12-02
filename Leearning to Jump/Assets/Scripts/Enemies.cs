using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    //variables for the game
    Health damage;// damage is an object using Health class

    public GameObject hitPoints; //hisPoints is an object

    // Vector2 direction;

    public float speed; //variable for movement speed
    public bool left = true; // sees if enemy is moving left or not

    // Start is called before the first frame update
    void Start()
    {
        damage = hitPoints.GetComponent<Health>(); //initializes Enemies
    }

    // Update is called once per frame
    void Update()
    {
        if (left) //if left is true
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y); // enemy moves left
        }

        else
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);// moves right
        }


    }

    void OnTriggerEnter2D(Collider2D coll) // collision function
    {
        if (coll.tag == "Player") //if it touches player
        {
            damage.TakeDamage(1); // takes one damage
        }

        if (coll.tag == "Wall" && left == true) //if it touches wall and its moving left
        {
            left = false; //go right
        }

        else if (coll.tag == "Wall" && left == false) //if it touches wall and its moving right
        {
            left = true; // go left
        }
    }

    
}
