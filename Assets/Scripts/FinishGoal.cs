using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("exit");
        }
    }
}