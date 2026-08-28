using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavePlayerName : MonoBehaviour
{
    public TMP_InputField nameInput;

    void Start()
    {
        nameInput.text = PlayerPrefs.GetString("PlayerName", "");
    }

    public void SaveName()
    {
        string playerName = nameInput.text.Trim();

        if (playerName == "")
        {
            playerName = "Player";
        }

        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        SceneManager.LoadScene("intro");
    }
}
