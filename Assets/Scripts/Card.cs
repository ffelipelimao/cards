using UnityEngine;

public class Card : MonoBehaviour
{

    public bool IsDragging;
    public bool CanDrag;
    public bool Played;

    Canvas canvas;

    public CardManager cardManager;

    void Start()
    {

        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        cardManager = GameObject.Find("CardManager").GetComponent<CardManager>();        
    }
    
}
