using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootsGameManager : MonoBehaviour
{
    //private bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject failLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        failLevelUI.SetActive(true);
        // if (gameHasEnded == false)
        // {
        //     gameHasEnded = true;
        //     Debug.Log("Game Over");
        //     Invoke("Restart", restartDelay);
        // }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart");
    }
}
