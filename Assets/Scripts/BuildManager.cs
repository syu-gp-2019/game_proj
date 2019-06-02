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

    private TurretBlueprint turretToBuild;
    /*
    void Start()
    {
        turretToBuild = standartTurretPrefab;
    }
    */

    public bool CanBuild{ get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {

        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("No Meney");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity) as GameObject;
        node.turret = turret;

        Debug.Log("Left Money : " + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }

}
