using UnityEngine;

public class ScrollPipes : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
    }

    void Update()
    {
        if (GamerManager.Instance.isGameOver)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
