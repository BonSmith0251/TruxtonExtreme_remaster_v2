namespace OutGame.UI;

[Token(Token = "0x200010A")]
public class CreditsRollName : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000479")]
	private UITextMeshPro _center; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400047A")]
	private UITextMeshPro _left; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400047B")]
	private UITextMeshPro _right; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400047C")]
	private int mode; //Field offset: 0x38

	[Address(RVA = "0x21E7A80", Offset = "0x21E6E80", Length = "0xE")]
	[Token(Token = "0x60006BE")]
	public CreditsRollName() { }

	[Address(RVA = "0x21E7550", Offset = "0x21E6950", Length = "0x526")]
	[Token(Token = "0x60006BD")]
	public void SetName(string str, string str2, string str3) { }

}

