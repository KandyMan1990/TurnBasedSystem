[System.Serializable]
public class EnemySneakAttackBattleManagerState : IBattleManagerState
{
    BattleManager battleManager;

    public void OnEnter(BattleManager bm)
    {
        // all players turn progress = 0
        // all enemy turn progress = 1
        // show message at top of screen alerting player to current state
        battleManager = bm;
    }

    public void OnExit()
    {
        // do nothing
    }

    public void Update()
    {
        // check if intro has finished, then
        battleManager.ChangeState(new IdleBattleManagerState());
    }

    public bool Pop
    {
        get { return true; }
    }
}
