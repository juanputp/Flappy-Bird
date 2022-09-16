using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 200f;
    private Rigidbody2D playerRB;
    private Animator playerAnimator;
    private bool isDead;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && !isDead)
        {
            Fly();
        }
    }

    private void Fly()
    {
        playerRB.velocity = Vector2.zero;
        playerRB.AddForce(Vector2.up * upForce);
        playerAnimator.SetTrigger("Fly");
    }
    private void OnCollisionEnter2D()
    {
        isDead = true;
        playerAnimator.SetTrigger("Die");
        GamerManager.Instance.GameOver();
    }
}
