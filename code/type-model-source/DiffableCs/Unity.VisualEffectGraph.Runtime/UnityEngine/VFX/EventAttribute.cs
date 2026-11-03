namespace UnityEngine.VFX;

[Token(Token = "0x2000016")]
internal abstract class EventAttribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004B")]
	public ExposedProperty id; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600002C")]
	protected EventAttribute() { }

	[Token(Token = "0x600002B")]
	public abstract bool ApplyToVFX(VFXEventAttribute eventAttribute) { }

}

