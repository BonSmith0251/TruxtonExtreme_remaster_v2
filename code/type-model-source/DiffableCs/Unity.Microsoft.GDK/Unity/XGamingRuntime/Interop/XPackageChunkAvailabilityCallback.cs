namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200037B")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XPackageChunkAvailabilityCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA3270", Offset = "0x2BA2670", Length = "0xA6")]
	[Token(Token = "0x6001202")]
	public XPackageChunkAvailabilityCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA31B0", Offset = "0x2BA25B0", Length = "0xB1")]
	[Token(Token = "0x6001204")]
	public override IAsyncResult BeginInvoke(IntPtr context, XPackageChunkSelectorInterop selector, XPackageChunkAvailability availability, AsyncCallback callback, object object) { }

	[Address(RVA = "0x27C49C0", Offset = "0x27C3DC0", Length = "0x28")]
	[Token(Token = "0x6001205")]
	public override bool EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x21524B0", Offset = "0x21518B0", Length = "0x2B")]
	[Token(Token = "0x6001203")]
	public override bool Invoke(IntPtr context, XPackageChunkSelectorInterop selector, XPackageChunkAvailability availability) { }

}

