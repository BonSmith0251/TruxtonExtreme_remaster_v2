namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyDescriptor.h")]
[Token(Token = "0x2000022")]
public struct HierarchyPropertyDescriptor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000053")]
	private int m_Size; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000054")]
	private HierarchyPropertyStorageType m_Type; //Field offset: 0x4

	[Token(Token = "0x1700001C")]
	public int Size
	{
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700001D")]
	public HierarchyPropertyStorageType Type
	{
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x60000C8")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60000C7")]
	public void set_Size(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60000C8")]
	public void set_Type(HierarchyPropertyStorageType value) { }

}

