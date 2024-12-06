using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public void StartGame()
    {
        // Load the main game scene (replace "MainScene" with your scene name)
        SceneManager.LoadScene("MainScene");
    }
}
