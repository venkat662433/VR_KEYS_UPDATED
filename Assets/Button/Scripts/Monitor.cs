using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Monitor : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    void OnValidate()
    {
        _text = gameObject.GetComponentInChildren<TMP_Text>();
    }

    public void SetText(string key)
    {
        _text.text += key;
    }
}
