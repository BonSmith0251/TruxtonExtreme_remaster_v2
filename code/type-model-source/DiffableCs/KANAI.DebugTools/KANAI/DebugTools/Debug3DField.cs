namespace KANAI.DebugTools;

[Token(Token = "0x2000004")]
public class Debug3DField : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000006")]
	private int _xsize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000007")]
	private int _ysize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000008")]
	private int _xdivide; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000009")]
	private int _ydivide; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000A")]
	private List<GameObject> _lines; //Field offset: 0x30

	[Address(RVA = "0x1DD9500", Offset = "0x1DD8900", Length = "0x184")]
	[Token(Token = "0x6000007")]
	private void _destoryLines() { }

	[Address(RVA = "0x1DD9470", Offset = "0x1DD8870", Length = "0x85")]
	[Token(Token = "0x6000008")]
	public Debug3DField() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000003")]
	private void Awake() { }

	[Address(RVA = "0x1DD8C40", Offset = "0x1DD8040", Length = "0x7")]
	[Token(Token = "0x6000004")]
	private void OnDestroy() { }

	[Address(RVA = "0x1DD8C50", Offset = "0x1DD8050", Length = "0x125")]
	[Token(Token = "0x6000006")]
	public void SetActiveLine(bool value) { }

	[Address(RVA = "0x1DD8D80", Offset = "0x1DD8180", Length = "0x6EB")]
	[Token(Token = "0x6000005")]
	public void SetupDevice(int xsize, int ysize, int _dx, int _dy) { }

}

