using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in Scene");
            return;
        }
        instance = this;
    }

    public GameObject standartTurretPrefab;
    public GameObject MissileTurretPrefab;

    private GameObject turretToBuild;
    /*
    void Start()
    {
        turretToBuild = standartTurretPrefab;
    }
    */

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}
