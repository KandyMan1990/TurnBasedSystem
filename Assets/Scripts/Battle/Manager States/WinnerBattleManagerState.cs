[System.Serializable]
public class WinnerBattleManagerState : IBattleManagerState
{
    public void OnEnter(BattleManager battleManager)
    {
        // fade ui out
        // set characters that are not dead to victory dance state
        // play win music
        // decide which camera animation to use (no animation, jump between characters, focus on character that dealt final blow)
    }

    public void OnExit()
    {
        // fade out post battle UI
        // fade out win music
        // return to previous scene
    }

    public void Update()
    {
        // increment timer by deltaTime
        // after certain time has passed (set in config) fade out camera, fade in post battle UI
    }

    public bool Pop
    {
        get { return false; }
    }
}
