using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Painel;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
    }

    public void GameOver(){
        Time.timeScale = 0;
        Painel.SetActive(true);
        gameOver = true;
    }

    public void Restart(){
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
