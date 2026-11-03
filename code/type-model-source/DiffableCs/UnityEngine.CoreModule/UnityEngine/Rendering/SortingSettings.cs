namespace UnityEngine.Rendering;

[Token(Token = "0x20003F7")]
public struct SortingSettings : IEquatable<SortingSettings>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D22")]
	private Matrix4x4 m_WorldToCameraMatrix; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D23")]
	private Vector3 m_CameraPosition; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000D24")]
	private Vector3 m_CustomAxis; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D25")]
	private SortingCriteria m_Criteria; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000D26")]
	private DistanceMetric m_DistanceMetric; //Field offset: 0x5C

	[Token(Token = "0x17000473")]
	public SortingCriteria criteria
	{
		[Address(RVA = "0x30CD7C0", Offset = "0x30CCBC0", Length = "0x6")]
		[Token(Token = "0x6001E99")]
		 get { } //Length: 6
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x6001E9A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000472")]
	public Vector3 customAxis
	{
		[Address(RVA = "0x30CD7D0", Offset = "0x30CCBD0", Length = "0x10")]
		[Token(Token = "0x6001E98")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000474")]
	public DistanceMetric distanceMetric
	{
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x6001E9B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30CD6F0", Offset = "0x30CCAF0", Length = "0xCC")]
	[Token(Token = "0x6001E97")]
	public SortingSettings(Camera camera) { }

	[Address(RVA = "0x30CD450", Offset = "0x30CC850", Length = "0xEE")]
	[Token(Token = "0x6001E9C")]
	public override bool Equals(SortingSettings other) { }

	[Address(RVA = "0x30CD540", Offset = "0x30CC940", Length = "0xD0")]
	[Token(Token = "0x6001E9D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30CD7C0", Offset = "0x30CCBC0", Length = "0x6")]
	[Token(Token = "0x6001E99")]
	public SortingCriteria get_criteria() { }

	[Address(RVA = "0x30CD620", Offset = "0x30CCA20", Length = "0xCF")]
	[Token(Token = "0x6001E9E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x6001E9A")]
	public void set_criteria(SortingCriteria value) { }

	[Address(RVA = "0x30CD7D0", Offset = "0x30CCBD0", Length = "0x10")]
	[Token(Token = "0x6001E98")]
	public void set_customAxis(Vector3 value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x6001E9B")]
	public void set_distanceMetric(DistanceMetric value) { }

}

