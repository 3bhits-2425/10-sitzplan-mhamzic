using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    [SerializeField] private TableLayoutData tableLayout; //Ref zu TableLayout ScriptableObject 
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;


    void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpaceing, 0,
                    row * tableLayout.tableSpaceing);

                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity,
                transform);

                // Sessel platzieren
                Transform[] chairPosition = table.GetComponentsInChildren<Transform>();
                foreach (Transform chairPos in chairPosition)
                {
                    if (chairPos.CompareTag("Chair"))
                    {
                        GameObject chair = Instantiate(chairPrefab,chairPos.position ,chairPos.rotation, table.transform);
                        Debug.Log("Found Chair");
                    }
                }
            }
        }
    }
}