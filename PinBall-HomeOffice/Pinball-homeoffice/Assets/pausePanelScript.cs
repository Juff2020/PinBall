using UnityEngine;
using UnityEngine.SceneManagement;

public class pausePanelScript : MonoBehaviour
{

    public GameObject pausePanel;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            Unpause();
        }
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Unpause()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
