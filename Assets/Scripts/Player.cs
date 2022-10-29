using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRB;
    public float bounceForce = 6;

    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    //public AudioSource bounceAudio;

    private void OnCollisionEnter(Collision collision)
    {
        audioManager.Play("bounce");
        //bounceAudio.Play();
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounceForce, playerRB.velocity.z);
        //Debug.Log(collision.transform.GetComponent<MeshRenderer>().material.name;
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if (materialName == "Safe (Instance)")
        {
            //The ball hits the safe area

        } else if (materialName == "Unsafe (Instance)")
        {
            //The ball hits the unsafe area
            //Debug.Log("Game Over");
            GameManager.gameOver = true;
            audioManager.Play("game over");
        }
        else if (materialName == "LastRing (Instance)" && !GameManager.levelCompleted)
        {
            //We completed the Level
            //Debug.Log("Level Completed");
            GameManager.levelCompleted = true;
            audioManager.Play("win level");
        }
    }
}
