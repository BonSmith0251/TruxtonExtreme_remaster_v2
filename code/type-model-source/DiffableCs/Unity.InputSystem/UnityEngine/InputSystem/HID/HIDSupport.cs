namespace UnityEngine.InputSystem.HID;

[Token(Token = "0x2000150")]
public static class HIDSupport
{
	[Token(Token = "0x2000151")]
	internal struct HIDPageUsage
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000882")]
		public UsagePage page; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000883")]
		public int usage; //Field offset: 0x4

		[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
		[Token(Token = "0x6000EC8")]
		public HIDPageUsage(UsagePage page, int usage) { }

		[Address(RVA = "0x29F4C30", Offset = "0x29F4030", Length = "0xA")]
		[Token(Token = "0x6000EC9")]
		public HIDPageUsage(GenericDesktop usage) { }

	}

	[Token(Token = "0x4000881")]
	private static HIDPageUsage[] s_SupportedHIDUsages; //Field offset: 0x0

	[Token(Token = "0x170003EB")]
	public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages
	{
		[Address(RVA = "0x29F5ED0", Offset = "0x29F52D0", Length = "0x64")]
		[Token(Token = "0x6000EC5")]
		 get { } //Length: 100
		[Address(RVA = "0x29F5F40", Offset = "0x29F5340", Length = "0x28B")]
		[Token(Token = "0x6000EC6")]
		 set { } //Length: 651
	}

	[Address(RVA = "0x29F5ED0", Offset = "0x29F52D0", Length = "0x64")]
	[Token(Token = "0x6000EC5")]
	public static ReadOnlyArray<HIDPageUsage> get_supportedHIDUsages() { }

	[Address(RVA = "0x29F5D40", Offset = "0x29F5140", Length = "0x187")]
	[Token(Token = "0x6000EC7")]
	internal static void Initialize() { }

	[Address(RVA = "0x29F5F40", Offset = "0x29F5340", Length = "0x28B")]
	[Token(Token = "0x6000EC6")]
	public static void set_supportedHIDUsages(ReadOnlyArray<HIDPageUsage> value) { }

}

