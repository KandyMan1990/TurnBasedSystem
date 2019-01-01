[System.Serializable]
public class IdleBattleManagerState : IBattleManagerState
{
    BattleManager battleManager;

    public void OnEnter(BattleManager bm)
    {
        battleManager = bm;
    }

    public void OnExit()
    {
        // do nothing
    }

    public void Update()
    {
        // do nothing
    }

    public bool Pop
    {
        get { return false; }
    }
}
