using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public TMP_Text highScoreText;
    public TMP_Text lastScoreText;
    public TMP_Text pressEnter;

    public Button startButton;
    public Button optionsButton;
    public Button exitButton;

    int highScore;
    int lastScore;

    Button[] buttons;

    int selected;

    void Start()
    {
        highScore =
        PlayerPrefs.GetInt(
        "HighScore",
        0);

        lastScore =
        PlayerPrefs.GetInt(
        "LastScore",
        0);

        UpdateUI();

        buttons =
        new Button[]
        {
            startButton,
            optionsButton,
            exitButton
        };

        StartCoroutine(
        BlinkText());
    }

    void Update()
    {
        if (Input.GetKeyDown(
        KeyCode.DownArrow))
        {
            selected++;

            if (selected >= 3)
                selected = 0;
        }

        if (Input.GetKeyDown(
        KeyCode.UpArrow))
        {
            selected--;

            if (selected < 0)
                selected = 2;
        }

        Highlight();

        if (Input.GetKeyDown(
        KeyCode.Return))
        {
            buttons[selected]
            .onClick
            .Invoke();
        }
    }

    void Highlight()
    {
        for (int i = 0;
        i < 3;
        i++)
        {
            ColorBlock c =
            buttons[i].colors;

            if (i == selected)
            {
                c.normalColor =
                Color.cyan;
            }

            else
            {
                c.normalColor =
                new Color(
                0,
                0.25f,
                0.45f);
            }

            buttons[i].colors =
            c;
        }
    }

    IEnumerator BlinkText()
    {
        while (true)
        {
            pressEnter.enabled =
            !pressEnter.enabled;

            yield return
            new WaitForSeconds(
            0.5f);
        }
    }

    void UpdateUI()
    {
        highScoreText.text =
        "HIGH SCORE : "
        + highScore;

        lastScoreText.text =
        "LAST SCORE : "
        + lastScore;
    }

    public void StartGame()
    {
        int score =
        Random.Range(
        1000,
        20000);

        lastScore = score;

        if (score > highScore)
        {
            highScore = score;
        }

        PlayerPrefs.SetInt(
        "HighScore",
        highScore);

        PlayerPrefs.SetInt(
        "LastScore",
        lastScore);

        PlayerPrefs.Save();

        UpdateUI();

        SceneManager.LoadScene(
        "GameScene");
    }

    public void Options()
    {
        Debug.Log(
        "Options");
    }

    public void Exit()
    {
        Application.Quit();
    }
}