using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Health damage; //health of this enemy uses Health script

    public GameObject target; //target is the player
    public float speed; // speed for movement

    public float distance; // distance from target

    // Start is called before the first frame update
    void Start()
    {
        damage = target.GetComponent<Health>(); // initializes damage object
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position); // sets distance to distance form target
        Vector2 direction = target.transform.position - transform.position; // finds direction to move

        if (distance < 10) // if less than 10 units away
        {
            transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed + Time.deltaTime); // move towrds target
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player") // if it touches player
        {
            damage.TakeDamage(1); //takes 1 damage
            Destroy(gameObject); // self destructs
        }
    }
}
