namespace OutGame.UI;

[Token(Token = "0x2000140")]
public class ServiceRecordListOne : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400055A")]
	public UITextMeshPro _achevement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400055B")]
	public UITextMeshPro _accumulatedPoints; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400055C")]
	public UITextMeshPro _levelConversion; //Field offset: 0x30

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007F0")]
	public ServiceRecordListOne() { }

	[Address(RVA = "0x2200840", Offset = "0x21FFC40", Length = "0x7C")]
	[Token(Token = "0x60007EF")]
	public void set(string labelKey, string points, string level) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007ED")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007EE")]
	private void Update() { }

}

