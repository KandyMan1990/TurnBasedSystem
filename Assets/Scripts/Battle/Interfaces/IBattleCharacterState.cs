public interface IBattleCharacterState
{
    void OnEnter(BattleCharacter battleCharacter);
    void OnExit();
    void Update();
}
