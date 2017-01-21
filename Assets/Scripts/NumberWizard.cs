using UnityEngine;

public class NumberWizard: MonoBehaviour
{
    int max;
    int min;
    int guess;

    /// <summary>
    /// Initialise
    /// </summary>
    void Start()
    {
        StartGame();
    }

    /// <summary>
    /// Start the game
    /// </summary>
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me.");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up Arrow for higher, Down Arrow for lower, Return to equal");

        max = max + 1;
    }

    /// <summary>
    /// Calculates the next guess
    /// </summary>
    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + "?");
        print("Up Arrow for higher, Down Arrow for lower, Return to equal");
    }

    /// <summary>
    /// Updates once per frame
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }
}
