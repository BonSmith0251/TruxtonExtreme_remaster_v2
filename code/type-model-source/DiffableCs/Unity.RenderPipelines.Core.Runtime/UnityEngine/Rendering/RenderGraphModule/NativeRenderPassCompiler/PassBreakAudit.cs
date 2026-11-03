namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("{reason} : {breakPass}")]
[IsReadOnly]
[Token(Token = "0x20002C5")]
internal struct PassBreakAudit
{
	[Token(Token = "0x4000CD6")]
	public static readonly String[] BreakReasonMessages; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CD4")]
	public readonly PassBreakReason reason; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CD5")]
	public readonly int breakPass; //Field offset: 0x4

	[Address(RVA = "0x2CBC610", Offset = "0x2CBBA10", Length = "0x385")]
	[Token(Token = "0x600139E")]
	private static PassBreakAudit() { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x600139D")]
	public PassBreakAudit(PassBreakReason reason, int breakPass) { }

}

