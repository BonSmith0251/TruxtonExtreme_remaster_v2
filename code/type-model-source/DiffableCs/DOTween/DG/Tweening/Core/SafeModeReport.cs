namespace DG.Tweening.Core;

[Token(Token = "0x20000B0")]
internal struct SafeModeReport
{
	[Token(Token = "0x20000B1")]
	public enum SafeModeReportType : int
	{
		Unset = 0,
		TargetOrFieldMissing = 1,
		Callback = 2,
		StartupFailure = 3,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020D")]
	private int <totMissingTargetOrFieldErrors>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400020E")]
	private int <totCallbackErrors>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400020F")]
	private int <totStartupErrors>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000210")]
	private int <totUnsetErrors>k__BackingField; //Field offset: 0xC

	[Token(Token = "0x1700001D")]
	public private int totCallbackErrors
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600040F")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000410")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public private int totMissingTargetOrFieldErrors
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x600040D")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x600040E")]
		private set { } //Length: 3
	}

	[Token(Token = "0x1700001E")]
	public private int totStartupErrors
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000411")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000412")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700001F")]
	public private int totUnsetErrors
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000413")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000414")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x672E50", Offset = "0x672250", Length = "0x1E")]
	[Token(Token = "0x6000415")]
	public void Add(SafeModeReportType type) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600040F")]
	public int get_totCallbackErrors() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x600040D")]
	public int get_totMissingTargetOrFieldErrors() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000411")]
	public int get_totStartupErrors() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000413")]
	public int get_totUnsetErrors() { }

	[Address(RVA = "0x672E70", Offset = "0x672270", Length = "0xC")]
	[Token(Token = "0x6000416")]
	public int GetTotErrors() { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000410")]
	private void set_totCallbackErrors(int value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x600040E")]
	private void set_totMissingTargetOrFieldErrors(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000412")]
	private void set_totStartupErrors(int value) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000414")]
	private void set_totUnsetErrors(int value) { }

}

