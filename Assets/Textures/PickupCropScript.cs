using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupCropScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI PickUpCropText;
    private bool CropPickUpAllowed;

    void Start()
    {
        PickUpCropText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (CropPickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            PickUpCropText.gameObject.SetActive(true);
            CropPickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Character"))
        {
            PickUpCropText.gameObject.SetActive(false);
            CropPickUpAllowed = false;
        }
    }
}
