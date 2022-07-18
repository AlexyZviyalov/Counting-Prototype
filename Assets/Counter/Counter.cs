using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public Text BlueCounterText;
    public Text RedCounterText;
    public Text GreenCounterText;

    private int blueCount = 0;
    private int redCount = 0;
    private int greenCount = 0;

    private Renderer ballRender;

    public Button blueButton;
    public Button redButton;
    public Button greenButton;

    public string chosenColor;
    private string winnerColor;

    public Text Win;
    public Text Lose;
    public Button RestartButton;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        ballRender = other.gameObject.GetComponent<Renderer>();
        if (ballRender.material.color == Color.blue)
        {
            blueCount += 1;
        }
        else if (ballRender.material.color == Color.red)
        {
            redCount += 1;
        }
        else if (ballRender.material.color == Color.green)
        {
            greenCount += 1;
        }

        BlueCounterText.text = "Blue Count : " + blueCount;
        BlueCounterText.color = Color.blue;

        RedCounterText.text = "Red Count : " + redCount;
        RedCounterText.color = Color.red;

        GreenCounterText.text = "Green Count : " + greenCount;
        GreenCounterText.color = Color.green;

        StartCoroutine(CountDown());
    }

    private bool Winner()
    {
        if (blueCount > redCount)
        {
            if (blueCount > greenCount)
            {
                winnerColor = "Blue";
            }
            else
            {
                winnerColor = "Green";
            }
        } else if (redCount > blueCount)
        {
            if (redCount > greenCount)
            {
                winnerColor = "Red";
            }
            else
            {
                winnerColor = "Green";
            }
        }

        if (winnerColor == chosenColor)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(4);

        if (Winner())
        {
            Win.gameObject.SetActive(true);
        }
        else
        {
            Lose.gameObject.SetActive(true);
        }
        RestartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
