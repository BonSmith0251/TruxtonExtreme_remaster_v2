namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000085")]
internal class GetDownloadSizeOperation : AsyncOperationBase<Int64>
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000173")]
	private IEnumerable<IResourceLocation> m_Locations; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000174")]
	private bool m_Started; //Field offset: 0xA0

	[Address(RVA = "0x2E3F060", Offset = "0x2E3E460", Length = "0x39")]
	[Token(Token = "0x6000363")]
	public GetDownloadSizeOperation() { }

	[Address(RVA = "0x2E3EC40", Offset = "0x2E3E040", Length = "0x398")]
	[Token(Token = "0x6000360")]
	private void Calculate() { }

	[Address(RVA = "0x2E3EFE0", Offset = "0x2E3E3E0", Length = "0x7")]
	[Token(Token = "0x6000361")]
	protected virtual void Execute() { }

	[Address(RVA = "0x2E3EFF0", Offset = "0x2E3E3F0", Length = "0x45")]
	[Token(Token = "0x600035F")]
	public void Init(IEnumerable<IResourceLocation> locations, ResourceManager resourceManager) { }

	[Address(RVA = "0x2E3F040", Offset = "0x2E3E440", Length = "0x12")]
	[Token(Token = "0x6000362")]
	protected virtual bool InvokeWaitForCompletion() { }

}

