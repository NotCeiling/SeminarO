using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GrandmaInteraction : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI InteractText;
    private bool InteractAllowed;

    [SerializeField]
    private GameObject UI;

    void Start()
    {
        InteractText.gameObject.SetActive(false);
        UI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (InteractAllowed && Input.GetKeyDown(KeyCode.E))
        {
            UI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            InteractText.gameObject.SetActive(true);
            InteractAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            InteractText.gameObject.SetActive(false);
            InteractAllowed = true;
        }
    }
}
