namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002B3")]
public class InteropCallbackManager
{
	[Token(Token = "0x20002B4")]
	internal struct HandlerContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400073F")]
		public IntPtr Context; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000740")]
		public TDelegate Callback; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073C")]
	protected readonly Dictionary<IntPtr, Int32> _contextToFunctionId; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073D")]
	protected readonly Dictionary<Int32, HandlerContext<TDelegate>> _functionIdToHandler; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400073E")]
	private int _availableContextId; //Field offset: 0x0

	[Address(RVA = "0xA96C90", Offset = "0xA96090", Length = "0xDD")]
	[Token(Token = "0x6000E15")]
	public InteropCallbackManager`1() { }

	[Address(RVA = "0xA96AC0", Offset = "0xA95EC0", Length = "0xC6")]
	[Token(Token = "0x6000E13")]
	internal void AddCallbackForId(int functionId, IntPtr context, TDelegate callback) { }

	[Address(RVA = "0xA96B90", Offset = "0xA95F90", Length = "0x2D")]
	[Token(Token = "0x6000E12")]
	internal IntPtr GetUniqueContext() { }

	[Address(RVA = "0xA96BC0", Offset = "0xA95FC0", Length = "0xCD")]
	[Token(Token = "0x6000E14")]
	internal void RemoveCallbackForId(int functionId) { }

}

