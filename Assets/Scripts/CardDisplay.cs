using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;

	public Text nameText;
	public Text descriptionText;
	public Text typeText;

	public Image artworkImage;

	public Text manaText;
	public Text attackText;
	public Text healthText;

	// Use this for initialization

	private void Start(){
		DisplayCard();
	}

	private void DisplayCard () {
		nameText.text = card.name;
		descriptionText.text = card.description;
		typeText.text = card.type;

		artworkImage.sprite = card.artwork;

		manaText.text = card.manaCost.ToString();
		attackText.text = card.attack.ToString();
		healthText.text = card.health.ToString();
	}
}
