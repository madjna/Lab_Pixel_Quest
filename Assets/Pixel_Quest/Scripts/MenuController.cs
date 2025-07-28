using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string nextLevel;
    // Start is called before the first frame update
   public void loadLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
