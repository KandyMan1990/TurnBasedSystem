[System.Serializable]
public class LoserBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // show some sort of ui thing that says party defeated
    }

    public void OnExit()
    {
        // return to last save point/autosave
        // fade out game over music
    }

    public void Update()
    {
        // increment timer by deltaTime
        // after certain time has passed (set in config) fade out camera, fade in game over UI, play game over music
    }

    public bool Pop
    {
        get { return false; }
    }
}
