using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI Instance;
    [SerializeField] public GameObject gameOverUI;
    [SerializeField] private Button playAgainButton;
    public bool _isGameOver;

    private void Awake()
    {
        playAgainButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.SampleScene);
        });

        Instance = this;
    }

    public void ShowGameOverUI()
    {
        _isGameOver = true;
        CoinManager.Instance._score = 0;
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }
}
