namespace System.Net;

[Token(Token = "0x2000226")]
public class IPEndPoint : EndPoint
{
	[Token(Token = "0x4000825")]
	internal static IPEndPoint Any; //Field offset: 0x0
	[Token(Token = "0x4000826")]
	internal static IPEndPoint IPv6Any; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000823")]
	private IPAddress _address; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000824")]
	private int _port; //Field offset: 0x18

	[Token(Token = "0x170002E1")]
	public IPAddress Address
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E84")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002E0")]
	public virtual AddressFamily AddressFamily
	{
		[Address(RVA = "0x26AA850", Offset = "0x26A9C50", Length = "0x29")]
		[Token(Token = "0x6000E82")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170002E2")]
	public int Port
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000E85")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x26AA590", Offset = "0x26A9990", Length = "0x1CD")]
	[Token(Token = "0x6000E8B")]
	private static IPEndPoint() { }

	[Address(RVA = "0x26AA760", Offset = "0x26A9B60", Length = "0xE3")]
	[Token(Token = "0x6000E83")]
	public IPEndPoint(IPAddress address, int port) { }

	[Address(RVA = "0x26A9FF0", Offset = "0x26A93F0", Length = "0x345")]
	[Token(Token = "0x6000E88")]
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	[Address(RVA = "0x26AA340", Offset = "0x26A9740", Length = "0xA6")]
	[Token(Token = "0x6000E89")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E84")]
	public IPAddress get_Address() { }

	[Address(RVA = "0x26AA850", Offset = "0x26A9C50", Length = "0x29")]
	[Token(Token = "0x6000E82")]
	public virtual AddressFamily get_AddressFamily() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000E85")]
	public int get_Port() { }

	[Address(RVA = "0x26AA3F0", Offset = "0x26A97F0", Length = "0x33")]
	[Token(Token = "0x6000E8A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26AA430", Offset = "0x26A9830", Length = "0x9A")]
	[Token(Token = "0x6000E87")]
	public virtual SocketAddress Serialize() { }

	[Address(RVA = "0x26AA4D0", Offset = "0x26A98D0", Length = "0xBE")]
	[Token(Token = "0x6000E86")]
	public virtual string ToString() { }

}

