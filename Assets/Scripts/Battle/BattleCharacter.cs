using UnityEngine;

public abstract class BattleCharacter : MonoBehaviour
{
    public IBattleCharacterState CurrentState { get; private set; }
    public float TurnProgress { get; private set; }
    public float Speed { get; private set; } //temporary until we get proper character stats

    public void SetState(IBattleCharacterState newState)
    {
        CurrentState = newState;
    }

    public void IncreaseTurnProgress(float progress)
    {
        TurnProgress += progress;
    }

    public void ResetTurnProgress()
    {
        TurnProgress = 0f;
    }

    // TODO: seperate classes for enemy/player characters
    // TODO: create states for ready to perform, performing, on hit?, low health (not for enemy), dead
}
