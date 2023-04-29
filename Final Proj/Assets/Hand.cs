using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class Hand : MonoBehaviour
{
    [SerializeField]
    public TMP_Text gameText;
    public GameObject winText;
    public PickUpManager pickUps;
    
    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
        gameText.gameObject.SetActive(true);
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SetCountText() {
        gameText.text = "Mushrooms Left:" + pickUps.numMushrooms.ToString();
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Collided");
        if (other.gameObject.tag == "Mushroom") {
            pickUps.numMushrooms--;
            Debug.Log("Grabbed branch");
            Destroy(other.gameObject);
            SetCountText();
        }

        if (pickUps.numMushrooms == 0) {
            gameText.gameObject.SetActive(false);
            winText.SetActive(true);
        }
    }
}
