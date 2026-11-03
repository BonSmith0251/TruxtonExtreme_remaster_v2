namespace Steamworks;

[Token(Token = "0x2000187")]
public sealed class CallResult : CallResult, IDisposable
{
	[Token(Token = "0x2000188")]
	internal sealed class APIDispatchDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1B5CD30", Offset = "0x1B5C130", Length = "0xA6")]
		[Token(Token = "0x60008EA")]
		public APIDispatchDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x1B5C9B0", Offset = "0x1B5BDB0", Length = "0x97")]
		[Token(Token = "0x60008EC")]
		public override IAsyncResult BeginInvoke(T param, bool bIOFailure, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60008ED")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0xF769C0", Offset = "0xF75DC0", Length = "0x24")]
		[Token(Token = "0x60008EB")]
		public override void Invoke(T param, bool bIOFailure) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A58")]
	private APIDispatchDelegate<T> m_Func; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A59")]
	private SteamAPICall_t m_hAPICall; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A5A")]
	private bool m_bDisposed; //Field offset: 0x0

	[Token(Token = "0x14000002")]
	private event APIDispatchDelegate<T> m_Func
	{
		[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60008DD")]
		private add { } //Length: 192
		[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60008DE")]
		private remove { } //Length: 192
	}

	[Token(Token = "0x17000024")]
	public SteamAPICall_t Handle
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008DF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16C1680", Offset = "0x16C0A80", Length = "0x7D")]
	[Token(Token = "0x60008E1")]
	public CallResult`1(APIDispatchDelegate<T> func = null) { }

	[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60008DD")]
	private void add_m_Func(APIDispatchDelegate<T> value) { }

	[Address(RVA = "0x16BFA10", Offset = "0x16BEE10", Length = "0xB3")]
	[Token(Token = "0x60008E6")]
	public void Cancel() { }

	[Address(RVA = "0x16BFDB0", Offset = "0x16BF1B0", Length = "0xD8")]
	[Token(Token = "0x60008E0")]
	public static CallResult<T> Create(APIDispatchDelegate<T> func = null) { }

	[Address(RVA = "0x16C01B0", Offset = "0x16BF5B0", Length = "0xFD")]
	[Token(Token = "0x60008E3")]
	public override void Dispose() { }

	[Address(RVA = "0x16C0430", Offset = "0x16BF830", Length = "0x79")]
	[Token(Token = "0x60008E2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008DF")]
	public SteamAPICall_t get_Handle() { }

	[Address(RVA = "0xE7DF20", Offset = "0xE7D320", Length = "0x39")]
	[Token(Token = "0x60008E7")]
	internal virtual Type GetCallbackType() { }

	[Address(RVA = "0x16C05B0", Offset = "0x16BF9B0", Length = "0x62")]
	[Token(Token = "0x60008E5")]
	public bool IsActive() { }

	[Address(RVA = "0x16C0770", Offset = "0x16BFB70", Length = "0x196")]
	[Token(Token = "0x60008E8")]
	internal virtual void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_) { }

	[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60008DE")]
	private void remove_m_Func(APIDispatchDelegate<T> value) { }

	[Address(RVA = "0x16C1000", Offset = "0x16C0400", Length = "0x17B")]
	[Token(Token = "0x60008E4")]
	public void Set(SteamAPICall_t hAPICall, APIDispatchDelegate<T> func = null) { }

	[Address(RVA = "0x16C0E80", Offset = "0x16C0280", Length = "0x58")]
	[Token(Token = "0x60008E9")]
	internal virtual void SetUnregistered() { }

}

