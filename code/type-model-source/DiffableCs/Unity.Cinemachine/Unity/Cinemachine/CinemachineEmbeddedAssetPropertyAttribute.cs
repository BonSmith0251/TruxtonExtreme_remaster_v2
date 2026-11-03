namespace Unity.Cinemachine;

[Token(Token = "0x20000A7")]
public sealed class CinemachineEmbeddedAssetPropertyAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400028F")]
	public bool WarnIfNull; //Field offset: 0x18

	[Address(RVA = "0x283F810", Offset = "0x283EC10", Length = "0x26")]
	[Token(Token = "0x6000331")]
	public CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false) { }

}

