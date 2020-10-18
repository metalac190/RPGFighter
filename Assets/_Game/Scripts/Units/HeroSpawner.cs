using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : MonoBehaviour
{
    [SerializeField] List<Transform> _heroSpawns;

    void SpawnHeroes(List<HeroBattleUnit> heroes)
    {
        int positionSelector = 0;
        // spawn heroes
        foreach (HeroBattleUnit unit in heroes)
        {
            SpawnHero(unit, _heroSpawns[positionSelector].position);
            positionSelector++;
        }
    }

    public void SpawnHero(HeroBattleUnit unit, Vector3 position)
    {

    }
}
