namespace UnityEngine.Splines;

[Token(Token = "0x200000E")]
public class EmbeddedSplineData
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000020")]
	private SplineContainer m_Container; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private int m_SplineIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private EmbeddedSplineDataType m_Type; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private string m_Key; //Field offset: 0x20

	[Token(Token = "0x17000006")]
	public SplineContainer Container
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000045")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000009")]
	public string Key
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600004A")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x600004B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000007")]
	public int SplineIndex
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000047")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public EmbeddedSplineDataType Type
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000048")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000049")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2E59CF0", Offset = "0x2E590F0", Length = "0x66")]
	[Token(Token = "0x600004D")]
	public EmbeddedSplineData(string key, EmbeddedSplineDataType type, SplineContainer container = null, int splineIndex = 0) { }

	[Address(RVA = "0x2E59CA0", Offset = "0x2E590A0", Length = "0x4A")]
	[Token(Token = "0x600004C")]
	public EmbeddedSplineData() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000044")]
	public SplineContainer get_Container() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600004A")]
	public string get_Key() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000046")]
	public int get_SplineIndex() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000048")]
	public EmbeddedSplineDataType get_Type() { }

	[Address(RVA = "0x2E58FD0", Offset = "0x2E583D0", Length = "0x16C")]
	[Token(Token = "0x6000054")]
	public SplineData<float4> GetOrCreateFloat4Data() { }

	[Address(RVA = "0x2E59140", Offset = "0x2E58540", Length = "0x165")]
	[Token(Token = "0x6000053")]
	public SplineData<Single> GetOrCreateFloatData() { }

	[Address(RVA = "0x2E592B0", Offset = "0x2E586B0", Length = "0x165")]
	[Token(Token = "0x6000055")]
	public SplineData<Int32> GetOrCreateIntData() { }

	[Address(RVA = "0x2E59420", Offset = "0x2E58820", Length = "0x16C")]
	[Token(Token = "0x6000056")]
	public SplineData<Object> GetOrCreateObjectData() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000045")]
	public void set_Container(SplineContainer value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600004B")]
	public void set_Key(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000047")]
	public void set_SplineIndex(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000049")]
	public void set_Type(EmbeddedSplineDataType value) { }

	[Address(RVA = "0x2E59590", Offset = "0x2E58990", Length = "0x17B")]
	[Token(Token = "0x6000050")]
	public bool TryGetFloat4Data(out SplineData<float4>& data) { }

	[Address(RVA = "0x2E59710", Offset = "0x2E58B10", Length = "0x174")]
	[Token(Token = "0x600004F")]
	public bool TryGetFloatData(out SplineData<Single>& data) { }

	[Address(RVA = "0x2E59890", Offset = "0x2E58C90", Length = "0x174")]
	[Token(Token = "0x6000051")]
	public bool TryGetIntData(out SplineData<Int32>& data) { }

	[Address(RVA = "0x2E59A10", Offset = "0x2E58E10", Length = "0x17B")]
	[Token(Token = "0x6000052")]
	public bool TryGetObjectData(out SplineData<Object>& data) { }

	[Address(RVA = "0x2E59B90", Offset = "0x2E58F90", Length = "0x101")]
	[Token(Token = "0x600004E")]
	public bool TryGetSpline(out Spline spline) { }

}

