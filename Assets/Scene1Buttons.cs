using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Buttons : MonoBehaviour
{
    public void GoToGameScene ()
    {
        SceneManager.LoadScene("New Scene");
    }
}
