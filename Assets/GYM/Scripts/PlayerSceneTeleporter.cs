using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneTeleporter : MonoBehaviour
{
    private void OnEnable ()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable ()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded (Scene scene, LoadSceneMode mode)
    {
        // Nađi spawn u toj sceni
        var spawns = FindObjectsOfType<SceneSpawnPoint>();
        foreach (var s in spawns)
        {
            // Match po imenu scene ili po id (ti biraj)
            // Ovde koristim ime scene:
            if (s.id == scene.name || s.id == scene.name.Replace("Scene", ""))
            {
                transform.position = s.transform.position;
                return;
            }
        }

        // Ako ti je lakše: direktno po imenu objekta
        // (alternativa) GameObject.Find("Spawn_Game") itd.
    }
}
