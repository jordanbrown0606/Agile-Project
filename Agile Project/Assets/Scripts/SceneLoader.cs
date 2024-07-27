using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame(string sceneName)
    {
        SaveLoad.Delete("SaveFile");
        SceneManager.LoadScene(sceneName);
    }
}
