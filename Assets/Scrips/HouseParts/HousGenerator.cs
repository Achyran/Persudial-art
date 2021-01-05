using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousGenerator : MonoBehaviour
{
    public int houseX;
    public int houseY;
    public int houseZ;

    public GameObject wallElementPrefabs;
    public GameObject RoofParts;
    public GameObject HouseDataStructure;

    public void SpawHouse()
    {
        //Debug.Log("Is Calles" );
        GameObject house = Instantiate(HouseDataStructure, transform.position, transform.rotation);
        
        for (int i = 0; i < houseX; i++)
        {
            for(int j = 0; j < houseZ; j++)
            {
            GameObject element = Instantiate(wallElementPrefabs,house.transform);
                element.transform.position = new Vector3(i * 3 +house.transform.position.x, 0 + house.transform.position.y, j * 3 + house.transform.position.z);

            }
        }
        
    }
}
