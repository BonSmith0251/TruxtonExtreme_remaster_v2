namespace UnityEngine.Splines.ExtrusionShapes;

[Token(Token = "0x2000071")]
public class SplineShape : IExtrudeShape
{
	[Token(Token = "0x2000072")]
	internal enum Axis : int
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400017B")]
	private SplineContainer m_Template; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[SplineIndex("m_Template")]
	[Token(Token = "0x400017C")]
	private int m_SplineIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Min(2)]
	[SerializeField]
	[Token(Token = "0x400017D")]
	private int m_SideCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400017E")]
	[Tooltip("The axis of the template spline to be used when winding the vertices along the extruded mesh.")]
	public Axis m_Axis; //Field offset: 0x20

	[Token(Token = "0x170000C9")]
	public override int SideCount
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000385")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000386")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000CC")]
	public Spline Spline
	{
		[Address(RVA = "0x2E76F50", Offset = "0x2E76350", Length = "0xC5")]
		[Token(Token = "0x600038B")]
		 get { } //Length: 197
	}

	[Token(Token = "0x170000CA")]
	public SplineContainer SplineContainer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000387")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000388")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000CB")]
	public int SplineIndex
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000389")]
		 get { } //Length: 4
		[Address(RVA = "0x2E77020", Offset = "0x2E76420", Length = "0xD")]
		[Token(Token = "0x600038A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2E76F30", Offset = "0x2E76330", Length = "0x15")]
	[Token(Token = "0x600038D")]
	public SplineShape() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000385")]
	public override int get_SideCount() { }

	[Address(RVA = "0x2E76F50", Offset = "0x2E76350", Length = "0xC5")]
	[Token(Token = "0x600038B")]
	public Spline get_Spline() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000387")]
	public SplineContainer get_SplineContainer() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000389")]
	public int get_SplineIndex() { }

	[Address(RVA = "0x2E76DB0", Offset = "0x2E761B0", Length = "0x17F")]
	[Token(Token = "0x600038C")]
	public override float2 GetPosition(float t, int index) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000386")]
	public void set_SideCount(int value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000388")]
	public void set_SplineContainer(SplineContainer value) { }

	[Address(RVA = "0x2E77020", Offset = "0x2E76420", Length = "0xD")]
	[Token(Token = "0x600038A")]
	public void set_SplineIndex(int value) { }

}

