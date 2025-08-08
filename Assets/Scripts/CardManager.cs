using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [HideInInspector] public GameObject SelectedCard;
    [HideInInspector] public GameObject HoveringMenu;
    public CardLayoutGroup cardLayoutGroup;
    public GameObject CardsParent;
    public List<GameObject> CardsFaces = new List<GameObject>();

    private void Start()
    {
        AddCard();
    }

    public void AddCard()
    {
        if (cardLayoutGroup.transform.childCount < 3)
        {
            GameObject Card = Instantiate(CardsParent, cardLayoutGroup.transform);
            int randomCard = Random.Range(0, CardsFaces.Count);
            GameObject cardFace = Instantiate(CardsFaces[randomCard], GameObject.Find("CardVisuals").transform);

            cardFace.GetComponent<CardFace>().target = Card.GetComponentInChildren<Card>().gameObject;
        }
    }

}
