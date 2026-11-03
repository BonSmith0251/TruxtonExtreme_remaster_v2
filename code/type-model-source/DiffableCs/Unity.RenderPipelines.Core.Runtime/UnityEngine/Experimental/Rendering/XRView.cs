namespace UnityEngine.Experimental.Rendering;

[IsReadOnly]
[Token(Token = "0x2000016")]
internal struct XRView
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007C")]
	internal readonly Matrix4x4 projMatrix; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007D")]
	internal readonly Matrix4x4 viewMatrix; //Field offset: 0x40
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400007E")]
	internal readonly Matrix4x4 prevViewMatrix; //Field offset: 0x80
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400007F")]
	internal readonly Rect viewport; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000080")]
	internal readonly Mesh occlusionMesh; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000081")]
	internal readonly Mesh visibleMesh; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000082")]
	internal readonly int textureArraySlice; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000083")]
	internal readonly Vector2 eyeCenterUV; //Field offset: 0xE4
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000084")]
	internal readonly bool isPrevViewMatrixValid; //Field offset: 0xEC

	[Address(RVA = "0x2BD2940", Offset = "0x2BD1D40", Length = "0x1B9")]
	[Token(Token = "0x60000AC")]
	internal XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Matrix4x4 prevViewMatrix, bool isPrevViewMatrixValid, Rect viewport, Mesh occlusionMesh, Mesh visibleMesh, int textureArraySlice) { }

	[Address(RVA = "0x2BD28A0", Offset = "0x2BD1CA0", Length = "0x9E")]
	[Token(Token = "0x60000AD")]
	private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj) { }

}

