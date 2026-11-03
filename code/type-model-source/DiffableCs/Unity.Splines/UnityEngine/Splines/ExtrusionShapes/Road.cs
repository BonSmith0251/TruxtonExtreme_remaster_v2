namespace UnityEngine.Splines.ExtrusionShapes;

[Token(Token = "0x2000070")]
public sealed class Road : IExtrudeShape
{
	[Token(Token = "0x400017A")]
	private static readonly float2[] k_Sides; //Field offset: 0x0

	[Token(Token = "0x170000C8")]
	public override int SideCount
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000381")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2E74F90", Offset = "0x2E74390", Length = "0xC0")]
	[Token(Token = "0x6000384")]
	private static Road() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000383")]
	public Road() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000381")]
	public override int get_SideCount() { }

	[Address(RVA = "0x2E74F00", Offset = "0x2E74300", Length = "0x86")]
	[Token(Token = "0x6000382")]
	public override float2 GetPosition(float t, int index) { }

}

