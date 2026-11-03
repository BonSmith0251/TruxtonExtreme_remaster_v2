namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RendererList ({handle})")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000296")]
public struct RendererListHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B8B")]
	internal RendererListHandleType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B8C")]
	private bool m_IsValid; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B8D")]
	private int <handle>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000256")]
	internal int handle
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012B1")]
		internal get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60012B2")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2CAA420", Offset = "0x2CA9820", Length = "0xB")]
	[Token(Token = "0x60012B3")]
	internal RendererListHandle(int handle, RendererListHandleType type = 0) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60012B1")]
	internal int get_handle() { }

	[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
	[Token(Token = "0x60012B6")]
	public bool IsValid() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60012B4")]
	public static int op_Implicit(RendererListHandle handle) { }

	[Address(RVA = "0x2CAA430", Offset = "0x2CA9830", Length = "0xF5")]
	[Token(Token = "0x60012B5")]
	public static RendererList op_Implicit(RendererListHandle rendererList) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60012B2")]
	private void set_handle(int value) { }

}

