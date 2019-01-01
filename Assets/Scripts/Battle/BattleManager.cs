using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    Stack<IBattleManagerState> states;
    List<BattleCharacter> battleCharacters;
    Queue<BattleAction> battleActions;
    [SerializeField]
    Transform[] playerSpawnPoints;
    [SerializeField]
    Transform[] enemySpawnPoints;

    public List<BattleCharacter> GetCharacters
    {
        get { return battleCharacters; }
    }

    void Update()
    {
        states.Peek().Update();
    }

    public void Init(BattleConfig config)
    {
        battleActions = new Queue<BattleAction>();
        battleCharacters = new List<BattleCharacter>();
        states = new Stack<IBattleManagerState>();

        for (int i = 0; i < config.playerCharacters.Length; i++)
        {
            // spawn characters at appropriate positions
        }

        for (int i = 0; i < config.enemyCharacters.Length; i++)
        {
            // spawn enemies at appropriate positions
        }

        states.Push(config.initialState ?? new IntroBattleManagerState());
        states.Peek().OnEnter(this);
    }

    public void ChangeState(IBattleManagerState newState)
    {
        states.Peek().OnExit();

        if (states.Peek().Pop)
        {
            states.Pop();
        }

        states.Push(newState);
        states.Peek().OnEnter(this);
    }
}