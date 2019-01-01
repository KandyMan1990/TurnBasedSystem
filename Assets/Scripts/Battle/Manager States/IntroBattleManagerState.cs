using System.Linq;

public class IntroBattleManagerState : IBattleManagerState
{
    BattleManager battleManager;

    public void OnEnter(BattleManager bm)
    {
        battleManager = bm;
        battleManager.GetCharacters.ForEach(character =>
        {
            character.SetState(new IntroBattleCharacterState());
        });
    }

    public void OnExit()
    {
        // fade in UI
        // set camera to appropriate position
    }

    public void Update()
    {
        // check if all actors have finished their intro state
        if (battleManager.GetCharacters.All(character => character.CurrentState.GetType() != typeof(IntroBattleCharacterState)))
        {
            battleManager.ChangeState(new IdleBattleManagerState());
        }
    }

    public bool Pop
    {
        get { return true; }
    }
}
