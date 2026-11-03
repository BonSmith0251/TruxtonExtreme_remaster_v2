namespace Steamworks;

[Token(Token = "0x2000190")]
public class ISteamMatchmakingServerListResponse
{
	[Token(Token = "0x2000196")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalRefreshComplete : MulticastDelegate
	{

		[Address(RVA = "0x60D870", Offset = "0x60CC70", Length = "0xA6")]
		[Token(Token = "0x600091E")]
		public InternalRefreshComplete(object object, IntPtr method) { }

		[Address(RVA = "0x60D7A0", Offset = "0x60CBA0", Length = "0xAB")]
		[Token(Token = "0x6000920")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000921")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600091F")]
		public override void Invoke(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	}

	[Token(Token = "0x2000195")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalServerFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x60D870", Offset = "0x60CC70", Length = "0xA6")]
		[Token(Token = "0x600091A")]
		public InternalServerFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x60DA60", Offset = "0x60CE60", Length = "0x9F")]
		[Token(Token = "0x600091C")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600091D")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600091B")]
		public override void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	}

	[Token(Token = "0x2000194")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	private sealed class InternalServerResponded : MulticastDelegate
	{

		[Address(RVA = "0x60D870", Offset = "0x60CC70", Length = "0xA6")]
		[Token(Token = "0x6000916")]
		public InternalServerResponded(object object, IntPtr method) { }

		[Address(RVA = "0x60DB00", Offset = "0x60CF00", Length = "0x9F")]
		[Token(Token = "0x6000918")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000919")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000917")]
		public override void Invoke(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	}

	[Token(Token = "0x2000193")]
	internal sealed class RefreshComplete : MulticastDelegate
	{

		[Address(RVA = "0x639650", Offset = "0x638A50", Length = "0xA6")]
		[Token(Token = "0x6000912")]
		public RefreshComplete(object object, IntPtr method) { }

		[Address(RVA = "0x6395B0", Offset = "0x6389B0", Length = "0x9D")]
		[Token(Token = "0x6000914")]
		public override IAsyncResult BeginInvoke(HServerListRequest hRequest, EMatchMakingServerResponse response, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000915")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000913")]
		public override void Invoke(HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	}

	[Token(Token = "0x2000192")]
	internal sealed class ServerFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x639650", Offset = "0x638A50", Length = "0xA6")]
		[Token(Token = "0x600090E")]
		public ServerFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x639F80", Offset = "0x639380", Length = "0x91")]
		[Token(Token = "0x6000910")]
		public override IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000911")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600090F")]
		public override void Invoke(HServerListRequest hRequest, int iServer) { }

	}

	[Token(Token = "0x2000191")]
	internal sealed class ServerResponded : MulticastDelegate
	{

		[Address(RVA = "0x639650", Offset = "0x638A50", Length = "0xA6")]
		[Token(Token = "0x600090A")]
		public ServerResponded(object object, IntPtr method) { }

		[Address(RVA = "0x63A020", Offset = "0x639420", Length = "0x91")]
		[Token(Token = "0x600090C")]
		public override IAsyncResult BeginInvoke(HServerListRequest hRequest, int iServer, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600090D")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600090B")]
		public override void Invoke(HServerListRequest hRequest, int iServer) { }

	}

	[Token(Token = "0x2000197")]
	private class VTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A67")]
		public InternalServerResponded m_VTServerResponded; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A68")]
		public InternalServerFailedToRespond m_VTServerFailedToRespond; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A69")]
		public InternalRefreshComplete m_VTRefreshComplete; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000922")]
		public VTable() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A61")]
	private VTable m_VTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A62")]
	private IntPtr m_pVTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A63")]
	private GCHandle m_pGCHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A64")]
	private ServerResponded m_ServerResponded; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A65")]
	private ServerFailedToRespond m_ServerFailedToRespond; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A66")]
	private RefreshComplete m_RefreshComplete; //Field offset: 0x38

	[Address(RVA = "0x60CBB0", Offset = "0x60BFB0", Length = "0x3A1")]
	[Token(Token = "0x6000904")]
	public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete) { }

	[Address(RVA = "0x60C9B0", Offset = "0x60BDB0", Length = "0xAE")]
	[Token(Token = "0x6000905")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60CA60", Offset = "0x60BE60", Length = "0x63")]
	[Token(Token = "0x6000908")]
	private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response) { }

	[Address(RVA = "0x60CAD0", Offset = "0x60BED0", Length = "0x63")]
	[Token(Token = "0x6000907")]
	private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	[Address(RVA = "0x60CB40", Offset = "0x60BF40", Length = "0x63")]
	[Token(Token = "0x6000906")]
	private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer) { }

	[Address(RVA = "0x60BFF0", Offset = "0x60B3F0", Length = "0x1D")]
	[Token(Token = "0x6000909")]
	public static IntPtr op_Explicit(ISteamMatchmakingServerListResponse that) { }

}

