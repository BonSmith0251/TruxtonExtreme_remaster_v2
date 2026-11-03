namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000077")]
public abstract class ShadowShape2D
{
	[Token(Token = "0x2000078")]
	internal enum OutlineTopology : int
	{
		Lines = 0,
		Triangles = 1,
	}

	[Token(Token = "0x2000079")]
	internal enum WindingOrder : int
	{
		Clockwise = 0,
		CounterClockwise = 1,
	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002E9")]
	protected ShadowShape2D() { }

	[Token(Token = "0x60002E5")]
	public abstract void GetFlip(out bool flipX, out bool flipY) { }

	[Token(Token = "0x60002E6")]
	public abstract void SetDefaultTrim(float trim) { }

	[Token(Token = "0x60002E4")]
	public abstract void SetFlip(bool flipX, bool flipY) { }

	[Token(Token = "0x60002E7")]
	public abstract void SetShape(NativeArray<Vector3> vertices, NativeArray<Int32> indices, NativeArray<Single> radii, Matrix4x4 transform, WindingOrder windingOrder = 0, bool allowContraction = true, bool createInteriorGeometry = false) { }

	[Token(Token = "0x60002E8")]
	public abstract void SetShape(NativeArray<Vector3> vertices, NativeArray<Int32> indices, OutlineTopology outlineTopology, WindingOrder windingOrder = 0, bool allowContraction = true, bool createInteriorGeometry = false) { }

}

