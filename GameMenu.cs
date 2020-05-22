using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    private int nextScene;

    public void loadNext() {
        SceneManager.LoadScene(nextScene);
        Debug.Log("LOAD");
    }

    private void Start() { 
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void QuitGame() { 
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Finish() {
        SceneManager.LoadScene("Menu");
        Debug.Log("LOAD");
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Player") {
            SceneManager.LoadScene(nextScene);
        }
    }
}
