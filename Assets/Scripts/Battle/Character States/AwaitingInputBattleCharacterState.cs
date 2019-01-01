[System.Serializable]
public class AwaitingInputBattleCharacterState : IBattleCharacterState
{
    public void OnEnter(BattleCharacter battleCharacter)
    {
        // add character to awaiting input list
    }

    public void OnExit()
    {
        // remove character from awaiting input list
    }

    public void Update()
    {
        // do nothing
    }
}
