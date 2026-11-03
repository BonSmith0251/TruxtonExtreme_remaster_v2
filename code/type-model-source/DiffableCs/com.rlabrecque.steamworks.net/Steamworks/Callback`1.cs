namespace Steamworks;

[Token(Token = "0x2000184")]
public sealed class Callback : Callback, IDisposable
{
	[Token(Token = "0x2000185")]
	internal sealed class DispatchDelegate : MulticastDelegate
	{

		[Address(RVA = "0x10AB210", Offset = "0x10AA610", Length = "0xA6")]
		[Token(Token = "0x60008D5")]
		public DispatchDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x193CD40", Offset = "0x193C140", Length = "0x80")]
		[Token(Token = "0x60008D7")]
		public override IAsyncResult BeginInvoke(T param, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60008D8")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0xE2BDB0", Offset = "0xE2B1B0", Length = "0x2D")]
		[Token(Token = "0x60008D6")]
		public override void Invoke(T param) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A54")]
	private DispatchDelegate<T> m_Func; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A55")]
	private bool m_bGameServer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A56")]
	private bool m_bIsRegistered; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A57")]
	private bool m_bDisposed; //Field offset: 0x0

	[Token(Token = "0x14000001")]
	private event DispatchDelegate<T> m_Func
	{
		[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60008C8")]
		private add { } //Length: 192
		[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x60008C9")]
		private remove { } //Length: 192
	}

	[Token(Token = "0x17000023")]
	public virtual bool IsGameServer
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x60008D1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16C4FE0", Offset = "0x16C43E0", Length = "0x128")]
	[Token(Token = "0x60008CC")]
	public Callback`1(DispatchDelegate<T> func, bool bGameServer = false) { }

	[Address(RVA = "0xA9B690", Offset = "0xA9AA90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60008C8")]
	private void add_m_Func(DispatchDelegate<T> value) { }

	[Address(RVA = "0x16C4700", Offset = "0x16C3B00", Length = "0x91")]
	[Token(Token = "0x60008CA")]
	public static Callback<T> Create(DispatchDelegate<T> func) { }

	[Address(RVA = "0x16C44E0", Offset = "0x16C38E0", Length = "0x91")]
	[Token(Token = "0x60008CB")]
	public static Callback<T> CreateGameServer(DispatchDelegate<T> func) { }

	[Address(RVA = "0x16C47A0", Offset = "0x16C3BA0", Length = "0x99")]
	[Token(Token = "0x60008CE")]
	public override void Dispose() { }

	[Address(RVA = "0x16C48C0", Offset = "0x16C3CC0", Length = "0xF8")]
	[Token(Token = "0x60008CD")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x60008D1")]
	public virtual bool get_IsGameServer() { }

	[Address(RVA = "0xE7DF20", Offset = "0xE7D320", Length = "0x39")]
	[Token(Token = "0x60008D2")]
	internal virtual Type GetCallbackType() { }

	[Address(RVA = "0x16C4A40", Offset = "0x16C3E40", Length = "0x155")]
	[Token(Token = "0x60008D3")]
	internal virtual void OnRunCallback(IntPtr pvParam) { }

	[Address(RVA = "0x16C4E20", Offset = "0x16C4220", Length = "0x101")]
	[Token(Token = "0x60008CF")]
	public void Register(DispatchDelegate<T> func) { }

	[Address(RVA = "0xA9B760", Offset = "0xA9AB60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x60008C9")]
	private void remove_m_Func(DispatchDelegate<T> value) { }

	[Address(RVA = "0x16C4F30", Offset = "0x16C4330", Length = "0x5")]
	[Token(Token = "0x60008D4")]
	internal virtual void SetUnregistered() { }

	[Address(RVA = "0x16C4F40", Offset = "0x16C4340", Length = "0x4E")]
	[Token(Token = "0x60008D0")]
	public void Unregister() { }

}

