namespace System.Net;

[Token(Token = "0x2000223")]
public class IPAddress
{
	[Token(Token = "0x2000224")]
	private sealed class ReadOnlyIPAddress : IPAddress
	{

		[Address(RVA = "0x26ABD20", Offset = "0x26AB120", Length = "0x59")]
		[Token(Token = "0x6000E74")]
		public ReadOnlyIPAddress(long newAddress) { }

	}

	[Token(Token = "0x4000816")]
	public static readonly IPAddress Any; //Field offset: 0x0
	[Token(Token = "0x400081A")]
	internal const long LoopbackMask = 255; //Field offset: 0x0
	[Token(Token = "0x4000822")]
	internal const int NumberOfLabels = 8; //Field offset: 0x0
	[Token(Token = "0x4000817")]
	public static readonly IPAddress Loopback; //Field offset: 0x8
	[Token(Token = "0x4000818")]
	public static readonly IPAddress Broadcast; //Field offset: 0x10
	[Token(Token = "0x4000819")]
	public static readonly IPAddress None; //Field offset: 0x18
	[Token(Token = "0x400081B")]
	public static readonly IPAddress IPv6Any; //Field offset: 0x20
	[Token(Token = "0x400081C")]
	public static readonly IPAddress IPv6Loopback; //Field offset: 0x28
	[Token(Token = "0x400081D")]
	public static readonly IPAddress IPv6None; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400081E")]
	private uint _addressOrScopeId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400081F")]
	private readonly UInt16[] _numbers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000820")]
	private string _toString; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000821")]
	private int _hashCode; //Field offset: 0x28

