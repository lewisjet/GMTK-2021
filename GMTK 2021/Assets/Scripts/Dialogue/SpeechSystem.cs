using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using System;

public class SpeechSystem : MonoBehaviour
{
    [SerializeField] private GameObject _dialogueBox;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private DialogueLine[] _dialogueRaw;

    private Dictionary<string,string> _dialogueDictionary;

    private void Awake() 
    {
        _dialogueDictionary = new Dictionary<string, string>();
        Array.ForEach(_dialogueRaw,i => _dialogueDictionary.Add(i.id,i.lineOfText));
    }

    public void OpenDialogue(string lineId)
    {
        _dialogueBox.SetActive(true);
        _text.text = _dialogueDictionary[lineId];
    }

    public void CloseDialogue() => _dialogueBox.SetActive(false);

    public void OpenDialogueGradual(string lineId, float timePeriodBetweenTypes)
    {
        IEnumerator GradualIntroduction(char character)
        {
            _text.text += character;
            yield return new WaitForSeconds(timePeriodBetweenTypes);
        } 
        Array.ForEach(_dialogueDictionary[lineId].ToCharArray(), i => StartCoroutine(GradualIntroduction(i)));

    }


    [System.Serializable]
    public struct DialogueLine
    {
        public string id;
        public string lineOfText;
    }
}
