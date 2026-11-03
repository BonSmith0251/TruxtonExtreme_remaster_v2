namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001B1")]
public class XblPresenceDeviceRecord
{
	[CompilerGenerated]
	[Token(Token = "0x20001B2")]
	private sealed class <>c
	{
		[Token(Token = "0x400043B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400043C")]
		public static Func<XblPresenceTitleRecord, XblPresenceTitleRecord> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B805F0", Offset = "0x2B7F9F0", Length = "0x67")]
		[Token(Token = "0x600093A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600093B")]
		public <>c() { }

		[Address(RVA = "0x2B7F790", Offset = "0x2B7EB90", Length = "0x7B")]
		[Token(Token = "0x600093C")]
		internal XblPresenceTitleRecord <.ctor>b__0_0(XblPresenceTitleRecord tr) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000439")]
	private XblPresenceDeviceType <DeviceType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400043A")]
	private XblPresenceTitleRecord[] <TitleRecords>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000184")]
	public private XblPresenceDeviceType DeviceType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000936")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000937")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000185")]
	public private XblPresenceTitleRecord[] TitleRecords
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000938")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000939")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B8A9E0", Offset = "0x2B89DE0", Length = "0x13E")]
	[Token(Token = "0x6000935")]
	internal XblPresenceDeviceRecord(XblPresenceDeviceRecord interopRecord) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000936")]
	public XblPresenceDeviceType get_DeviceType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000938")]
	public XblPresenceTitleRecord[] get_TitleRecords() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000937")]
	private void set_DeviceType(XblPresenceDeviceType value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000939")]
	private void set_TitleRecords(XblPresenceTitleRecord[] value) { }

}

