namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000364")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XGameStreamingClientPropertiesChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA17F0", Offset = "0x2BA0BF0", Length = "0xA6")]
	[Token(Token = "0x60011DD")]
	public XGameStreamingClientPropertiesChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA1730", Offset = "0x2BA0B30", Length = "0xB9")]
	[Token(Token = "0x60011DF")]
	public override IAsyncResult BeginInvoke(IntPtr context, XGameStreamingClientId client, uint updatedPropertiesCount, XGameStreamingClientProperty[] updatedProperties, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60011E0")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x60011DE")]
	public override void Invoke(IntPtr context, XGameStreamingClientId client, uint updatedPropertiesCount, XGameStreamingClientProperty[] updatedProperties) { }

}

