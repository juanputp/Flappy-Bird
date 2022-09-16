using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GamerManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverText;
    [SerializeField] private TMP_Text scoreText;
    private static GamerManager instance;
    public static GamerManager Instance { get { return instance; } }
    
    public bool isGameOver;

    private int score;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isGameOver)
        {
            RestartGame();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
