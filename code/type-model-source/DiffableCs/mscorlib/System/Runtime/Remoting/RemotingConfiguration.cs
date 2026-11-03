namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000350")]
public static class RemotingConfiguration
{
	[Token(Token = "0x4000DE4")]
	private static string applicationID; //Field offset: 0x0
	[Token(Token = "0x4000DE5")]
	private static string applicationName; //Field offset: 0x8
	[Token(Token = "0x4000DE6")]
	private static string processGuid; //Field offset: 0x10
	[Token(Token = "0x4000DE7")]
	private static bool defaultConfigRead; //Field offset: 0x18
	[Token(Token = "0x4000DE8")]
	private static bool defaultDelayedConfigRead; //Field offset: 0x19
	[Token(Token = "0x4000DE9")]
	private static CustomErrorsModes _errorMode; //Field offset: 0x1C
	[Token(Token = "0x4000DEA")]
	private static Hashtable wellKnownClientEntries; //Field offset: 0x20
	[Token(Token = "0x4000DEB")]
	private static Hashtable activatedClientEntries; //Field offset: 0x28
	[Token(Token = "0x4000DEC")]
	private static Hashtable wellKnownServiceEntries; //Field offset: 0x30
	[Token(Token = "0x4000DED")]
	private static Hashtable activatedServiceEntries; //Field offset: 0x38
	[Token(Token = "0x4000DEE")]
	private static Hashtable channelTemplates; //Field offset: 0x40
	[Token(Token = "0x4000DEF")]
	private static Hashtable clientProviderTemplates; //Field offset: 0x48
	[Token(Token = "0x4000DF0")]
	private static Hashtable serverProviderTemplates; //Field offset: 0x50

	[Token(Token = "0x170002D0")]
	public static string ApplicationName
	{
		[Address(RVA = "0x1EE91B0", Offset = "0x1EE85B0", Length = "0x4F")]
		[Token(Token = "0x6001AA5")]
		 get { } //Length: 79
		[Address(RVA = "0x1EE92E0", Offset = "0x1EE86E0", Length = "0x6E")]
		[Token(Token = "0x6001AA6")]
		 set { } //Length: 110
	}

	[Token(Token = "0x170002D1")]
	public static string ProcessId
	{
		[Address(RVA = "0x1EE9200", Offset = "0x1EE8600", Length = "0xDB")]
		[Token(Token = "0x6001AA7")]
		 get { } //Length: 219
	}

	[Address(RVA = "0x1EE8EE0", Offset = "0x1EE82E0", Length = "0x2CB")]
	[Token(Token = "0x6001AB7")]
	private static RemotingConfiguration() { }

	[Address(RVA = "0x1EE6E50", Offset = "0x1EE6250", Length = "0x8B")]
	[Token(Token = "0x6001AB5")]
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	[Address(RVA = "0x1EE91B0", Offset = "0x1EE85B0", Length = "0x4F")]
	[Token(Token = "0x6001AA5")]
	public static string get_ApplicationName() { }

	[Address(RVA = "0x1EE9200", Offset = "0x1EE8600", Length = "0xDB")]
	[Token(Token = "0x6001AA7")]
	public static string get_ProcessId() { }

	[Address(RVA = "0x1EE6EE0", Offset = "0x1EE62E0", Length = "0x132")]
	[Token(Token = "0x6001AA9")]
	public static bool IsActivationAllowed(Type svrType) { }

	[Address(RVA = "0x1EE7020", Offset = "0x1EE6420", Length = "0x180")]
	[Token(Token = "0x6001AAA")]
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	[Address(RVA = "0x1EE71B0", Offset = "0x1EE65B0", Length = "0x180")]
	[Token(Token = "0x6001AAB")]
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	[Address(RVA = "0x1EE7340", Offset = "0x1EE6740", Length = "0x350")]
	[Token(Token = "0x6001AA8")]
	internal static void LoadDefaultDelayedChannels() { }

	[Address(RVA = "0x1EE76A0", Offset = "0x1EE6AA0", Length = "0x28C")]
	[Token(Token = "0x6001AAC")]
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	[Address(RVA = "0x1EE7930", Offset = "0x1EE6D30", Length = "0x12E")]
	[Token(Token = "0x6001AAD")]
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	[Address(RVA = "0x1EE7AE0", Offset = "0x1EE6EE0", Length = "0x85D")]
	[Token(Token = "0x6001AB3")]
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	[Address(RVA = "0x1EE7A60", Offset = "0x1EE6E60", Length = "0x7E")]
	[Token(Token = "0x6001AB0")]
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	[Address(RVA = "0x1EE8340", Offset = "0x1EE7740", Length = "0x7E")]
	[Token(Token = "0x6001AB1")]
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	[Address(RVA = "0x1EE83C0", Offset = "0x1EE77C0", Length = "0x7E")]
	[Token(Token = "0x6001AB2")]
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	[Address(RVA = "0x1EE8440", Offset = "0x1EE7840", Length = "0x45E")]
	[Token(Token = "0x6001AB4")]
	internal static void RegisterTypes(ArrayList types) { }

	[Address(RVA = "0x1EE88A0", Offset = "0x1EE7CA0", Length = "0x28C")]
	[Token(Token = "0x6001AAE")]
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	[Address(RVA = "0x1EE8B30", Offset = "0x1EE7F30", Length = "0x17F")]
	[Token(Token = "0x6001AAF")]
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	[Address(RVA = "0x1EE92E0", Offset = "0x1EE86E0", Length = "0x6E")]
	[Token(Token = "0x6001AA6")]
	public static void set_ApplicationName(string value) { }

	[Address(RVA = "0x1EE8CB0", Offset = "0x1EE80B0", Length = "0x221")]
	[Token(Token = "0x6001AB6")]
	internal static void SetCustomErrorsMode(string mode) { }

}

