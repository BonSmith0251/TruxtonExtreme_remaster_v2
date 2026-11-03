namespace KANAI.DebugTools;

[Token(Token = "0x2000005")]
public class DebugGizmosField : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000B")]
	private Color _darkGray; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	private int _xsize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400000D")]
	private int _ysize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000E")]
	private int _xdivide; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000F")]
	private int _ydivide; //Field offset: 0x3C

	[Address(RVA = "0x1DD96B0", Offset = "0x1DD8AB0", Length = "0x21")]
	[Token(Token = "0x600000A")]
	public DebugGizmosField() { }

	[Address(RVA = "0x1DD9690", Offset = "0x1DD8A90", Length = "0x18")]
	[Token(Token = "0x6000009")]
	public void SetupDevice(int xsize, int ysize, int _dx, int _dy) { }

}

