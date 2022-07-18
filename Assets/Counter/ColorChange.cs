using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Color blueColor;
    private Color redColor;
    private Color greenColor;
    private List<Color> ballsColors;
    private Renderer ballRender;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        ballsColors =  ListOfColors();
        ColorBall(ballsColors);       
    }

    //create list of colors
    public List<Color> ListOfColors()
    {
        blueColor = Color.blue;
        redColor = Color.red;
        greenColor = Color.green;
        List<Color> ballsColors = new List<Color>();
        ballsColors.Add(blueColor);
        ballsColors.Add(redColor);
        ballsColors.Add(greenColor);
        return ballsColors;

    }

    //randomly assign color to ball
    void ColorBall(List<Color> ballsColors)
    {
        ballRender = gameObject.GetComponent<Renderer>();
        randomIndex = Random.Range(0, ballsColors.Count);
        ballRender.material.color = ballsColors[randomIndex];

    }



}
    
