namespace UnityEngine;

[NativeHeader("Runtime/Misc/Cache.h")]
[StaticAccessor("CacheWrapper", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x20000A3")]
public struct Cache : IEquatable<Cache>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E2")]
	private int m_Handle; //Field offset: 0x0

	[Token(Token = "0x1700006D")]
	public int expirationDelay
	{
		[Address(RVA = "0x2FD0280", Offset = "0x2FCF680", Length = "0x3E")]
		[Token(Token = "0x60002C1")]
		 set { } //Length: 62
	}

	[Token(Token = "0x17000069")]
	internal int handle
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x60002B7")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700006C")]
	public long maximumAvailableStorageSpace
	{
		[Address(RVA = "0x2FD02C0", Offset = "0x2FCF6C0", Length = "0x40")]
		[Token(Token = "0x60002BF")]
		 set { } //Length: 64
	}

	[Token(Token = "0x1700006B")]
	public string path
	{
		[Address(RVA = "0x2FD0230", Offset = "0x2FCF630", Length = "0xB")]
		[Token(Token = "0x60002BD")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700006A")]
	public bool valid
	{
		[Address(RVA = "0x2FD0240", Offset = "0x2FCF640", Length = "0x31")]
		[Token(Token = "0x60002BB")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x2FD0020", Offset = "0x2FCF420", Length = "0xAA")]
	[NativeThrows]
	[Token(Token = "0x60002BE")]
	internal static string Cache_GetPath(int handle) { }

	[Address(RVA = "0x2FCFFE0", Offset = "0x2FCF3E0", Length = "0x40")]
	[Token(Token = "0x60002C3")]
	private static void Cache_GetPath_Injected(int handle, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FD00D0", Offset = "0x2FCF4D0", Length = "0x31")]
	[Token(Token = "0x60002BC")]
	internal static bool Cache_IsValid(int handle) { }

	[Address(RVA = "0x2FD0110", Offset = "0x2FCF510", Length = "0x3E")]
	[NativeThrows]
	[Token(Token = "0x60002C2")]
	internal static void Cache_SetExpirationDelay(int handle, int value) { }

	[Address(RVA = "0x2FD0150", Offset = "0x2FCF550", Length = "0x40")]
	[NativeThrows]
	[Token(Token = "0x60002C0")]
	internal static void Cache_SetMaximumDiskSpaceAvailable(int handle, long value) { }

	[Address(RVA = "0x2FD0190", Offset = "0x2FCF590", Length = "0x81")]
	[Token(Token = "0x60002B9")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x60002BA")]
	public override bool Equals(Cache other) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x60002B7")]
	internal int get_handle() { }

	[Address(RVA = "0x2FD0230", Offset = "0x2FCF630", Length = "0xB")]
	[Token(Token = "0x60002BD")]
	public string get_path() { }

	[Address(RVA = "0x2FD0240", Offset = "0x2FCF640", Length = "0x31")]
	[Token(Token = "0x60002BB")]
	public bool get_valid() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x60002B8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FD0280", Offset = "0x2FCF680", Length = "0x3E")]
	[Token(Token = "0x60002C1")]
	public void set_expirationDelay(int value) { }

	[Address(RVA = "0x2FD02C0", Offset = "0x2FCF6C0", Length = "0x40")]
	[Token(Token = "0x60002BF")]
	public void set_maximumAvailableStorageSpace(long value) { }

}

