using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public enum Resources { airPollution, soilPollution, waterPollution, landUse, biodiversity, currency, population }

public enum Characters { alien, cook, farmer, geekyGirl, hotdog, jorji, lightBulb, octoGirl, protester, queenKing, rabbit, salesman, sheep, snake, teenager }

//This is a storage class to hold 2 dialogs. It keeps a state depending on the dis-/approve bottun hit. It get's handled in the resourcesManager.
[Serializable]
public class Choice : ScriptableObject {
    [Header("Dilemma: ")]
    [TextArea()]
    public string Dilemma;

    [Header("Character name: ")]
    [TextArea()]
    public string Name;

	[Header("Character: ")]
	public Characters character;
    [Header("State:")]
    public State State;
    [Header("Positive Dialog")]
    public Dialog PositiveDialog;

    [Header("Negative Dialog")]
    public Dialog NegativeDialog;

}

public enum State {
    Positive,
    Negative,
    Neutral
}


