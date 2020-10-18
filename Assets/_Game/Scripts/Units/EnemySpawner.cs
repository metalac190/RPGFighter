using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<Transform> _enemySpawns;

    void SpawnEnemies(List<EnemyBattleUnit> enemies)
    {
        int positionSelector = 0;
        // spawn enemies
        foreach (EnemyBattleUnit unit in enemies)
        {
            SpawnEnemy(unit, _enemySpawns[positionSelector].position);
            positionSelector++;
        }
    }

    public void SpawnEnemy(EnemyBattleUnit unit, Vector3 position)
    {

    }
}
