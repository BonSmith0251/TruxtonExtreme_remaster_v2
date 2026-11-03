namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
[Token(Token = "0x2000127")]
public class MeshRenderer : Renderer
{

	[Token(Token = "0x170001D1")]
	public Mesh additionalVertexStreams
	{
		[Address(RVA = "0x3022400", Offset = "0x3021800", Length = "0x90")]
		[Token(Token = "0x6000B21")]
		 get { } //Length: 144
		[Address(RVA = "0x3022690", Offset = "0x3021A90", Length = "0xBA")]
		[Token(Token = "0x6000B22")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170001D2")]
	public Mesh enlightenVertexStream
	{
		[Address(RVA = "0x30224E0", Offset = "0x30218E0", Length = "0x90")]
		[Token(Token = "0x6000B23")]
		 get { } //Length: 144
		[Address(RVA = "0x30227A0", Offset = "0x3021BA0", Length = "0xBA")]
		[Token(Token = "0x6000B24")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170001D3")]
	public int subMeshStartIndex
	{
		[Address(RVA = "0x30225C0", Offset = "0x30219C0", Length = "0x76")]
		[NativeName("GetSubMeshStartIndex")]
		[Token(Token = "0x6000B25")]
		 get { } //Length: 118
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000B2A")]
	public MeshRenderer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000B20")]
	private void DontStripMeshRenderer() { }

	[Address(RVA = "0x3022400", Offset = "0x3021800", Length = "0x90")]
	[Token(Token = "0x6000B21")]
	public Mesh get_additionalVertexStreams() { }

	[Address(RVA = "0x30223C0", Offset = "0x30217C0", Length = "0x33")]
	[Token(Token = "0x6000B2B")]
	private static IntPtr get_additionalVertexStreams_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30224E0", Offset = "0x30218E0", Length = "0x90")]
	[Token(Token = "0x6000B23")]
	public Mesh get_enlightenVertexStream() { }

	[Address(RVA = "0x30224A0", Offset = "0x30218A0", Length = "0x33")]
	[Token(Token = "0x6000B2D")]
	private static IntPtr get_enlightenVertexStream_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30225C0", Offset = "0x30219C0", Length = "0x76")]
	[NativeName("GetSubMeshStartIndex")]
	[Token(Token = "0x6000B25")]
	public int get_subMeshStartIndex() { }

	[Address(RVA = "0x3022580", Offset = "0x3021980", Length = "0x33")]
	[Token(Token = "0x6000B2F")]
	private static int get_subMeshStartIndex_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3022230", Offset = "0x3021630", Length = "0x76")]
	[Token(Token = "0x6000B29")]
	public uint GetShaderUserValue() { }

	[Address(RVA = "0x3022230", Offset = "0x3021630", Length = "0x76")]
	[FreeFunction(Name = "MeshRendererScripting::GetShaderUserValue", HasExplicitThis = True)]
	[Token(Token = "0x6000B28")]
	internal uint Internal_GetShaderUserValueUInt() { }

	[Address(RVA = "0x30222B0", Offset = "0x30216B0", Length = "0x33")]
	[Token(Token = "0x6000B31")]
	private static uint Internal_GetShaderUserValueUInt_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3022330", Offset = "0x3021730", Length = "0x83")]
	[FreeFunction(Name = "MeshRendererScripting::SetShaderUserValue", HasExplicitThis = True)]
	[Token(Token = "0x6000B26")]
	internal void Internal_SetShaderUserValueUInt(uint v) { }

	[Address(RVA = "0x30222F0", Offset = "0x30216F0", Length = "0x40")]
	[Token(Token = "0x6000B30")]
	private static void Internal_SetShaderUserValueUInt_Injected(IntPtr _unity_self, uint v) { }

	[Address(RVA = "0x3022690", Offset = "0x3021A90", Length = "0xBA")]
	[Token(Token = "0x6000B22")]
	public void set_additionalVertexStreams(Mesh value) { }

	[Address(RVA = "0x3022640", Offset = "0x3021A40", Length = "0x42")]
	[Token(Token = "0x6000B2C")]
	private static void set_additionalVertexStreams_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x30227A0", Offset = "0x3021BA0", Length = "0xBA")]
	[Token(Token = "0x6000B24")]
	public void set_enlightenVertexStream(Mesh value) { }

	[Address(RVA = "0x3022750", Offset = "0x3021B50", Length = "0x42")]
	[Token(Token = "0x6000B2E")]
	private static void set_enlightenVertexStream_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x3022330", Offset = "0x3021730", Length = "0x83")]
	[Token(Token = "0x6000B27")]
	public void SetShaderUserValue(uint v) { }

}

