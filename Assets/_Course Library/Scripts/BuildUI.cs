using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildUI : MonoBehaviour
{
    public GameObject _prefab;

    public void InstantiatePrefab()
    {
        Instantiate(_prefab, new Vector3(0, 0.1f, 0), Quaternion.identity);
        Debug.Log("Instantiated " + _prefab.name + "!");
    }
}
