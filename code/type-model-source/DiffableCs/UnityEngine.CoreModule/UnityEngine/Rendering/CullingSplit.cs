namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[Token(Token = "0x20003A9")]
[UsedByNativeCode]
public struct CullingSplit
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B4F")]
	public Vector3 sphereCenter; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000B50")]
	public float sphereRadius; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B51")]
	public int cullingPlaneOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B52")]
	public int cullingPlaneCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B53")]
	public float cascadeBlendCullingFactor; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000B54")]
	public float nearPlane; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B55")]
	public Matrix4x4 cullingMatrix; //Field offset: 0x20

}

