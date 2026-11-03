namespace System.Threading;

[Token(Token = "0x200022C")]
internal class OSSpecificSynchronizationContext : SynchronizationContext
{
	[CompilerGenerated]
	[Token(Token = "0x200022F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000A18")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000A19")]
		public static CreateValueCallback<Object, OSSpecificSynchronizationContext> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x20A8A60", Offset = "0x20A7E60", Length = "0x67")]
		[Token(Token = "0x60012B1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60012B2")]
		public <>c() { }

		[Address(RVA = "0x20A8830", Offset = "0x20A7C30", Length = "0x60")]
		[Token(Token = "0x60012B3")]
		internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

	}

	[Token(Token = "0x200022E")]
	private class InvocationContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A16")]
		private SendOrPostCallback m_Delegate; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A17")]
		private object m_State; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x60012AF")]
		public InvocationContext(SendOrPostCallback d, object state) { }

		[Address(RVA = "0x209F490", Offset = "0x209E890", Length = "0x2C")]
		[Token(Token = "0x60012B0")]
		public void Invoke() { }

	}

	[Token(Token = "0x200022D")]
	private sealed class InvocationEntryDelegate : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x60012AD")]
		public InvocationEntryDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60012AE")]
		public override void Invoke(IntPtr arg) { }

	}

	[Token(Token = "0x4000A15")]
	private static readonly ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A14")]
	private object m_OSSynchronizationContext; //Field offset: 0x18

	[Address(RVA = "0x20A27B0", Offset = "0x20A1BB0", Length = "0x84")]
	[Token(Token = "0x60012AC")]
	private static OSSpecificSynchronizationContext() { }

	[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
	[Token(Token = "0x60012A4")]
	private OSSpecificSynchronizationContext(object osContext) { }

	[Address(RVA = "0x20A2240", Offset = "0x20A1640", Length = "0x64")]
	[Token(Token = "0x60012A6")]
	public virtual SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x20A22C0", Offset = "0x20A16C0", Length = "0x183")]
	[Token(Token = "0x60012A5")]
	public static OSSpecificSynchronizationContext Get() { }

	[Address(RVA = "0x20A22B0", Offset = "0x20A16B0", Length = "0x5")]
	[Token(Token = "0x60012AA")]
	private static object GetOSContext() { }

	[Address(RVA = "0x20A2450", Offset = "0x20A1850", Length = "0x145")]
	[MonoPInvokeCallback(typeof(InvocationEntryDelegate))]
	[Token(Token = "0x60012A9")]
	private static void InvocationEntry(IntPtr arg) { }

	[Address(RVA = "0x20A25B0", Offset = "0x20A19B0", Length = "0x1BE")]
	[Token(Token = "0x60012A8")]
	public virtual void Post(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x20A25A0", Offset = "0x20A19A0", Length = "0x5")]
	[Token(Token = "0x60012AB")]
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	[Address(RVA = "0x20A2770", Offset = "0x20A1B70", Length = "0x3E")]
	[Token(Token = "0x60012A7")]
	public virtual void Send(SendOrPostCallback d, object state) { }

}

