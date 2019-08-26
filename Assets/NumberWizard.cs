using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max ;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
            

        //Detect when the up arrow key has been released
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();

        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
        }

    }

    void startGame()
    {
         min = 1;
         max = 1000;
         guess = 500;
        Debug.Log("Welcome to Number Wizard ");
        Debug.Log("Pick a number and dont let me know what it is");
        Debug.Log("The Highest number you can pick is: " + max);
        Debug.Log("The Lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

    void nextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
