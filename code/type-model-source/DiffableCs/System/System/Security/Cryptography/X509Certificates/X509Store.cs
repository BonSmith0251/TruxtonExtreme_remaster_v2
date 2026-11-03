namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000143")]
public sealed class X509Store : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005C6")]
	private string _name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005C7")]
	private StoreLocation _location; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005C8")]
	private X509Certificate2Collection list; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C9")]
	private OpenFlags _flags; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005CA")]
	private X509Store store; //Field offset: 0x30

	[Token(Token = "0x17000179")]
	public X509Certificate2Collection Certificates
	{
		[Address(RVA = "0x265A3D0", Offset = "0x26597D0", Length = "0x85")]
		[Token(Token = "0x60007FF")]
		 get { } //Length: 133
	}

	[Token(Token = "0x1700017A")]
	private X509Stores Factory
	{
		[Address(RVA = "0x265A460", Offset = "0x2659860", Length = "0x14")]
		[Token(Token = "0x6000800")]
		private get { } //Length: 20
	}

	[Token(Token = "0x1700017B")]
	internal X509Store Store
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000801")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x265A270", Offset = "0x2659670", Length = "0x159")]
	[Token(Token = "0x60007FE")]
	public X509Store(StoreName storeName, StoreLocation storeLocation) { }

	[Address(RVA = "0x2659E80", Offset = "0x2659280", Length = "0x39")]
	[Token(Token = "0x6000802")]
	public void Close() { }

	[Address(RVA = "0x2659E80", Offset = "0x2659280", Length = "0x39")]
	[Token(Token = "0x6000803")]
	public override void Dispose() { }

	[Address(RVA = "0x265A3D0", Offset = "0x26597D0", Length = "0x85")]
	[Token(Token = "0x60007FF")]
	public X509Certificate2Collection get_Certificates() { }

	[Address(RVA = "0x265A460", Offset = "0x2659860", Length = "0x14")]
	[Token(Token = "0x6000800")]
	private X509Stores get_Factory() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000801")]
	internal X509Store get_Store() { }

	[Address(RVA = "0x2659EC0", Offset = "0x26592C0", Length = "0x3A9")]
	[Token(Token = "0x6000804")]
	public void Open(OpenFlags flags) { }

}

