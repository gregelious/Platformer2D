using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int maxHealth; //maximum health it can have
    public int currentHealth; // health right now

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2; // sets the lives to 2
        currentHealth = maxHealth; //makes the health right now the maximum it can be
    }

    void TakeDamage(int amount) //function to lose health
    {
        currentHealth -= amount; //health goes down by 'amount'

        if (currentHealth <= 0) //if health right now less than or equal to 0
        {
            SceneManager.LoadScene("GameOver"); //Loads end scene
        }
    }

    void OnTriggerEnter2D(Collider2D coll) // collider function
    {
        if (coll.tag == "Player") //if it touches player
        {
            TakeDamage(1); //loses one health
        }
    }
}
