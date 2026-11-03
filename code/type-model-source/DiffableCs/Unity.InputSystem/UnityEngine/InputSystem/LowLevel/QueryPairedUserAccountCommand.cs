namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x2000187")]
public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000189")]
	[UnsafeValueType]
	internal struct <idBuffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097D")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x200018A")]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400097E")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Flags]
	[Token(Token = "0x2000188")]
	internal enum Result : long
	{
		DevicePairedToUserAccount = 2,
		UserAccountSelectionInProgress = 4,
		UserAccountSelectionComplete = 8,
		UserAccountSelectionCanceled = 16,
	}

	[Token(Token = "0x4000971")]
	internal const int kMaxNameLength = 256; //Field offset: 0x0
	[Token(Token = "0x4000972")]
	internal const int kMaxIdLength = 256; //Field offset: 0x0
	[Token(Token = "0x4000973")]
	internal const int kSize = 1040; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000974")]
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000975")]
	public ulong handle; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(byte), 512)]
	[Token(Token = "0x4000976")]
	internal <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x210")]
	[FixedBuffer(typeof(byte), 512)]
	[Token(Token = "0x4000977")]
	internal <idBuffer>e__FixedBuffer idBuffer; //Field offset: 0x210

	[Token(Token = "0x17000453")]
	public string id
	{
		[Address(RVA = "0x29FC230", Offset = "0x29FB630", Length = "0x14")]
		[Token(Token = "0x6000FDC")]
		 get { } //Length: 20
		[Address(RVA = "0x29FC2B0", Offset = "0x29FB6B0", Length = "0x10D")]
		[Token(Token = "0x6000FDD")]
		 set { } //Length: 269
	}

	[Token(Token = "0x17000454")]
	public string name
	{
		[Address(RVA = "0x29FC250", Offset = "0x29FB650", Length = "0x11")]
		[Token(Token = "0x6000FDE")]
		 get { } //Length: 17
		[Address(RVA = "0x29FC3C0", Offset = "0x29FB7C0", Length = "0x10A")]
		[Token(Token = "0x6000FDF")]
		 set { } //Length: 266
	}

	[Token(Token = "0x17000452")]
	public static FourCC Type
	{
		[Address(RVA = "0x29FC1F0", Offset = "0x29FB5F0", Length = "0x3A")]
		[Token(Token = "0x6000FDB")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000455")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29FC270", Offset = "0x29FB670", Length = "0x3A")]
		[Token(Token = "0x6000FE0")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FC180", Offset = "0x29FB580", Length = "0x64")]
	[Token(Token = "0x6000FE1")]
	public static QueryPairedUserAccountCommand Create() { }

	[Address(RVA = "0x29FC230", Offset = "0x29FB630", Length = "0x14")]
	[Token(Token = "0x6000FDC")]
	public string get_id() { }

	[Address(RVA = "0x29FC250", Offset = "0x29FB650", Length = "0x11")]
	[Token(Token = "0x6000FDE")]
	public string get_name() { }

	[Address(RVA = "0x29FC1F0", Offset = "0x29FB5F0", Length = "0x3A")]
	[Token(Token = "0x6000FDB")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29FC270", Offset = "0x29FB670", Length = "0x3A")]
	[Token(Token = "0x6000FE0")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x29FC2B0", Offset = "0x29FB6B0", Length = "0x10D")]
	[Token(Token = "0x6000FDD")]
	public void set_id(string value) { }

	[Address(RVA = "0x29FC3C0", Offset = "0x29FB7C0", Length = "0x10A")]
	[Token(Token = "0x6000FDF")]
	public void set_name(string value) { }

}

