using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour{

    public Card card;

    public Text nameText;

    // Card Manager
   public CardManager cardManager;
   public GameObject[] cardSlots;

   // Page Manager
   public int page;
   public Text pageText;

   private void Start(){
       DisplayCards();
   }

   private void Update(){
       UpdatePage();

       if(Input.GetKeyDown(KeyCode.D)){ // Next Page
            // If the page is greater than or equal than the cards total number divided by 8 -> page turn back to 0 
            if (page >= Mathf.Floor(cardManager.cards.Count - 1) / 8){
                page = 0;
            }  else {
                page++;
            }
            Debug.Log(page);
            DisplayCards();
       }

        if(Input.GetKeyDown(KeyCode.A)){ // Next Page
            // If the page is less than or equal than 0, the page should turn to the cards total number divided by 8
            if (page <=0){
                page = Mathf.FloorToInt((cardManager.cards.Count -1) / 8);
            }
            else {
               page--; 
            }
            Debug.Log(page);
            DisplayCards();
       }
   }

    private void UpdatePage(){
        // pageText.text = (page + 1).ToString();
        pageText.text = (page + 1) + "/" + (Mathf.Ceil(cardSlots.Length / 8) + 1).ToString();    // Current page + "/" + Max page
    }

    private void DisplayCards(){
        nameText.text = card.name;
    }
}
