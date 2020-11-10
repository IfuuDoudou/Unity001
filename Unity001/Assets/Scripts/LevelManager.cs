
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void NextLevel (string naneLV)
    {
        SceneManager.LoadScene(naneLV);
    }
    public void  BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
