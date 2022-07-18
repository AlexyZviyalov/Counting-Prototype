using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    private Button colorButton;
    private Counter counterScript;
    private GameObject buttons;
    public GameObject fakeSpheres;
    public GameObject spheres;
 
    public Text rulesText;
    //private Renderer colorOfButton;

    // Start is called before the first frame update
    void Start()
    {
        colorButton = GetComponent<Button>();
        buttons = GameObject.Find("Buttons");
        counterScript = GameObject.Find("DropBox").GetComponent<Counter>();
        colorButton.onClick.AddListener(ColorBet);
    }

    void ColorBet()
    {
        SetVisibility();
        
        if (colorButton.gameObject.name == "Blue button")
        {
            counterScript.chosenColor = "Blue";
            
        }
        else if (colorButton.gameObject.name == "Red button")
        {
            counterScript.chosenColor = "Red";
            
        }
        else if (colorButton.gameObject.name == "Green button")
        {
            counterScript.chosenColor = "Green";
        }

    }

    void SetVisibility()
    {
        rulesText.gameObject.SetActive(false);
        buttons.gameObject.SetActive(false);
        fakeSpheres.gameObject.SetActive(false);
        spheres.gameObject.SetActive(true);
    }
}
