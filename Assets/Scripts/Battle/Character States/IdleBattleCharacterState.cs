using UnityEngine;

[System.Serializable]
public class IdleBattleCharacterState : IBattleCharacterState
{
    const float maxValue = 255f;
    BattleCharacter battleCharacter;

    public void OnEnter(BattleCharacter bc)
    {
        battleCharacter = bc;
    }

    public void OnExit()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        // need to check if allowed to update via BM

        // increase progress bar by speed * deltaTime * BattleSpeed
        battleCharacter.IncreaseTurnProgress((battleCharacter.Speed / maxValue) * Time.deltaTime);
        // if progress == 1, switch to awaiting input
        if (battleCharacter.TurnProgress >= 1f)
        {
            battleCharacter.SetState(new AwaitingInputBattleCharacterState());
        }
    }
}
