using UnityEngine;
using UnityEngine.SceneManagement; // 1. Added this line

public class EntryToNextLevel : MonoBehaviour
{
    // 2. Deleted "public Scene SceneManager;" - You don't need it!

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && PlayerStats.hasTeleport == true)
        {
            // Now this calls the built-in Unity tool directly
            SceneManager.LoadScene(3);

            // Ensure AudioManager exists before calling it to prevent errors
            if (AudioManager.Instance != null)
            {
                AudioManager.Instance.PlayMusic(AudioManager.Instance.caveMusic);
            }
        }
        else
        {
            FindObjectOfType<LevelManager>().RespawnPlayer();
        }
    }
}