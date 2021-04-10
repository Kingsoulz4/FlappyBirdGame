using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isEndgame;
    private int scrores;
    public Text textScore;
    public Text textScoreEndgame;
    public GameObject panelGameOver;
    void Start()
    {
        Pause();
        panelGameOver.SetActive(false);
        isEndgame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&&!isEndgame)
        {
            Continuous();
        }
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
    void Pause()
    {
        Time.timeScale = 0;
    }
    void Continuous()
    {
        Time.timeScale = 1; 
    }
    public void EndGame()
    {
        Debug.Log("Endgame");
        isEndgame = true;
        Time.timeScale = 0;
        panelGameOver.SetActive(true);
        textScoreEndgame.text = "Your scores: " + this.scrores;
    }
    public void setPoints(int points)
    {
        this.scrores = points;
    }
    public int getPoints()
    {
        return this.scrores;
    }
    public void setTextPoint()
    {
        textScore.text = "Score: " + this.scrores;
    }
}
