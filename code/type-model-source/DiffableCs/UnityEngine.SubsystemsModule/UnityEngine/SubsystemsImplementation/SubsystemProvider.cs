namespace UnityEngine.SubsystemsImplementation;

[Token(Token = "0x2000011")]
public abstract class SubsystemProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000012")]
	internal bool m_Running; //Field offset: 0x10

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000033")]
	protected SubsystemProvider() { }

}

