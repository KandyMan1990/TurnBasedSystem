using UnityEngine;

public abstract class BattleCharacter : MonoBehaviour
{
    public IBattleCharacterState currentState;

    // TODO: seperate classes for enemy/player characters
    // TODO: create states for intro, idle, awaiting input, ready to perform, performing, on hit?, low health (not for enemy), dead
}
