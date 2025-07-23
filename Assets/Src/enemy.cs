using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private float speedEnemy = 2f;
    [SerializeField] private float distanceEnemy = 5f;
    private Vector3 enemySpawn;
    private bool movingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        enemySpawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float leftBound = enemySpawn.x - distanceEnemy;
        float rightBound = enemySpawn.x + distanceEnemy;

        if (movingRight)
        {
            transform.Translate(Vector2.right * speedEnemy * Time.deltaTime);
            if (transform.position.x >= rightBound)
            {
                movingRight = false;
                FlipEnemy();
            }
        }
        else
        {
            transform.Translate(Vector2.left * speedEnemy * Time.deltaTime);
            if (transform.position.x <= leftBound)
            {
                movingRight = true;
                FlipEnemy();
            }
        }
    }
    private void FlipEnemy()
    {
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
