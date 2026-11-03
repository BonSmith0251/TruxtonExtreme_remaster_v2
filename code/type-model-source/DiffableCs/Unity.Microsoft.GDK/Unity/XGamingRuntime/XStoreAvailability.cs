namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000266")]
public class XStoreAvailability
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067B")]
	internal XStoreAvailability _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400067C")]
	internal XStorePrice _xstorePrice; //Field offset: 0x60

	[Token(Token = "0x17000287")]
	public string AvailabilityId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C7A")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000C7B")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000289")]
	public long EndDate
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000C7E")]
		 get { } //Length: 5
		[Address(RVA = "0x21448A0", Offset = "0x2143CA0", Length = "0x5")]
		[Token(Token = "0x6000C7F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000286")]
	internal XStoreAvailability interop
	{
		[Address(RVA = "0x2B82870", Offset = "0x2B81C70", Length = "0x7E")]
		[Token(Token = "0x6000C78")]
		internal get { } //Length: 126
		[Address(RVA = "0x2B82950", Offset = "0x2B81D50", Length = "0x32")]
		[Token(Token = "0x6000C79")]
		internal set { } //Length: 50
	}

	[Token(Token = "0x17000288")]
	public XStorePrice Price
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000C7C")]
		 get { } //Length: 5
		[Address(RVA = "0x2B828F0", Offset = "0x2B81CF0", Length = "0x5F")]
		[Token(Token = "0x6000C7D")]
		 set { } //Length: 95
	}

	[Address(RVA = "0x2B82760", Offset = "0x2B81B60", Length = "0x102")]
	[Token(Token = "0x6000C76")]
	internal XStoreAvailability(XStoreAvailability interop) { }

	[Address(RVA = "0x2B82690", Offset = "0x2B81A90", Length = "0xC9")]
	[Token(Token = "0x6000C77")]
	public XStoreAvailability() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C7A")]
	public string get_AvailabilityId() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000C7E")]
	public long get_EndDate() { }

	[Address(RVA = "0x2B82870", Offset = "0x2B81C70", Length = "0x7E")]
	[Token(Token = "0x6000C78")]
	internal XStoreAvailability get_interop() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000C7C")]
	public XStorePrice get_Price() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000C7B")]
	public void set_AvailabilityId(string value) { }

	[Address(RVA = "0x21448A0", Offset = "0x2143CA0", Length = "0x5")]
	[Token(Token = "0x6000C7F")]
	public void set_EndDate(long value) { }

	[Address(RVA = "0x2B82950", Offset = "0x2B81D50", Length = "0x32")]
	[Token(Token = "0x6000C79")]
	internal void set_interop(XStoreAvailability value) { }

	[Address(RVA = "0x2B828F0", Offset = "0x2B81CF0", Length = "0x5F")]
	[Token(Token = "0x6000C7D")]
	public void set_Price(XStorePrice value) { }

}

