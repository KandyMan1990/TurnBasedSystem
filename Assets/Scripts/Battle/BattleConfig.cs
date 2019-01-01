using UnityEngine;

public struct BattleConfig
{
    public BattleCharacter[] playerCharacters;
    public BattleCharacter[] enemyCharacters;
    public Transform[] playerLocations;
    public Transform[] enemyLocations;
    public IBattleManagerState initialState;
}
