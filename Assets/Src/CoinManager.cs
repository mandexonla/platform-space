using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    void Awake()
    {
        Instance = this;
    }

    private int _score = 0;
    [SerializeField] private TextMeshProUGUI _scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Addpoint(int point)
    {
        _score += point;
        UpdateScrore();
    }

    private void UpdateScrore()
    {
        _scoreText.text = _score.ToString();
    }
}
