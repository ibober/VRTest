using UnityEngine;
using System.Collections;

public class ReplaceFurniture : MonoBehaviour
{
    public GameObject FurnitureToPlace;
    public GameObject[] FurnitureToHide;

    public void PlaceNewFurniture()
    {
        foreach (GameObject item in FurnitureToHide)
        {
            item.SetActive(false);
        }
        FurnitureToPlace.SetActive(true);
    }
}
