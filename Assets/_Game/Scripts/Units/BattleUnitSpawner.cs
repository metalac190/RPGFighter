using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BattleUnitSpawner : MonoBehaviour
{
    //TODO load enemy data config from file using an identifier stored in the GameData
    // Enemy Spawn Data
    [SerializeField] BattleUnit _defaultUnitPrefab = null;

    [SerializeField] List<Transform> _heroSpawns;
    [SerializeField] List<Transform> _enemySpawns;

    public List<BattleUnit> SpawnHeroes(List<BattleUnitData> heroes)
    {
        int positionSelector = 0;
        List<BattleUnit> spawnedHeroes = new List<BattleUnit>();
        // spawn heroes
        foreach (BattleUnitData unit in heroes)
        {
            BattleUnit newHero = SpawnUnit(unit, _heroSpawns[positionSelector]);
            spawnedHeroes.Add(newHero);
            positionSelector++;
        }

        return spawnedHeroes;
    }

    public List<BattleUnit> SpawnEnemies(List<BattleUnitData> enemies)
    {
        int positionSelector = 0;
        List<BattleUnit> spawnedEnemies = new List<BattleUnit>();
        // spawn enemies
        foreach (BattleUnitData unit in enemies)
        {
            BattleUnit newEnemy = SpawnUnit(unit, _enemySpawns[positionSelector]);
            spawnedEnemies.Add(newEnemy);
            positionSelector++;
        }

        return spawnedEnemies;
    }

    BattleUnit SpawnUnit(BattleUnitData unitData, Transform location)
    {
        BattleUnit newUnit = Instantiate(_defaultUnitPrefab, location.position, Quaternion.identity);
        newUnit.Initialize(unitData, location);
        newUnit.transform.SetParent(location);
        newUnit.gameObject.name = unitData.Name;
        //TODO establish rotation
        return newUnit;
    }
}
