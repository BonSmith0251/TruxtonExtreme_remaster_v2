namespace Steamworks;

[Token(Token = "0x2000198")]
public class ISteamMatchmakingPingResponse
{
	[Token(Token = "0x200019C")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalServerFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x6000934")]
		public InternalServerFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6000936")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000937")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000935")]
		public override void Invoke(IntPtr thisptr) { }

	}

	[Token(Token = "0x200019B")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalServerResponded : MulticastDelegate
	{

		[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
		[Token(Token = "0x6000930")]
		public InternalServerResponded(object object, IntPtr method) { }

		[Address(RVA = "0x60DBA0", Offset = "0x60CFA0", Length = "0x6C")]
		[Token(Token = "0x6000932")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, gameserveritem_t server, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000933")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000931")]
		public override void Invoke(IntPtr thisptr, gameserveritem_t server) { }

	}

	[Token(Token = "0x200019A")]
	internal sealed class ServerFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x600092C")]
		public ServerFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x600092E")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600092F")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x600092D")]
		public override void Invoke() { }

	}

	[Token(Token = "0x2000199")]
	internal sealed class ServerResponded : MulticastDelegate
	{

		[Address(RVA = "0x5BC6F0", Offset = "0x5BBAF0", Length = "0x124")]
		[Token(Token = "0x6000928")]
		public ServerResponded(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x600092A")]
		public override IAsyncResult BeginInvoke(gameserveritem_t server, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600092B")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000929")]
		public override void Invoke(gameserveritem_t server) { }

	}

	[Token(Token = "0x200019D")]
	private class VTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A6F")]
		public InternalServerResponded m_VTServerResponded; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A70")]
		public InternalServerFailedToRespond m_VTServerFailedToRespond; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000938")]
		public VTable() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A6A")]
	private VTable m_VTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A6B")]
	private IntPtr m_pVTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A6C")]
	private GCHandle m_pGCHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A6D")]
	private ServerResponded m_ServerResponded; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A6E")]
	private ServerFailedToRespond m_ServerFailedToRespond; //Field offset: 0x30

	[Address(RVA = "0x60BD00", Offset = "0x60B100", Length = "0x2EA")]
	[Token(Token = "0x6000923")]
	public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond) { }

	[Address(RVA = "0x60BBF0", Offset = "0x60AFF0", Length = "0xAE")]
	[Token(Token = "0x6000924")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60BCA0", Offset = "0x60B0A0", Length = "0x25")]
	[Token(Token = "0x6000926")]
	private void InternalOnServerFailedToRespond(IntPtr thisptr) { }

	[Address(RVA = "0x60BCD0", Offset = "0x60B0D0", Length = "0x2B")]
	[Token(Token = "0x6000925")]
	private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server) { }

	[Address(RVA = "0x60BFF0", Offset = "0x60B3F0", Length = "0x1D")]
	[Token(Token = "0x6000927")]
	public static IntPtr op_Explicit(ISteamMatchmakingPingResponse that) { }

}

