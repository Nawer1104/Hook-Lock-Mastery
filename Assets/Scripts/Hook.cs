using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public GameObject obj_stand;

    public GameObject obj_laydown;

    public bool isClicked;

    private void Awake()
    {
        isClicked = false;

        obj_stand.SetActive(true);
        obj_laydown.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (isClicked) return;

        isClicked = true;

        obj_stand.SetActive(false);
        obj_laydown.SetActive(true);

        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].Checking();
    }
}
