using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdBehaviors : MonoBehaviour
{
    // Start is called before the first frame update
    public float flyForce;
    GameObject gameController;
    public AudioClip flyAudio;
    public AudioClip gameOverAudio;
    private AudioSource audioSourses;
    int points;
    void Start()
    {
        points = 0;
        audioSourses = GetComponent<AudioSource>();
        gameController = GameObject.FindGameObjectWithTag("GameController");
        audioSourses.clip = flyAudio;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)&& !gameController.GetComponent<gameControl>().isEndgame)
        {
            audioSourses.Play();
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyForce));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!gameController.GetComponent<gameControl>().isEndgame)
        {
            audioSourses.clip = gameOverAudio;
            audioSourses.Play();
        }
        gameController.GetComponent<gameControl>().EndGame();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        points++;
        gameController.GetComponent<gameControl>().setPoints(points);
        gameController.GetComponent<gameControl>().setTextPoint();
    }


}
