using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public string playerName;

    public void StartGame()
    {
		playerName = nameInput.text;
        MainManager.playerName = playerName;

		SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
	}
}
