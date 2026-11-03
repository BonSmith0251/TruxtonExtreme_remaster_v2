//Type is in global namespace

[ExecuteInEditMode]
[Token(Token = "0x2000004")]
public class EditorTime : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000E")]
	private float _time; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000F")]
	private readonly int _pid; //Field offset: 0x24

	[Address(RVA = "0x5D3000", Offset = "0x5D2400", Length = "0x45")]
	[Token(Token = "0x6000006")]
	public EditorTime() { }

	[Address(RVA = "0x5D2FB0", Offset = "0x5D23B0", Length = "0x49")]
	[Token(Token = "0x6000004")]
	private void Awake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000005")]
	private void Update() { }

}

