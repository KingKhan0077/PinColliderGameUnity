using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public bool gamehasended = false;
    public Rotator rotator;
    public spawnner spawnner;
    public Animator animator;
    public void EndGame()
    {
        if (gamehasended)
        {
            return;
        }
        gamehasended = true;
        rotator.enabled = false;
        spawnner.enabled = false;
        animator.SetTrigger("EndGame");
        Debug.Log("End game");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Out()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

}
