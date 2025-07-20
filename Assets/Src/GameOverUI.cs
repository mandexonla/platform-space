using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI Instance;


    void Awake()
    {
        Instance = this;
    }

    [SerializeField] public GameObject gameOverUI;
    private bool _isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowGameOverUI()
    {
        _isGameOver = true;
        CoinManager.Instance._score = 0;
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        _isGameOver = false;
        CoinManager.Instance._score = 0;
        CoinManager.Instance.UpdateScrore();
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
