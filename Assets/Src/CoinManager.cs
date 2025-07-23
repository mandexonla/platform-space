using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    public static CoinManager Instance;
    void Awake()
    {
        Instance = this;
    }

    public int _score = 0;

    public void Addpoint(int point)
    {
        if (!GameOverUI.Instance._isGameOver && !gamewinUI.Instance._isGameWinUI)
        {
            _score += point;
            UpdateScrore();
        }
    }

    public void UpdateScrore()
    {
        _scoreText.text = _score.ToString();
    }
}
