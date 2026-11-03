namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001B5")]
public class XblPresenceQueryFilters
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000453")]
	private XblPresenceDeviceType[] <DeviceTypes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000454")]
	private UInt32[] <TitleIds>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000455")]
	private XblPresenceDetailLevel <DetailLevel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000456")]
	private bool <OnlineOnly>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000457")]
	private bool <BroadcastingOnly>k__BackingField; //Field offset: 0x25

	[Token(Token = "0x1700018A")]
	public private bool BroadcastingOnly
	{
		[Address(RVA = "0x213CD00", Offset = "0x213C100", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000947")]
		 get { } //Length: 5
		[Address(RVA = "0x213CD80", Offset = "0x213C180", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000948")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000188")]
	public private XblPresenceDetailLevel DetailLevel
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000943")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000944")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000186")]
	public private XblPresenceDeviceType[] DeviceTypes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600093F")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000940")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000189")]
	public private bool OnlineOnly
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000945")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000946")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000187")]
	public private UInt32[] TitleIds
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000941")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000942")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B8ABE0", Offset = "0x2B89FE0", Length = "0x6F")]
	[Token(Token = "0x600093D")]
	private XblPresenceQueryFilters(XblPresenceDeviceType[] deviceTypes, UInt32[] titleIds, XblPresenceDetailLevel detailLevel, bool onlineOnly, bool broadcastingOnly) { }

	[Address(RVA = "0x2B8AB20", Offset = "0x2B89F20", Length = "0xB9")]
	[Token(Token = "0x600093E")]
	public static int Create(XblPresenceDeviceType[] deviceTypes, UInt32[] titleIds, XblPresenceDetailLevel detailLevel, bool onlineOnly, bool broadcastingOnly, out XblPresenceQueryFilters queryFilters) { }

	[Address(RVA = "0x213CD00", Offset = "0x213C100", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000947")]
	public bool get_BroadcastingOnly() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000943")]
	public XblPresenceDetailLevel get_DetailLevel() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600093F")]
	public XblPresenceDeviceType[] get_DeviceTypes() { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000945")]
	public bool get_OnlineOnly() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000941")]
	public UInt32[] get_TitleIds() { }

	[Address(RVA = "0x213CD80", Offset = "0x213C180", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000948")]
	private void set_BroadcastingOnly(bool value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000944")]
	private void set_DetailLevel(XblPresenceDetailLevel value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000940")]
	private void set_DeviceTypes(XblPresenceDeviceType[] value) { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000946")]
	private void set_OnlineOnly(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000942")]
	private void set_TitleIds(UInt32[] value) { }

}

