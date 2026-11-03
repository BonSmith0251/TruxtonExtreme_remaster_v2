namespace InGame.Kernel.Player;

[CreateAssetMenu(menuName = "KANAI/PlayerDefinedShots")]
[Token(Token = "0x200011A")]
public class PlayerDefinedShots : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000806")]
	public ArmsKind kind; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000807")]
	public List<ShotDirectionData> ShotLists; //Field offset: 0x20

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60008EC")]
	public PlayerDefinedShots() { }

	[Address(RVA = "0x1D4EA80", Offset = "0x1D4DE80", Length = "0x44")]
	[Token(Token = "0x60008EB")]
	public ShotDirectionData[] GetDatas() { }

}

