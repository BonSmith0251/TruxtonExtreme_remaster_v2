namespace Unity.XGamingRuntime;

[Token(Token = "0x2000254")]
public sealed class XPackageChunkAvailabilityCallback : MulticastDelegate
{

	[Address(RVA = "0x2B81D80", Offset = "0x2B81180", Length = "0xA6")]
	[Token(Token = "0x6000C17")]
	public XPackageChunkAvailabilityCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B81CE0", Offset = "0x2B810E0", Length = "0x96")]
	[Token(Token = "0x6000C19")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageChunkSelector selector, XPackageChunkAvailability availability, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x6000C1A")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000C18")]
	public override bool Invoke(IntPtr context, XPackageChunkSelector selector, XPackageChunkAvailability availability) { }

}

