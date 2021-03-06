﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bartok : MonoBehaviour {
	static public Bartok S;

	[Header("Set in Inspector")]
	public TextAsset	deckXML;
	public TextAsset layoutXML;
	public Vector3 layoutCenter = Vector3.zero;

	[Header("Set Dynamically")]
	public Deck deck;
	public List<CardBartok> drawPile;
	public List<CardBartok> discardPile;
	// Use this for initialization
	void Awake () {
		S = this;
	}
	
	// Update is called once per frame
	void Start () {
		deck = GetComponent<Deck> ();
		deck.InitDeck (deckXML.text);
		Deck.Shuffle (ref deck.cards);
	}
}
