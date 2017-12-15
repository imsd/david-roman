using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;



public class Hover : MonoBehaviour
{
    public GameObject Pic4;
    public GameObject Pic3;
    public GameObject Pic2;
    public GameObject Pic1;
   public string HoverText;
    public TextMesh DisplayTextObject;

    void Start() { DisplayTextObject.color = new Color(0, 0, 0, 0); }
    void OnMouseEnter()
    {
        // switch the 3d text so that its text value
        // is now whatever text value this hover instance holds
        DisplayTextObject.text = HoverText;

        // show it
        DisplayTextObject.color = Color.black;

        if (Pic1 != null)
        {
            Pic1.gameObject.SetActive(true);

        }

        if (Pic2 != null)
        {
            Pic2.gameObject.SetActive(true);

        }

        if (Pic3 != null)
        {
            Pic3.gameObject.SetActive(true);

        }

        if (Pic4 != null)
        {
            Pic4.gameObject.SetActive(true);

        }
    }

    void OnMouseExit()
    {
        DisplayTextObject.color = new Color(0, 0, 0, 0);


        if (Pic1 != null)
        {
            Pic1.gameObject.SetActive(false);

        }

        if (Pic2 != null)
        {
            Pic2.gameObject.SetActive(false);

        }

        if (Pic3 != null)
        {
            Pic3.gameObject.SetActive(false);


        }

        if (Pic4 != null)
        {
            Pic4.gameObject.SetActive(false);


        }





    }
}