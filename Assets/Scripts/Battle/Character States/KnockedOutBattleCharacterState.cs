[System.Serializable]
public class KnockedOutBattleCharacterState : IBattleCharacterState
{
    public void OnEnter(BattleCharacter battleCharacter)
    {
        // play death animation, remove from active actors
    }

    public void OnExit()
    {
        // play revive animation, add to active actors
    }

    public void Update()
    {
        // do nothing
    }
}
