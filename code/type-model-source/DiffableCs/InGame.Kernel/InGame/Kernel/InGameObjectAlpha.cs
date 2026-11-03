namespace InGame.Kernel;

[Token(Token = "0x2000070")]
public class InGameObjectAlpha : InGameObject
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400039D")]
	private List<Color> _psystemColors; //Field offset: 0x70

	[Address(RVA = "0x1D1C550", Offset = "0x1D1B950", Length = "0x7E")]
	[Token(Token = "0x6000490")]
	public InGameObjectAlpha() { }

	[Address(RVA = "0x1D1BDF0", Offset = "0x1D1B1F0", Length = "0x39")]
	[Token(Token = "0x600048C")]
	public virtual void EntryInGame() { }

	[Address(RVA = "0x1D1BE30", Offset = "0x1D1B230", Length = "0x197")]
	[Token(Token = "0x600048A")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D1BFD0", Offset = "0x1D1B3D0", Length = "0x191")]
	[Token(Token = "0x600048F")]
	public void KeepDefaults() { }

	[Address(RVA = "0x1D1C170", Offset = "0x1D1B570", Length = "0x18B")]
	[Token(Token = "0x600048E")]
	protected override void SetDefaults() { }

	[Address(RVA = "0x1D1C300", Offset = "0x1D1B700", Length = "0x1BB")]
	[Token(Token = "0x600048D")]
	public void SetFadeAlpha(float trate) { }

	[Address(RVA = "0x1D1C4C0", Offset = "0x1D1B8C0", Length = "0x8D")]
	[Token(Token = "0x600048B")]
	public virtual void Terminate() { }

}

