using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt(ScoreHandlerBehaviour.HighScoreKey, 0);

        highScoreText.text = $"High Score: {highScore}";
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
