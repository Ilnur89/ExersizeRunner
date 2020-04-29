
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageGame : MonoBehaviour
{
    public bool HasEndede = false;
    public float delay = 2f;
    public GameObject completelevelUI;

    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (HasEndede == false)
        {
            HasEndede = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
