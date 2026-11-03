namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x200018F")]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000632")]
	private int m_Order; //Field offset: 0x10

	[Token(Token = "0x170002CE")]
	public int order
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6001292")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6001291")]
	public DefaultExecutionOrder(int order) { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6001292")]
	public int get_order() { }

}