	[Token(Token = "0x170002DE")]
	public AddressFamily AddressFamily
	{
		[Address(RVA = "0x26A9F30", Offset = "0x26A9330", Length = "0x13")]
		[Token(Token = "0x6000E6A")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170002DA")]
	private bool IsIPv4
	{
		[Address(RVA = "0x195BEB0", Offset = "0x195B2B0", Length = "0x9")]
		[Token(Token = "0x6000E57")]
		private get { } //Length: 9
	}

	[Token(Token = "0x170002DB")]
	private bool IsIPv6
	{
		[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
		[Token(Token = "0x6000E58")]
		private get { } //Length: 9
	}

	[Token(Token = "0x170002DC")]
	private uint PrivateAddress
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000E59")]
		private get { } //Length: 85
		[Address(RVA = "0x26A9FB0", Offset = "0x26A93B0", Length = "0x37")]
		[Token(Token = "0x6000E5A")]
		private set { } //Length: 55
	}

	[Token(Token = "0x170002DD")]
	private uint PrivateScopeId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000E5B")]
		private get { } //Length: 85
		[Address(RVA = "0x26A9FB0", Offset = "0x26A93B0", Length = "0x37")]
		[Token(Token = "0x6000E5C")]
		private set { } //Length: 55
	}

	[Token(Token = "0x170002DF")]
	public long ScopeId
	{
		[Address(RVA = "0x26A9F50", Offset = "0x26A9350", Length = "0x5B")]
		[Token(Token = "0x6000E6B")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x26A9400", Offset = "0x26A8800", Length = "0x47A")]
	[Token(Token = "0x6000E73")]
	private static IPAddress() { }

	[Address(RVA = "0x26A9B80", Offset = "0x26A8F80", Length = "0x1C8")]
	[Token(Token = "0x6000E63")]
	public IPAddress(ReadOnlySpan<Byte> address) { }

	[Address(RVA = "0x26A9880", Offset = "0x26A8C80", Length = "0x8E")]
	[Token(Token = "0x6000E62")]
	public IPAddress(Byte[] address) { }

	[Address(RVA = "0x26A9AE0", Offset = "0x26A8EE0", Length = "0x91")]
	[Token(Token = "0x6000E5D")]
	public IPAddress(long newAddress) { }

	[Address(RVA = "0x26A9970", Offset = "0x26A8D70", Length = "0x9E")]
	[Token(Token = "0x6000E5E")]
	public IPAddress(Byte[] address, long scopeid) { }

	[Address(RVA = "0x26A9D50", Offset = "0x26A9150", Length = "0x1DD")]
	[Token(Token = "0x6000E5F")]
	public IPAddress(ReadOnlySpan<Byte> address, long scopeid) { }

	[Address(RVA = "0x26A9A10", Offset = "0x26A8E10", Length = "0xC3")]
	[Token(Token = "0x6000E60")]
	internal IPAddress(UInt16* numbers, int numbersLength, uint scopeid) { }

	[Address(RVA = "0x26A9910", Offset = "0x26A8D10", Length = "0x56")]
	[Token(Token = "0x6000E61")]
	private IPAddress(UInt16[] numbers, uint scopeid) { }

	[Address(RVA = "0x26A87B0", Offset = "0x26A7BB0", Length = "0xB")]
	[Token(Token = "0x6000E6F")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x26A87C0", Offset = "0x26A7BC0", Length = "0x13F")]
	[Token(Token = "0x6000E6E")]
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	[Address(RVA = "0x26A9F30", Offset = "0x26A9330", Length = "0x13")]
	[Token(Token = "0x6000E6A")]
	public AddressFamily get_AddressFamily() { }

	[Address(RVA = "0x195BEB0", Offset = "0x195B2B0", Length = "0x9")]
	[Token(Token = "0x6000E57")]
	private bool get_IsIPv4() { }

	[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
	[Token(Token = "0x6000E58")]
	private bool get_IsIPv6() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000E59")]
	private uint get_PrivateAddress() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000E5B")]
	private uint get_PrivateScopeId() { }

	[Address(RVA = "0x26A9F50", Offset = "0x26A9350", Length = "0x5B")]
	[Token(Token = "0x6000E6B")]
	public long get_ScopeId() { }

	[Address(RVA = "0x26A8900", Offset = "0x26A7D00", Length = "0x102")]
	[Token(Token = "0x6000E69")]
	public Byte[] GetAddressBytes() { }

	[Address(RVA = "0x26A8A10", Offset = "0x26A7E10", Length = "0x488")]
	[Token(Token = "0x6000E70")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26A8EA0", Offset = "0x26A82A0", Length = "0xD4")]
	[Token(Token = "0x6000E6D")]
	public static bool IsLoopback(IPAddress address) { }

	[Address(RVA = "0x26A8F80", Offset = "0x26A8380", Length = "0x101")]
	[Token(Token = "0x6000E71")]
	public IPAddress MapToIPv6() { }

	[Address(RVA = "0x26A9090", Offset = "0x26A8490", Length = "0xB0")]
	[Token(Token = "0x6000E65")]
	public static IPAddress Parse(string ipString) { }

	[Address(RVA = "0x26A9FB0", Offset = "0x26A93B0", Length = "0x37")]
	[Token(Token = "0x6000E5A")]
	private void set_PrivateAddress(uint value) { }

	[Address(RVA = "0x26A9FB0", Offset = "0x26A93B0", Length = "0x37")]
	[Token(Token = "0x6000E5C")]
	private void set_PrivateScopeId(uint value) { }

	[Address(RVA = "0x26A9150", Offset = "0x26A8550", Length = "0x4E")]
	[Token(Token = "0x6000E72")]
	private static Byte[] ThrowAddressNullException() { }

	[Address(RVA = "0x26A91A0", Offset = "0x26A85A0", Length = "0x60")]
	[Token(Token = "0x6000E6C")]
	public virtual string ToString() { }

	[Address(RVA = "0x26A9200", Offset = "0x26A8600", Length = "0xA7")]
	[Token(Token = "0x6000E64")]
	public static bool TryParse(string ipString, out IPAddress address) { }

	[Address(RVA = "0x26A92B0", Offset = "0x26A86B0", Length = "0xF6")]
	[Token(Token = "0x6000E66")]
	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten) { }

	[Address(RVA = "0x26A93B0", Offset = "0x26A87B0", Length = "0x4A")]
	[Token(Token = "0x6000E68")]
	private void WriteIPv4Bytes(Span<Byte> destination) { }

	[Address(RVA = "0x26980A0", Offset = "0x26974A0", Length = "0xAD")]
	[Token(Token = "0x6000E67")]
	private void WriteIPv6Bytes(Span<Byte> destination) { }

}

