using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public void Checking()
    {
        foreach(GameObject gameobj in gameObjects)
        {
            if (!gameobj.GetComponent<Hook>().isClicked) return;
        }

        GameManager.Instance.CheckLevelUp();
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
