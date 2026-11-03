namespace UnityEngine.Splines;

[Token(Token = "0x2000029")]
public abstract class SplineComponent : MonoBehaviour
{
	[Token(Token = "0x200002A")]
	internal enum AlignAxis : int
	{
		XAxis = 0,
		YAxis = 1,
		ZAxis = 2,
		NegativeXAxis = 3,
		NegativeYAxis = 4,
		NegativeZAxis = 5,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000096")]
	private readonly float3[] m_AlignAxisToVector; //Field offset: 0x20

	[Address(RVA = "0x2E5F3F0", Offset = "0x2E5E7F0", Length = "0x108")]
	[Token(Token = "0x6000172")]
	protected SplineComponent() { }

	[Address(RVA = "0x2E5F3A0", Offset = "0x2E5E7A0", Length = "0x45")]
	[Token(Token = "0x6000171")]
	protected float3 GetAxis(AlignAxis axis) { }

}

