using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartUI : MonoBehaviour
{

    public TextMeshProUGUI bestPlayer;
    public TextMeshProUGUI highScore;
    public TMP_InputField currentPlayer;

    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance.LoadScore();
        bestPlayer.text = "Top player: " + MainManager.Instance.bestPlayer;
        highScore.text = "High score: " + MainManager.Instance.highScore;
    }

    public void EntryGame()
    {
        MainManager.currentPlayer = currentPlayer.text;

        MainManager.hasPlayer = true;

        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
