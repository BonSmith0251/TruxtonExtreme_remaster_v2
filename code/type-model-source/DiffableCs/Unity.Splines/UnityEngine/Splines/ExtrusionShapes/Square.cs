namespace UnityEngine.Splines.ExtrusionShapes;

[Token(Token = "0x200006F")]
public sealed class Square : IExtrudeShape
{
	[Token(Token = "0x4000179")]
	private static readonly float2[] k_Sides; //Field offset: 0x0

	[Token(Token = "0x170000C7")]
	public override int SideCount
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x600037D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2E7F9F0", Offset = "0x2E7EDF0", Length = "0xC8")]
	[Token(Token = "0x6000380")]
	private static Square() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600037F")]
	public Square() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x600037D")]
	public override int get_SideCount() { }

	[Address(RVA = "0x2E7F970", Offset = "0x2E7ED70", Length = "0x7D")]
	[Token(Token = "0x600037E")]
	public override float2 GetPosition(float t, int index) { }

}

