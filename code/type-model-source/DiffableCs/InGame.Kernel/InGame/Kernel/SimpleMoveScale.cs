namespace InGame.Kernel;

[Token(Token = "0x20000B2")]
public class SimpleMoveScale : SimpleMove
{
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000560")]
	private Vector3 _baseScale; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x4000561")]
	private float _baseDistance; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000562")]
	private float _movedDistance; //Field offset: 0xF8

	[Address(RVA = "0x1D42C10", Offset = "0x1D42010", Length = "0xB")]
	[Token(Token = "0x6000674")]
	protected virtual void _setupStart() { }

	[Address(RVA = "0x1D42C20", Offset = "0x1D42020", Length = "0x16A")]
	[Token(Token = "0x6000675")]
	protected virtual void _updateMove(float tdt) { }

	[Address(RVA = "0x1D42B90", Offset = "0x1D41F90", Length = "0x76")]
	[Token(Token = "0x6000676")]
	public SimpleMoveScale() { }

}

