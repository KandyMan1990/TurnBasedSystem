public interface IBattleManagerState
{
    void OnEnter(BattleManager battleManager);
    void OnExit();
    void Update();
    bool Pop { get; }
}
