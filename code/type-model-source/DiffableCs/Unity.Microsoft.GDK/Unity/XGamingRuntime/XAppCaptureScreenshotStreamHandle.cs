namespace Unity.XGamingRuntime;

[Token(Token = "0x2000104")]
public class XAppCaptureScreenshotStreamHandle : EquatableHandle
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D3")]
	private int <CloseResult>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000067")]
	public private int CloseResult
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600064A")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600064B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000068")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x600064D")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000648")]
	public XAppCaptureScreenshotStreamHandle(IntPtr handle) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600064A")]
	public int get_CloseResult() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x600064D")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B7C1F0", Offset = "0x2B7B5F0", Length = "0x2D")]
	[Token(Token = "0x6000649")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600064B")]
	private void set_CloseResult(int value) { }

	[Address(RVA = "0x2B7C220", Offset = "0x2B7B620", Length = "0x94")]
	[Token(Token = "0x600064C")]
	internal static int WrapAndReturnHResult(int hresult, IntPtr interopHandle, out XAppCaptureScreenshotStreamHandle handle) { }

}

