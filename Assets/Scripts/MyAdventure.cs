using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Een lijstje met alle mogelijke states in de game
    private enum States
    {
        start,
        intro,
        delen,
        deelnee,
        deelja,
        leukgesprek
    }

    private States currentState = States.start; // Bijhouden wat de huidige state is
    
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World"); 
        Terminal.WriteLine("In de terminal");
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij HorrorNite");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ start om te beginnen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }else if (input == "1337")
                {
                    Terminal.WriteLine("Jij bent Leet");
                }
                else
                {
                    Terminal.WriteLine("Je moet start typen om te beginnen");
                }
                break;
            case States.intro:
                if (input == "verder")
                {
                    GegevensDelen();
                }
                break;
            case States.delen:
                if (input == "ja")
                {
                    DeelJa();
                }
                else if (input == "nee")
                {
                    DeelNee();
                }
                break;
            default:
                Terminal.WriteLine("Je hebt de game gebroken");
                break;
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een vrijdagavond, en je ouders hadden een datenight");
        Terminal.WriteLine("Typ verder om door te gaan");
        currentState = States.intro;
    }

    void GegevensDelen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Een persoon vraagt om je Discord tag");
        Terminal.WriteLine("Wil je deze delen?");
        Terminal.WriteLine("Typ JA om te delen");
        Terminal.WriteLine("Typ NEE om niet te delen");
        currentState = States.delen;
    }
}
