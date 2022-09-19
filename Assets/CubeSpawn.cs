using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawn : MonoBehaviour
{
    public GameObject benda;
    // Start is called before the first frame update
    public void ButtonClicked()
    {
        Instantiate(benda, new Vector3(0, 0, 0), Quaternion.identity);
        benda.AddComponent<BoxCollider>();
    }
}
