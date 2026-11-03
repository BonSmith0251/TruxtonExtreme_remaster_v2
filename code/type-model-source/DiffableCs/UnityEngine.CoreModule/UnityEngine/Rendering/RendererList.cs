namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Rendering.RendererUtils")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/RendererList.h")]
[Token(Token = "0x20003E1")]
public struct RendererList
{
	[Token(Token = "0x4000CB9")]
	public static readonly RendererList nullRendererList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CB4")]
	internal UIntPtr context; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CB5")]
	internal uint index; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CB6")]
	internal uint frame; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CB7")]
	internal uint type; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CB8")]
	internal uint contextID; //Field offset: 0x14

	[Token(Token = "0x17000437")]
	public bool isValid
	{
		[Address(RVA = "0x30C7FA0", Offset = "0x30C73A0", Length = "0x33")]
		[Token(Token = "0x6001DCA")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x30C7F20", Offset = "0x30C7320", Length = "0x5E")]
	[Token(Token = "0x6001DCC")]
	private static RendererList() { }

	[Address(RVA = "0x30C7F80", Offset = "0x30C7380", Length = "0x11")]
	[Token(Token = "0x6001DCB")]
	internal RendererList(UIntPtr ctx, uint indx) { }

	[Address(RVA = "0x30C7FA0", Offset = "0x30C73A0", Length = "0x33")]
	[Token(Token = "0x6001DCA")]
	public bool get_isValid() { }

}

