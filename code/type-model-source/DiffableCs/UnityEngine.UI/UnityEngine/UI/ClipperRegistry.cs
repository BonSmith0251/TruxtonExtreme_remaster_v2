namespace UnityEngine.UI;

[Token(Token = "0x200000C")]
public class ClipperRegistry
{
	[Token(Token = "0x400002D")]
	private static ClipperRegistry s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002E")]
	private readonly IndexedSet<IClipper> m_Clippers; //Field offset: 0x10

	[Token(Token = "0x17000012")]
	public static ClipperRegistry instance
	{
		[Address(RVA = "0x31D2FC0", Offset = "0x31D23C0", Length = "0xF1")]
		[Token(Token = "0x600004C")]
		 get { } //Length: 241
	}

	[Address(RVA = "0x31D2F40", Offset = "0x31D2340", Length = "0x77")]
	[Token(Token = "0x600004B")]
	protected ClipperRegistry() { }

	[Address(RVA = "0x31D2CD0", Offset = "0x31D20D0", Length = "0x132")]
	[Token(Token = "0x600004D")]
	public void Cull() { }

	[Address(RVA = "0x31D2E10", Offset = "0x31D2210", Length = "0x53")]
	[Token(Token = "0x6000050")]
	public static void Disable(IClipper c) { }

	[Address(RVA = "0x31D2FC0", Offset = "0x31D23C0", Length = "0xF1")]
	[Token(Token = "0x600004C")]
	public static ClipperRegistry get_instance() { }

	[Address(RVA = "0x31D2E70", Offset = "0x31D2270", Length = "0x61")]
	[Token(Token = "0x600004E")]
	public static void Register(IClipper c) { }

	[Address(RVA = "0x31D2EE0", Offset = "0x31D22E0", Length = "0x53")]
	[Token(Token = "0x600004F")]
	public static void Unregister(IClipper c) { }

}

