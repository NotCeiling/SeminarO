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

    [SerializeField]
    private GameObject ExclamationMark;

    [SerializeField]
    private TextMeshProUGUI GrandmaDialogue;

    [SerializeField]
    public string GrandmaText;

    [SerializeField]
    public GameObject player;

    void Start()
    {
        InteractText.gameObject.SetActive(false);
        GrandmaDialogue.gameObject.SetActive(false);
        UI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (InteractAllowed && Input.GetKeyDown(KeyCode.E))
        {
            UI.gameObject.SetActive(true);
            if (Vector2.Distance(player.transform.position, transform.position) < 2)
            {
                GrandmaDialogue.gameObject.SetActive(true);
                StartCoroutine(TypeSentence(GrandmaText));
            }
            ExclamationMark.gameObject.SetActive(false);
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

    IEnumerator TypeSentence(string sentence)
    {
        GrandmaDialogue.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            GrandmaDialogue.text += letter;
            yield return new WaitForSeconds(0.03f);
        }
    }
}
