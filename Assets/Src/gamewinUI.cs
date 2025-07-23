using UnityEngine;

public class gamewinUI : MonoBehaviour
{
    public static gamewinUI Instance;
    [SerializeField] private GameObject gameWinUI;
    public bool _isGameWinUI = false;

    private void Awake()
    {
        Instance = this;
        gameWinUI.SetActive(false);
    }

    public void GameWin()
    {
        _isGameWinUI = true;
        Time.timeScale = 0f;
        gameWinUI.SetActive(true);
    }

    public bool isShowGameWinScreen()
    {
        return _isGameWinUI;
    }
}
