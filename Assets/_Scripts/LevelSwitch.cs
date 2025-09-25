using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public int nextLevelID = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LoadScene(nextLevelID);
        }
    }
    public void LoadScene(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }
}