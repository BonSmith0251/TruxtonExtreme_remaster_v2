namespace UnityEngine.Splines;

[Token(Token = "0x2000010")]
public interface IExtrudeShape
{

	[Token(Token = "0x1700000A")]
	public int SideCount
	{
		[Token(Token = "0x6000059")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000059")]
	public int get_SideCount() { }

	[Token(Token = "0x600005A")]
	public float2 GetPosition(float t, int index) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000058")]
	public void SetSegment(int index, float t, float3 position, float3 tangent, float3 up) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000057")]
	public void Setup(ISpline path, int segmentCount) { }

}

