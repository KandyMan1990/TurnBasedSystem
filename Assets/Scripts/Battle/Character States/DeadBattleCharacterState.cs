[System.Serializable]
public class DeadBattleCharacterState : IBattleCharacterState
{
    public void OnEnter(BattleCharacter battleCharacter)
    {
        // play death animation, fade out, remove from active actors
    }

    public void OnExit()
    {
        // do nothing
    }

    public void Update()
    {
        // do nothing
    }
}
