using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout;
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab;
    [SerializeField] private GameObject chairPrefab;
    [SerializeField] private GameObject schuelerPrefab;

    void Start()
    {
        int createdSchueler = 0;

        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                if (createdSchueler >= students.Length)
                    return;

                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpaceing, 0, row * tableLayout.tableSpaceing);
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                Transform[] childPositions = table.GetComponentsInChildren<Transform>();
                foreach (Transform childPos in childPositions)
                {
                    if (createdSchueler >= students.Length)
                        break;

                    if (childPos.CompareTag("Chair"))
                    {
                        Instantiate(chairPrefab, childPos.position, childPos.rotation, table.transform);
                    }
                    else if (childPos.CompareTag("Schueler"))
                    {
                        Instantiate(schuelerPrefab, childPos.position, childPos.rotation, table.transform);
                        createdSchueler++;
                    }
                }
            }
        }
    }
}
