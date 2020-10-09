using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SO_Card : ScriptableObject
{
    public string text;


    public string japoneseWrite;
    public string englishWrite;

    //public Sprite sprite;

    public Alphabet alphabet;

    public Consonant consonant;

    public Vowel vowel;

    [ContextMenu("Update Card Description")]
    void UpdCardDescription()
    {
        string _newName = consonant.ToString() + vowel.ToString();

        text = _newName.ToUpper();

        englishWrite = _newName.ToUpper();

        name = _newName.ToUpper();

        Debug.Log("Description Updated");
    }
}
