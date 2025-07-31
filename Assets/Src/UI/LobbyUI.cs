using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyUI : MonoBehaviour
{
    [SerializeField] private Button PlayGameButton;
    [SerializeField] private Button OptionButton;
    [SerializeField] private Button QuitButton;

    private void Awake()
    {
        PlayGameButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.GameScene);
        });

        QuitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GameQuit()
    {
        Application.Quit();
    }
}
