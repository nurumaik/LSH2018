using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GodScript : MonoBehaviour {
    public int score = 0;
    public Text scoreText;
    public Text timerText;
    public int secondsLeft = 20;
    public int normalTargetsCount = 10;
    public int timeTargetsCount = 3;
    public Rect spawnRect;
    private int maxScore;

    public Transform normalTarget;
    public Transform timeTarget;

    public Vector2 windPerSecond = new Vector2(0, 0);

	// Use this for initialization
	void Start () {
        maxScore = normalTargetsCount + timeTargetsCount;
        InvokeRepeating("SubstractTime", 1f, 1f);
        for (int i = 0; i < normalTargetsCount; ++i)
        {
            Instantiate(normalTarget, new Vector3(Random.Range(spawnRect.xMin, spawnRect.xMax), Random.Range(spawnRect.yMin, spawnRect.yMax)), Quaternion.identity);
        }
        for (int i = 0; i < timeTargetsCount; ++i)
        {
            Instantiate(timeTarget, new Vector3(Random.Range(spawnRect.xMin, spawnRect.xMax), Random.Range(spawnRect.yMin, spawnRect.yMax)), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        if (score >= maxScore)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        UltraGodScript.LastMaxScore = maxScore;
        UltraGodScript.LastScore = score;
        SceneManager.LoadScene("GameOverScene");
    }

    private void redrawTime()
    {
        timerText.text = "Time left: " + secondsLeft;
    }

    void SubstractTime()
    {
        secondsLeft--;
        if (secondsLeft <= 0)
        {
            GameOver();
        }
        redrawTime();
    }

    public void AddTime()
    {
        secondsLeft += 5;
        redrawTime();
    }
}
