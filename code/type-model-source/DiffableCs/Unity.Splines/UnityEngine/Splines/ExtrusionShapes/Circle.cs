namespace UnityEngine.Splines.ExtrusionShapes;

[Token(Token = "0x200006E")]
public sealed class Circle : IExtrudeShape
{
	[FieldOffset(Offset = "0x10")]
	[Min(2)]
	[SerializeField]
	[Token(Token = "0x4000177")]
	private int m_Sides; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000178")]
	private float m_Rads; //Field offset: 0x14

	[Token(Token = "0x170000C6")]
	public override int SideCount
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600037A")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x600037B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2E74A60", Offset = "0x2E73E60", Length = "0xE")]
	[Token(Token = "0x600037C")]
	public Circle() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600037A")]
	public override int get_SideCount() { }

	[Address(RVA = "0x2E74960", Offset = "0x2E73D60", Length = "0xCF")]
	[Token(Token = "0x6000379")]
	public override float2 GetPosition(float t, int index) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x600037B")]
	public void set_SideCount(int value) { }

	[Address(RVA = "0x2E74A30", Offset = "0x2E73E30", Length = "0x22")]
	[Token(Token = "0x6000378")]
	public override void Setup(ISpline path, int segmentCount) { }

}

