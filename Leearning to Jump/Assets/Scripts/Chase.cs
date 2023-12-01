using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Health damage;

    public GameObject target;
    public float speed;

    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        damage = target.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);
        Vector2 direction = target.transform.position - transform.position;

        if (distance < 10)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed + Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
            Destroy(gameObject);
        }
    }
}
