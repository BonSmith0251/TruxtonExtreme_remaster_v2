namespace Steamworks;

[Token(Token = "0x20001A6")]
public class ISteamMatchmakingRulesResponse
{
	[Token(Token = "0x20001AB")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalRulesFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x600096E")]
		public InternalRulesFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6000970")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000971")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600096F")]
		public override void Invoke(IntPtr thisptr) { }

	}

	[Token(Token = "0x20001AC")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalRulesRefreshComplete : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x6000972")]
		public InternalRulesRefreshComplete(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6000974")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000975")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000973")]
		public override void Invoke(IntPtr thisptr) { }

	}

	[Token(Token = "0x20001AA")]
	[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
	internal sealed class InternalRulesResponded : MulticastDelegate
	{

		[Address(RVA = "0x60D9B0", Offset = "0x60CDB0", Length = "0xA6")]
		[Token(Token = "0x600096A")]
		public InternalRulesResponded(object object, IntPtr method) { }

		[Address(RVA = "0x60D920", Offset = "0x60CD20", Length = "0x83")]
		[Token(Token = "0x600096C")]
		public override IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600096D")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600096B")]
		public override void Invoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) { }

	}

	[Token(Token = "0x20001A8")]
	internal sealed class RulesFailedToRespond : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000962")]
		public RulesFailedToRespond(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x6000964")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000965")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000963")]
		public override void Invoke() { }

	}

	[Token(Token = "0x20001A9")]
	internal sealed class RulesRefreshComplete : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000966")]
		public RulesRefreshComplete(object object, IntPtr method) { }

		[Address(RVA = "0x639240", Offset = "0x638640", Length = "0x22")]
		[Token(Token = "0x6000968")]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000969")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000967")]
		public override void Invoke() { }

	}

	[Token(Token = "0x20001A7")]
	internal sealed class RulesResponded : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x600095E")]
		public RulesResponded(object object, IntPtr method) { }

		[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
		[Token(Token = "0x6000960")]
		public override IAsyncResult BeginInvoke(string pchRule, string pchValue, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000961")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600095F")]
		public override void Invoke(string pchRule, string pchValue) { }

	}

	[Token(Token = "0x20001AD")]
	private class VTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A80")]
		public InternalRulesResponded m_VTRulesResponded; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A81")]
		public InternalRulesFailedToRespond m_VTRulesFailedToRespond; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A82")]
		public InternalRulesRefreshComplete m_VTRulesRefreshComplete; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000976")]
		public VTable() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A7A")]
	private VTable m_VTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A7B")]
	private IntPtr m_pVTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A7C")]
	private GCHandle m_pGCHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A7D")]
	private RulesResponded m_RulesResponded; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A7E")]
	private RulesFailedToRespond m_RulesFailedToRespond; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A7F")]
	private RulesRefreshComplete m_RulesRefreshComplete; //Field offset: 0x38

	[Address(RVA = "0x60C600", Offset = "0x60BA00", Length = "0x3A1")]
	[Token(Token = "0x6000958")]
	public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete) { }

	[Address(RVA = "0x60C4F0", Offset = "0x60B8F0", Length = "0xAE")]
	[Token(Token = "0x6000959")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60BCA0", Offset = "0x60B0A0", Length = "0x25")]
	[Token(Token = "0x600095B")]
	private void InternalOnRulesFailedToRespond(IntPtr thisptr) { }

	[Address(RVA = "0x60C110", Offset = "0x60B510", Length = "0x25")]
	[Token(Token = "0x600095C")]
	private void InternalOnRulesRefreshComplete(IntPtr thisptr) { }

	[Address(RVA = "0x60C5A0", Offset = "0x60B9A0", Length = "0x5B")]
	[Token(Token = "0x600095A")]
	private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue) { }

	[Address(RVA = "0x60BFF0", Offset = "0x60B3F0", Length = "0x1D")]
	[Token(Token = "0x600095D")]
	public static IntPtr op_Explicit(ISteamMatchmakingRulesResponse that) { }

}

