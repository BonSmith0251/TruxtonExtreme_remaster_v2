namespace InGame.Kernel.Player;

[CreateAssetMenu(menuName = "KANAI/PlayerDefinedSpeeds")]
[Token(Token = "0x200011B")]
public class PlayerDefinedSpeeds : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000808")]
	public List<Single> SpeedList; //Field offset: 0x18

	[Address(RVA = "0x1D4EB30", Offset = "0x1D4DF30", Length = "0x7C")]
	[Token(Token = "0x60008EE")]
	public PlayerDefinedSpeeds() { }

	[Address(RVA = "0x1D4EAD0", Offset = "0x1D4DED0", Length = "0x51")]
	[Token(Token = "0x60008ED")]
	public float GetSpeed(int index) { }

}

