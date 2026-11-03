namespace UnityEngine.XR;

[Token(Token = "0x2000006")]
[UsedByNativeCode]
public struct XRNodeState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001C")]
	private XRNode m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001D")]
	private AvailableTrackingData m_AvailableFields; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001E")]
	private Vector3 m_Position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400001F")]
	private Quaternion m_Rotation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000020")]
	private Vector3 m_Velocity; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000021")]
	private Vector3 m_AngularVelocity; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000022")]
	private Vector3 m_Acceleration; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000023")]
	private Vector3 m_AngularAcceleration; //Field offset: 0x48
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000024")]
	private int m_Tracked; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000025")]
	private ulong m_UniqueID; //Field offset: 0x58

	[Token(Token = "0x17000002")]
	public XRNode nodeType
	{
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000003")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000003")]
	public bool tracked
	{
		[Address(RVA = "0x3493FB0", Offset = "0x34933B0", Length = "0x9")]
		[Token(Token = "0x6000004")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000001")]
	public ulong uniqueID
	{
		[Address(RVA = "0x21448A0", Offset = "0x2143CA0", Length = "0x5")]
		[Token(Token = "0x6000002")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000003")]
	public void set_nodeType(XRNode value) { }

	[Address(RVA = "0x3493FB0", Offset = "0x34933B0", Length = "0x9")]
	[Token(Token = "0x6000004")]
	public void set_tracked(bool value) { }

	[Address(RVA = "0x21448A0", Offset = "0x2143CA0", Length = "0x5")]
	[Token(Token = "0x6000002")]
	public void set_uniqueID(ulong value) { }

}

