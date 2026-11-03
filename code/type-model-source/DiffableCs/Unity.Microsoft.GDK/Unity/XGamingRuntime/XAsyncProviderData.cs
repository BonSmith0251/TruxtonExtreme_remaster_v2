namespace Unity.XGamingRuntime;

[Token(Token = "0x200013B")]
public class XAsyncProviderData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001EB")]
	internal XAsyncProviderData interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001EC")]
	internal XAsyncBlock _async; //Field offset: 0x30

	[Token(Token = "0x1700006E")]
	public XAsyncBlock Async
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000725")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000726")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000070")]
	public IntPtr Buffer
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000729")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x600072A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700006F")]
	public ulong BufferSize
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000727")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000728")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000071")]
	public IntPtr Context
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600072B")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x600072C")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B7C940", Offset = "0x2B7BD40", Length = "0x4E")]
	[Token(Token = "0x6000724")]
	internal XAsyncProviderData(XAsyncProviderData interop, XAsyncBlock block) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000725")]
	public XAsyncBlock get_Async() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000729")]
	public IntPtr get_Buffer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000727")]
	public ulong get_BufferSize() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600072B")]
	public IntPtr get_Context() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000726")]
	public void set_Async(XAsyncBlock value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x600072A")]
	public void set_Buffer(IntPtr value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000728")]
	public void set_BufferSize(ulong value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x600072C")]
	public void set_Context(IntPtr value) { }

}

