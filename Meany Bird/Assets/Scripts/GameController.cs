using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("References")]

    public GameObject gameOvercanvas;

    public GameObject scoreCanvas;

    public GameObject spawner; 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        scoreCanvas.SetActive(true);

        gameOvercanvas.SetActive(false);

        spawner.SetActive(true); 
    }

    public void GameOver() 
        {
        gameOvercanvas.SetActive(true);

        spawner.SetActive(false);

        Time.timeScale = 0; 
    }
}
