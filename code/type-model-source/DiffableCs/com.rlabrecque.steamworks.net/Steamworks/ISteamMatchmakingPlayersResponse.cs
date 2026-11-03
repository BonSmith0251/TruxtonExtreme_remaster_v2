namespace Steamworks;

[Token(Token = "0x200019E")]
public class ISteamMatchmakingPlayersResponse
{
	[Token(Token = "0x200019F")]
	internal sealed class AddPlayerToList : MulticastDelegate
	{

		[Address(RVA = "0x604360", Offset = "0x603760", Length = "0xB5")]
		[Token(Token = "0x600093F")]
		public AddPlayerToList(object object, IntPtr method) { }

		[Address(RVA = "0x6042C0", Offset = "0x6036C0", Length = "0x73")]
		[Token(Token = "0x6000941")]
		public override IAsyncResult BeginInvoke(string pchName, int nScore, float flTimePlayed, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000942")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x604340", Offset = "0x603740", Length = "0x14")]
		[Token(Token = "0x6000940")]
		public override void Invoke(string pchName, int nScore, float flTimePlayed) { }

	}

	[Token(Token = "0x20001A2")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalAddPlayerToList : MulticastDelegate
	{

		[Address(RVA = "0x60D5E0", Offset = "0x60C9E0", Length = "0xA6")]
		[Token(Token = "0x600094B")]
		public InternalAddPlayerToList(object object, IntPtr method) { }

		[Address(RVA = "0x60D510", Offset = "0x60C910", Length = "0xA9")]
		[Token(Token = "0x600094D")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600094E")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x600094C")]
		public override void Invoke(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	}

	[Token(Token = "0x20001A3")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalPlayersFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x600094F")]
		public InternalPlayersFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6000951")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000952")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000950")]
		public override void Invoke(IntPtr thisptr) { }

	}

	[Token(Token = "0x20001A4")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalPlayersRefreshComplete : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x6000953")]
		public InternalPlayersRefreshComplete(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6000955")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000956")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000954")]
		public override void Invoke(IntPtr thisptr) { }

	}

	[Token(Token = "0x20001A0")]
	internal sealed class PlayersFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000943")]
		public PlayersFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x6000945")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000946")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000944")]
		public override void Invoke() { }

	}

	[Token(Token = "0x20001A1")]
	internal sealed class PlayersRefreshComplete : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000947")]
		public PlayersRefreshComplete(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x6000949")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600094A")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000948")]
		public override void Invoke() { }

	}

	[Token(Token = "0x20001A5")]
	private class VTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A77")]
		public InternalAddPlayerToList m_VTAddPlayerToList; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A78")]
		public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A79")]
		public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000957")]
		public VTable() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A71")]
	private VTable m_VTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A72")]
	private IntPtr m_pVTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A73")]
	private GCHandle m_pGCHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A74")]
	private AddPlayerToList m_AddPlayerToList; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A75")]
	private PlayersFailedToRespond m_PlayersFailedToRespond; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A76")]
	private PlayersRefreshComplete m_PlayersRefreshComplete; //Field offset: 0x38

	[Address(RVA = "0x60C140", Offset = "0x60B540", Length = "0x3A1")]
	[Token(Token = "0x6000939")]
	public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete) { }

	[Address(RVA = "0x60C010", Offset = "0x60B410", Length = "0xAE")]
	[Token(Token = "0x600093A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60C0C0", Offset = "0x60B4C0", Length = "0x4F")]
	[Token(Token = "0x600093B")]
	private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) { }

	[Address(RVA = "0x60BCA0", Offset = "0x60B0A0", Length = "0x25")]
	[Token(Token = "0x600093C")]
	private void InternalOnPlayersFailedToRespond(IntPtr thisptr) { }

	[Address(RVA = "0x60C110", Offset = "0x60B510", Length = "0x25")]
	[Token(Token = "0x600093D")]
	private void InternalOnPlayersRefreshComplete(IntPtr thisptr) { }

	[Address(RVA = "0x60BFF0", Offset = "0x60B3F0", Length = "0x1D")]
	[Token(Token = "0x600093E")]
	public static IntPtr op_Explicit(ISteamMatchmakingPlayersResponse that) { }

}

