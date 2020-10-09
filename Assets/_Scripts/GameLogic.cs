using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Pilha de compras
    public Temp_DrawPile drawPile;

    // Pilho de jogo
    public Temp_PlayPile playPile;

    // Mãos do Jogadores
    public Temp_Hand playerHand;


    [Header("Temp Tests")]
    public SO_Card card1;
    public SO_Card card2;


    [ContextMenu("CompareCards")]
    void CompareCards()
    {
        if((card1.consonant == card2.consonant) || (card1.vowel == card2.vowel))
        {
            Debug.Log("Card match!");
        }
        else
        {
            Debug.Log("Card DON'T match!");
        }
    }


}
