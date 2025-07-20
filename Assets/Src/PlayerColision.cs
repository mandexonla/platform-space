using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    private GameOverUI _gameOverUI;
    private CoinManager _coinManager;

    private void Awake()
    {
        // Lay GameManager de co the goi cac ham cua no
        _coinManager = FindAnyObjectByType<CoinManager>();
        _gameOverUI = FindAnyObjectByType<GameOverUI>();
    }

    /*function nay dc goi khi ma player game va cham vs thanh phan 
         * collider, ma nhung thanh phan collider do dc tich isTrigger, thi khi plyer cham vao
         * se goi vai function nay*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* kiem tra cai tag cua collider da dc tich la isTrigger phai la Coin hay ko */
        if (collision.CompareTag("Coin")) //Coin la cai tag da them vao
        {
            Destroy(collision.gameObject);
            _coinManager.Addpoint(1); // goi ham Addpoint cua GameManager de cong diem
        }
        else if (collision.CompareTag("Trap"))
        {
            _gameOverUI.ShowGameOverUI();
        }
    }
}
