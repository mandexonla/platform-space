using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        CoinManager.Instance.Addpoint(0);
        GameOverUI.Instance.gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
