namespace Unity.Microsoft.GDK.Tools;

[CreateAssetMenu(fileName = "GDKSettings", menuName = "GDK/GDK Settings", order = 1)]
[Token(Token = "0x2000030")]
public class GdkSettingsAsset : ScriptableObject
{
	[Token(Token = "0x2000032")]
	internal class PlatformGdkSettings
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011E")]
		public RuntimePlatform runtimePlatform; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400011F")]
		public bool targetMicrosoftGdk; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000120")]
		public GameConfigAsset gameConfigAsset; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000121")]
		public ShellVisualsMode shellVisualsMode; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Obsolete("Please do not use, will be removed in future. The MICROSOFT_GDK_SUPPORT define is now present when targetMicrosoftGdk is true", False)]
		[Token(Token = "0x4000122")]
		public bool createScriptingDefine; //Field offset: 0x24
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x4000123")]
		public bool createPackage; //Field offset: 0x25
		[FieldOffset(Offset = "0x26")]
		[Token(Token = "0x4000124")]
		public bool sideloadPackage; //Field offset: 0x26

		[Address(RVA = "0x2B6DDE0", Offset = "0x2B6D1E0", Length = "0xF")]
		[Token(Token = "0x60001C5")]
		public PlatformGdkSettings() { }

	}

	[Token(Token = "0x2000031")]
	internal enum ShellVisualsMode : int
	{
		Disabled = 0,
		RunMakePriAndCopy = 1,
		CopyOnly = 2,
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000116")]
	public bool createGdkPlatformSettingsCs; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000117")]
	public bool createGdkPlatformSettingsDefine; //Field offset: 0x19
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000118")]
	public string gdkPlatformSettingsCsNamespace; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000119")]
	public List<PlatformGdkSettings> settingsList; //Field offset: 0x28

	[Address(RVA = "0x2B6CCE0", Offset = "0x2B6C0E0", Length = "0x55")]
	[Token(Token = "0x60001C1")]
	public GdkSettingsAsset() { }

	[Address(RVA = "0x2B6CB00", Offset = "0x2B6BF00", Length = "0x44")]
	[Token(Token = "0x60001C4")]
	public IEnumerable<PlatformGdkSettings> GetPlatformSettingsList() { }

	[Address(RVA = "0x2B6CB50", Offset = "0x2B6BF50", Length = "0x1F")]
	[Token(Token = "0x60001C2")]
	public bool SettingsExistForRuntimePlatform(RuntimePlatform platform) { }

	[Address(RVA = "0x2B6CB70", Offset = "0x2B6BF70", Length = "0x16A")]
	[Token(Token = "0x60001C3")]
	public bool SettingsForRuntimePlatform(RuntimePlatform platform, out PlatformGdkSettings platformSettings) { }

}

