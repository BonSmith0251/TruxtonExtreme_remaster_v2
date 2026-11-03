namespace TXEKernel;

[Token(Token = "0x2000011")]
public class InGamePlayableDirector : PlayableDirectorUtility
{
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	[Tooltip("SuperFighterPrefabの親Prefab")]
	private GameObject _superFighterParentPrefab; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	[Tooltip("表示を無効にするオブジェクト")]
	private List<GameObject> _disableGameObject; //Field offset: 0x40

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000031")]
	public InGamePlayableDirector() { }

	[Address(RVA = "0x26DA190", Offset = "0x26D9590", Length = "0x163")]
	[Token(Token = "0x6000030")]
	public void ResetSuperFighterPrefab(GameObject _superFighterPrefab) { }

}

