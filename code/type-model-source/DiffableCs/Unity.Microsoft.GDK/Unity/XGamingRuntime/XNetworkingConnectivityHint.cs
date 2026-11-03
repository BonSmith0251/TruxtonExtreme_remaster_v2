namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200023D")]
public class XNetworkingConnectivityHint
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000639")]
	internal XNetworkingConnectivityHint data; //Field offset: 0x10

	[Token(Token = "0x17000235")]
	public bool ApproachingDataLimit
	{
		[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
		[Token(Token = "0x6000B8C")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81760", Offset = "0x2B80B60", Length = "0x4")]
		[Token(Token = "0x6000B8D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000232")]
	public XNetworkingConnectivityCostHint ConnectivityCost
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000B86")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000B87")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000231")]
	public XNetworkingConnectivityLevelHint ConnectivityLevel
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B84")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B85")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000233")]
	public uint IanaInterfaceType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000B88")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000B89")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000234")]
	public bool NetworkInitialized
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x6000B8A")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
		[Token(Token = "0x6000B8B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000236")]
	public bool OverDataLimit
	{
		[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
		[Token(Token = "0x6000B8E")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81780", Offset = "0x2B80B80", Length = "0x4")]
		[Token(Token = "0x6000B8F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000237")]
	public bool Roaming
	{
		[Address(RVA = "0x2B69C00", Offset = "0x2B69000", Length = "0x5")]
		[Token(Token = "0x6000B90")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81790", Offset = "0x2B80B90", Length = "0x4")]
		[Token(Token = "0x6000B91")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000B82")]
	internal XNetworkingConnectivityHint(XNetworkingConnectivityHint interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000B83")]
	public XNetworkingConnectivityHint() { }

	[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
	[Token(Token = "0x6000B8C")]
	public bool get_ApproachingDataLimit() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000B86")]
	public XNetworkingConnectivityCostHint get_ConnectivityCost() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B84")]
	public XNetworkingConnectivityLevelHint get_ConnectivityLevel() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000B88")]
	public uint get_IanaInterfaceType() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x6000B8A")]
	public bool get_NetworkInitialized() { }

	[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
	[Token(Token = "0x6000B8E")]
	public bool get_OverDataLimit() { }

	[Address(RVA = "0x2B69C00", Offset = "0x2B69000", Length = "0x5")]
	[Token(Token = "0x6000B90")]
	public bool get_Roaming() { }

	[Address(RVA = "0x2B81760", Offset = "0x2B80B60", Length = "0x4")]
	[Token(Token = "0x6000B8D")]
	public void set_ApproachingDataLimit(bool value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000B87")]
	public void set_ConnectivityCost(XNetworkingConnectivityCostHint value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B85")]
	public void set_ConnectivityLevel(XNetworkingConnectivityLevelHint value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000B89")]
	public void set_IanaInterfaceType(uint value) { }

	[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
	[Token(Token = "0x6000B8B")]
	public void set_NetworkInitialized(bool value) { }

	[Address(RVA = "0x2B81780", Offset = "0x2B80B80", Length = "0x4")]
	[Token(Token = "0x6000B8F")]
	public void set_OverDataLimit(bool value) { }

	[Address(RVA = "0x2B81790", Offset = "0x2B80B90", Length = "0x4")]
	[Token(Token = "0x6000B91")]
	public void set_Roaming(bool value) { }

}

