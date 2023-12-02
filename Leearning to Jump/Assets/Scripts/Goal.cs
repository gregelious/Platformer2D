using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other) // collision function
    {

        if (other.gameObject.CompareTag("Player")) //if it touches  player
        {
            SceneManager.LoadScene("Level2"); //load level 2 scene
        }

    }

}