namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001D9")]
public class XblSocialRelationshipResult : IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004FC")]
	private XblSocialRelationshipResultHandle <InteropHandle>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FD")]
	private bool _disposed; //Field offset: 0x18

	[Token(Token = "0x170001AD")]
	internal XblSocialRelationshipResultHandle InteropHandle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D0")]
		internal get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009D1")]
		internal set { } //Length: 5
	}

	[Address(RVA = "0xD69A70", Offset = "0xD68E70", Length = "0x26")]
	[Token(Token = "0x60009CC")]
	internal XblSocialRelationshipResult(XblSocialRelationshipResultHandle interopHandle) { }

	[Address(RVA = "0x2B8C220", Offset = "0x2B8B620", Length = "0x61")]
	[Token(Token = "0x60009CE")]
	public override void Dispose() { }

	[Address(RVA = "0x2B8C1F0", Offset = "0x2B8B5F0", Length = "0x2C")]
	[Token(Token = "0x60009CF")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x60009CD")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D0")]
	internal XblSocialRelationshipResultHandle get_InteropHandle() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009D1")]
	internal void set_InteropHandle(XblSocialRelationshipResultHandle value) { }

}

