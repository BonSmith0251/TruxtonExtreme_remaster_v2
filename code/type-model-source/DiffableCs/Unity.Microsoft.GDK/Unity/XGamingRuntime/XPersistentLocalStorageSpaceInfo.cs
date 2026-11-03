namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000258")]
public class XPersistentLocalStorageSpaceInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065E")]
	internal XPersistentLocalStorageSpaceInfo interop; //Field offset: 0x10

	[Token(Token = "0x17000268")]
	public ulong AvailableFreeBytes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C29")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000C2A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700026B")]
	public ulong TotalBytes
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C2F")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000C30")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000269")]
	public ulong TotalFreeBytes
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C2B")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000C2C")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700026A")]
	public ulong UsedBytes
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000C2D")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x6000C2E")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x11DF780", Offset = "0x11DEB80", Length = "0x31")]
	[Token(Token = "0x6000C27")]
	internal XPersistentLocalStorageSpaceInfo(XPersistentLocalStorageSpaceInfo interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000C28")]
	public XPersistentLocalStorageSpaceInfo() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C29")]
	public ulong get_AvailableFreeBytes() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C2F")]
	public ulong get_TotalBytes() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C2B")]
	public ulong get_TotalFreeBytes() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000C2D")]
	public ulong get_UsedBytes() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000C2A")]
	public void set_AvailableFreeBytes(ulong value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000C30")]
	public void set_TotalBytes(ulong value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000C2C")]
	public void set_TotalFreeBytes(ulong value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x6000C2E")]
	public void set_UsedBytes(ulong value) { }

}

