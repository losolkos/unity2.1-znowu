using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
    public void NewGame()
    {
        SceneManager.LoadScene("level1");

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainmanu");
    }

    public void Reset()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1;
    }
}
