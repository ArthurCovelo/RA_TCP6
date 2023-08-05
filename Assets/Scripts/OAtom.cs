using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OAtom : MonoBehaviour
{
    public GameObject O;
    public GameObject H;
    public GameObject H2O;

    public GameObject infoPane;

    private RectTransform paneRectTransform;
    private bool isPaneVisible = false;



    private void Start()
    {
        O.SetActive(true);
        H2O.SetActive(false);

    }
    public void BotaoEvento()
    {
        // Alterna a visibilidade da pane de informações
        isPaneVisible = !isPaneVisible;

        if (isPaneVisible)
        {
            // Exibe a pane de informações
            infoPane.SetActive(true);
            // Exibe o GameObject com uma transição suave de baixo para cima
            LeanTween.moveY(infoPane, infoPane.transform.position.y + 1f, 0.5f).setEase(LeanTweenType.easeOutQuad);
        }
        else
        {
            // Oculta a pane de informações
            LeanTween.moveY(infoPane, infoPane.transform.position.y - 1f, 0.5f).setEase(LeanTweenType.easeOutQuad).setOnComplete(DeactivateObject);
            ;


        }
    }
    public void DeactivateObject()
    {
        infoPane.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget C")
        {
            O.SetActive(false);
            H.SetActive(false);
            H2O.SetActive(true);
            isPaneVisible = false;

        }
        //else if (_name == "ImageTarget H2")
        //{
        //    O.SetActive(false);
        //    H2O.SetActive(true);


        //}
    }

    private void OnTriggerExit(Collider other)
    {
        string _name = other.name;

        if (_name == "ImageTarget C")
        {
            O.SetActive(true);
            H.SetActive(true);
            H2O.SetActive(false);

        }
        //else if (_name == "ImageTarget H2")
        //{
        //    O.SetActive(true);
        //    H2O.SetActive(false);


        //}
    }
}
