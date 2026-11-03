namespace UnityEngine.Experimental.Rendering;

[Token(Token = "0x200000C")]
public static class XRBuiltinShaderConstants
{
	[Token(Token = "0x4000023")]
	public static readonly int unity_StereoCameraProjection; //Field offset: 0x0
	[Token(Token = "0x4000024")]
	public static readonly int unity_StereoCameraInvProjection; //Field offset: 0x4
	[Token(Token = "0x4000025")]
	public static readonly int unity_StereoMatrixV; //Field offset: 0x8
	[Token(Token = "0x4000026")]
	public static readonly int unity_StereoMatrixInvV; //Field offset: 0xC
	[Token(Token = "0x4000027")]
	public static readonly int unity_StereoMatrixP; //Field offset: 0x10
	[Token(Token = "0x4000028")]
	public static readonly int unity_StereoMatrixInvP; //Field offset: 0x14
	[Token(Token = "0x4000029")]
	public static readonly int unity_StereoMatrixVP; //Field offset: 0x18
	[Token(Token = "0x400002A")]
	public static readonly int unity_StereoMatrixInvVP; //Field offset: 0x1C
	[Token(Token = "0x400002B")]
	public static readonly int unity_StereoWorldSpaceCameraPos; //Field offset: 0x20
	[Token(Token = "0x400002C")]
	private static Matrix4x4[] s_cameraProjMatrix; //Field offset: 0x28
	[Token(Token = "0x400002D")]
	private static Matrix4x4[] s_invCameraProjMatrix; //Field offset: 0x30
	[Token(Token = "0x400002E")]
	private static Matrix4x4[] s_viewMatrix; //Field offset: 0x38
	[Token(Token = "0x400002F")]
	private static Matrix4x4[] s_invViewMatrix; //Field offset: 0x40
	[Token(Token = "0x4000030")]
	private static Matrix4x4[] s_projMatrix; //Field offset: 0x48
	[Token(Token = "0x4000031")]
	private static Matrix4x4[] s_invProjMatrix; //Field offset: 0x50
	[Token(Token = "0x4000032")]
	private static Matrix4x4[] s_viewProjMatrix; //Field offset: 0x58
	[Token(Token = "0x4000033")]
	private static Matrix4x4[] s_invViewProjMatrix; //Field offset: 0x60
	[Token(Token = "0x4000034")]
	private static Vector4[] s_worldSpaceCameraPos; //Field offset: 0x68

	[Address(RVA = "0x2BC8760", Offset = "0x2BC7B60", Length = "0x3E7")]
	[Token(Token = "0x600002B")]
	private static XRBuiltinShaderConstants() { }

	[Address(RVA = "0x2BC78A0", Offset = "0x2BC6CA0", Length = "0x178")]
	[Token(Token = "0x6000028")]
	public static void SetBuiltinShaderConstants(CommandBuffer cmd) { }

	[Address(RVA = "0x2BC76D0", Offset = "0x2BC6AD0", Length = "0x1C0")]
	[Token(Token = "0x6000029")]
	public static void SetBuiltinShaderConstants(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2BC7EF0", Offset = "0x2BC72F0", Length = "0x86B")]
	[Token(Token = "0x600002A")]
	public static void Update(XRPass xrPass, CommandBuffer cmd, bool renderIntoTexture) { }

	[Address(RVA = "0x2BC7A20", Offset = "0x2BC6E20", Length = "0x4CC")]
	[Token(Token = "0x6000027")]
	public static void UpdateBuiltinShaderConstants(Matrix4x4 viewMatrix, Matrix4x4 projMatrix, bool renderIntoTexture, int viewIndex) { }

}

