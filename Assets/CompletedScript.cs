using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompletedScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Tomaat;

    [SerializeField]
    private GameObject Komkommer;

    [SerializeField]
    private GameObject Aardappels;

    [SerializeField]
    private GameObject Druiven;

    [SerializeField]
    private GameObject Peper;

    [SerializeField]
    private GameObject Wortel;

    [SerializeField]
    private GameObject Bloemkool;

    [SerializeField]
    private GameObject Eieren;

    [SerializeField]
    private TextMeshProUGUI CompletedText;

    void Start()
    {
        CompletedText.gameObject.SetActive(false);
    }

    void Update()
    {
        CheckCompleted();
    }

    void CheckCompleted()
    {
        if (Tomaat.gameObject.activeSelf && Komkommer.gameObject.activeSelf && Aardappels.gameObject.activeSelf && Druiven.gameObject.activeSelf && Peper.gameObject.activeSelf && Wortel.gameObject.activeSelf && Bloemkool.gameObject.activeSelf && Eieren.gameObject.activeSelf)
        {
            CompletedText.gameObject.SetActive(true);
        }
    }
}
