namespace System.Runtime.Remoting.Proxies;

[Token(Token = "0x2000367")]
internal class TransparentProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E2D")]
	public RealProxy _rp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E2E")]
	private RuntimeRemoteClassHandle _class; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E2F")]
	private bool _custom_type_info; //Field offset: 0x20

	[Token(Token = "0x170002E4")]
	private bool IsContextBoundObject
	{
		[Address(RVA = "0x1EF1EF0", Offset = "0x1EF12F0", Length = "0xBB")]
		[Token(Token = "0x6001B52")]
		private get { } //Length: 187
	}

	[Token(Token = "0x170002E5")]
	private Context TargetContext
	{
		[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
		[Token(Token = "0x6001B53")]
		private get { } //Length: 27
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001B57")]
	public TransparentProxy() { }

	[Address(RVA = "0x1EF1EF0", Offset = "0x1EF12F0", Length = "0xBB")]
	[Token(Token = "0x6001B52")]
	private bool get_IsContextBoundObject() { }

	[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
	[Token(Token = "0x6001B53")]
	private Context get_TargetContext() { }

	[Address(RVA = "0x1EF16B0", Offset = "0x1EF0AB0", Length = "0xB9")]
	[Token(Token = "0x6001B51")]
	internal RuntimeType GetProxyType() { }

	[Address(RVA = "0x1EF1770", Offset = "0x1EF0B70", Length = "0xED")]
	[Token(Token = "0x6001B54")]
	private bool InCurrentContext() { }

	[Address(RVA = "0x1EF1860", Offset = "0x1EF0C60", Length = "0x337")]
	[Token(Token = "0x6001B55")]
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	[Address(RVA = "0x1EF1BA0", Offset = "0x1EF0FA0", Length = "0x347")]
	[Token(Token = "0x6001B56")]
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

}

