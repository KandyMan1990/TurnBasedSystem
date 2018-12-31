using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField]
    Stack<IBattleManagerState> states;
    List<BattleCharacter> battleCharacters;
    Queue<BattleAction> battleActions;

    public List<BattleCharacter> GetCharacters
    {
        get { return battleCharacters; }
    }

    void Awake()
    {
        battleActions = new Queue<BattleAction>();
        battleCharacters = new List<BattleCharacter>();
        states = new Stack<IBattleManagerState>();

        states.Push(new IntroBattleManagerState());
        states.Peek().OnEnter(this);

        // battle manager should init everything.  battle scene should be blank with this script on which loads the
        // appropriate level/actors based on the config object passed to it
    }
    
    void Update()
    {
        states.Peek().Update();
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