using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void GoToGameScene ()
    {
        SceneManager.LoadScene("GameScene");
    }
}
