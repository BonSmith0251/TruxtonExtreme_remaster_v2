namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("{reason} : {passId} / MSAA {msaaReason} : {msaaPassId}")]
[IsReadOnly]
[Token(Token = "0x20002C3")]
internal struct StoreAudit
{
	[Token(Token = "0x4000CBD")]
	public static readonly String[] StoreReasonMessages; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CBE")]
	public readonly StoreReason reason; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CBF")]
	public readonly int passId; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CC0")]
	public readonly StoreReason msaaReason; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CC1")]
	public readonly int msaaPassId; //Field offset: 0xC

	[Address(RVA = "0x2CBF580", Offset = "0x2CBE980", Length = "0x19C")]
	[Token(Token = "0x600139C")]
	private static StoreAudit() { }

	[Address(RVA = "0x27F6A90", Offset = "0x27F5E90", Length = "0x12")]
	[Token(Token = "0x600139B")]
	public StoreAudit(StoreReason setReason, int setPassId = -1, StoreReason setMsaaReason = 6, int setMsaaPassId = -1) { }

}

