[System.Serializable]
public class IntroBattleCharacterState : IBattleCharacterState
{
    BattleCharacter battleCharacter;
    bool introFinished = false;

    public void OnEnter(BattleCharacter bc)
    {
        battleCharacter = bc;
        // probably play an animation clip
    }

    public void OnExit()
    {
        // do nothing
    }

    public void Update()
    {
        if (introFinished)
        {
            battleCharacter.SetState(new IdleBattleCharacterState());
        }
    }

    public void IntroComplete()
    {
        introFinished = true;
    }
}
