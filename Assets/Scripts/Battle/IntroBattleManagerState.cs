public class IntroBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // set all actors to intro state
        battleManager.GetCharacters.ForEach(c => // not the way to do it, just experimenting
        {
            if (c.currentState.GetType() == typeof(IdleBattleManagerState))
            {

            }
        });
    }

    public void OnExit()
    {
        // fade in UI
        // set camera to appropriate position
        // set all actors to idle state
    }

    public void Update()
    {
        // check if all actors have finished their intro state
    }

    public bool Pop
    {
        get { return true; }
    }
}
