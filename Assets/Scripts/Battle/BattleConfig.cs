using UnityEngine;

public struct BattleConfig
{
    public BattleCharacter[] playerCharacters;
    public BattleCharacter[] enemyCharacters;
    public IBattleManagerState initialState;
}
