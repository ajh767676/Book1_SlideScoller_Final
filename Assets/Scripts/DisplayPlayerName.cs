using TMPro;
using UnityEngine;

public class DisplayPlayerName : MonoBehaviour
{
    public TMP_Text nameText;

    void Start()
    {
        string playerName =
            PlayerPrefs.GetString("PlayerName", "Player");

        nameText.text = playerName;
    }
}