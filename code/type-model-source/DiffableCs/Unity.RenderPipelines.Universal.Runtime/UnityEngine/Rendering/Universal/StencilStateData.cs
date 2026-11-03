namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000015")]
public class StencilStateData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005F")]
	public bool overrideStencilState; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000060")]
	public int stencilReference; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000061")]
	public CompareFunction stencilCompareFunction; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000062")]
	public StencilOp passOperation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000063")]
	public StencilOp failOperation; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000064")]
	public StencilOp zFailOperation; //Field offset: 0x24

	[Address(RVA = "0x2D60590", Offset = "0x2D5F990", Length = "0xE")]
	[Token(Token = "0x600003D")]
	public StencilStateData() { }

}

