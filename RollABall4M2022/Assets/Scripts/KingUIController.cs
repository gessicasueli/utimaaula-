using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KingUIController : MonoBehaviour
{
    // referencia para o objeto de texto da interface
    [SerializeField] private TMP_Text KingText;
    private void OnEnable()
{
    // Se inscreve no canal de coins
    PlayerObserverManager.OnKingChanged += UpdateKingText;
}

private void OnDisable()
{
    // Retira a inscrição no canal de coins
    PlayerObserverManager.OnKingChanged -= UpdateKingText;
}

// funcao usada para tratar a notificacao do canal
// de coins
private void UpdateKingText(int newKingValue)
{
    // atualiza o valor das moedas na interface
    KingText.text = newKingValue.ToString();
}
    
    
}
