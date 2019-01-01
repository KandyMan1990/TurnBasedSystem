using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    Stack<IBattleManagerState> states;
    List<BattleCharacter> battleCharacters;
    Queue<BattleAction> battleActions;

    public List<BattleCharacter> GetCharacters
    {
        get { return battleCharacters; }
    }
    
    void Update()
    {
        states.Peek().Update();
    }

    public void Init(BattleConfig config) // TODO: should take a battleConfig object as an argument to init everything
    {
        battleActions = new Queue<BattleAction>();
        battleCharacters = new List<BattleCharacter>();
        states = new Stack<IBattleManagerState>();

        states.Push(config.initialState ?? new IntroBattleManagerState());
        states.Peek().OnEnter(this);

        // battle scene should be a level with this script on which loads the
        // appropriate actors based on the config object passed to it
        // as well as what state the battle should start in ie. back attack, first strike etc
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