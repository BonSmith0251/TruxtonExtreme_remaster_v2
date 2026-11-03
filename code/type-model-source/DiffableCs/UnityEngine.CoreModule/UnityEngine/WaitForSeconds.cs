namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x20001D6")]
public sealed class WaitForSeconds : YieldInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006B9")]
	internal float m_Seconds; //Field offset: 0x10

	[Address(RVA = "0x3076030", Offset = "0x3075430", Length = "0x28")]
	[Token(Token = "0x60014C1")]
	public WaitForSeconds(float seconds) { }

}

