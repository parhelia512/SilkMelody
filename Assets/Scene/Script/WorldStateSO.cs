using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WorldState", menuName = "ScriptableObjects/WorldState")]
[System.Serializable]
public class WorldStateSO : ScriptableObject
{
    [Header("Collectibles")]
    public bool[] maskUpgrades = new bool[3];
    public bool[] silkUpgrades = new bool[3];

    [Header("Upgrades")]
    public bool doubleJump;
    public bool wallJump;

    [Header("DoorSwitch")]
    public bool[] doorSwitches = new bool[3];

    public enum BossEnum
    { Batter, Cela }

    [Header("Boss")]
    public bool[] bossDefeated = new bool[3];

    public void ResetToNewGameState()
    {
        maskUpgrades[0] = false;
        maskUpgrades[1] = false;
        maskUpgrades[2] = false;

        silkUpgrades[0] = false;
        silkUpgrades[1] = false;
        silkUpgrades[2] = false;

        doubleJump = false;
        wallJump = false;

        doorSwitches[0] = false;
        doorSwitches[1] = false;
        doorSwitches[2] = false;

        bossDefeated[0] = false;
        bossDefeated[1] = false;
        bossDefeated[2] = false;
    }
}