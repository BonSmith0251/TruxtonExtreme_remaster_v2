namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("{reason} : {passId}")]
[IsReadOnly]
[Token(Token = "0x20002C1")]
internal struct LoadAudit
{
	[Token(Token = "0x4000CB1")]
	public static readonly String[] LoadReasonMessages; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CB2")]
	public readonly LoadReason reason; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CB3")]
	public readonly int passId; //Field offset: 0x4

	[Address(RVA = "0x2CB94F0", Offset = "0x2CB88F0", Length = "0x172")]
	[Token(Token = "0x600139A")]
	private static LoadAudit() { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6001399")]
	public LoadAudit(LoadReason setReason, int setPassId = -1) { }

}

