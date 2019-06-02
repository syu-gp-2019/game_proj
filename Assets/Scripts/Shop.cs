﻿using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandartTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileTurret()
    {
        Debug.Log("Missile Turret Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }

}
