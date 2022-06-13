using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] grounds;
    public float groundNumbs;

    private int currentLevel;

    void Start()
    {
        grounds = GameObject.FindGameObjectsWithTag("Ground");
        currentLevel = SceneManager.GetActiveScene().buildIndex; 

    }
   
    void Update()
    {
        groundNumbs = grounds.Length;
    }

    public void LevelUpdate(){
        SceneManager.LoadScene(currentLevel+1);
    }
}
