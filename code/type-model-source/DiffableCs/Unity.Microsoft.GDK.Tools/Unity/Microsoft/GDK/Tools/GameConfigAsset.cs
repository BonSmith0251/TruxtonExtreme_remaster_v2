namespace Unity.Microsoft.GDK.Tools;

[Token(Token = "0x200002D")]
public class GameConfigAsset : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private sealed class <>c
	{
		[Token(Token = "0x40000DD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000DE")]
		public static Func<CT_ExtendedAttributeListExtendedAttribute, Boolean> <>9__41_0; //Field offset: 0x8
		[Token(Token = "0x40000DF")]
		public static Func<CT_ExtendedAttributeListExtendedAttribute, Boolean> <>9__41_1; //Field offset: 0x10

		[Address(RVA = "0x2B6DE90", Offset = "0x2B6D290", Length = "0x67")]
		[Token(Token = "0x60001BD")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001BE")]
		public <>c() { }

		[Address(RVA = "0x2B6DDF0", Offset = "0x2B6D1F0", Length = "0x47")]
		[Token(Token = "0x60001BF")]
		internal bool <LoadXmlGameConfig>b__41_0(CT_ExtendedAttributeListExtendedAttribute extendedAttribute) { }

		[Address(RVA = "0x2B6DE40", Offset = "0x2B6D240", Length = "0x47")]
		[Token(Token = "0x60001C0")]
		internal bool <LoadXmlGameConfig>b__41_1(CT_ExtendedAttributeListExtendedAttribute extendedAttribute) { }

	}

	[Token(Token = "0x40000D1")]
	public const string k_FileExtension = "mgc"; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	internal string m_IdentityName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	internal string m_IdentityPublisher; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	internal string m_IdentityVersion; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	internal string m_TitleId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	internal string m_SCID; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D7")]
	internal string m_MSAAppId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D8")]
	internal string m_StoreId; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	internal string m_ContentIdOverride; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	internal string m_EKBIDOverride; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	internal String[] m_Sandboxes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	public LanguagePairs m_LanguagePairs; //Field offset: 0x68

	[Token(Token = "0x17000094")]
	public string ContentIdOverride
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
		[Token(Token = "0x60001AF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000095")]
	public string EKBIDOverride
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60001B0")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
		[Token(Token = "0x60001B1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008D")]
	public string IdentityName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001A3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008E")]
	public string IdentityPublisher
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008F")]
	public string IdentityVersion
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000097")]
	public LanguagePairs LanguagePairs
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60001B3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000092")]
	public string MSAAppId
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
		[Token(Token = "0x60001AB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000096")]
	public String[] Sandboxes
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60001B2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000091")]
	public string SCID
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
		[Token(Token = "0x60001A9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000093")]
	public string StoreId
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60001AC")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
		[Token(Token = "0x60001AD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000090")]
	public string TitleId
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
		[Token(Token = "0x60001A7")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B6BC40", Offset = "0x2B6B040", Length = "0x291")]
	[Token(Token = "0x60001BC")]
	public GameConfigAsset() { }

	[Address(RVA = "0x2B6A120", Offset = "0x2B69520", Length = "0x2B0")]
	[Token(Token = "0x60001B8")]
	public static string GameConfigToString(Game xmlGameConfig) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60001AE")]
	public string get_ContentIdOverride() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60001B0")]
	public string get_EKBIDOverride() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60001A3")]
	public string get_IdentityName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60001A4")]
	public string get_IdentityPublisher() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60001A5")]
	public string get_IdentityVersion() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60001B3")]
	public LanguagePairs get_LanguagePairs() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60001AA")]
	public string get_MSAAppId() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60001B2")]
	public String[] get_Sandboxes() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60001A8")]
	public string get_SCID() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60001AC")]
	public string get_StoreId() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60001A6")]
	public string get_TitleId() { }

	[Address(RVA = "0x2B6A3E0", Offset = "0x2B697E0", Length = "0x200")]
	[Token(Token = "0x60001BB")]
	public bool HasLanguagePairSet() { }

	[Address(RVA = "0x2B6A5F0", Offset = "0x2B699F0", Length = "0x1E")]
	[Token(Token = "0x60001BA")]
	public bool IsLanguagePairSet(GameConfigLanguages language) { }

	[Address(RVA = "0x2B6A610", Offset = "0x2B69A10", Length = "0x19B")]
	[Token(Token = "0x60001B4")]
	public static Game LoadAsXmlGameConfig(string xmlGameConfigPath) { }

	[Address(RVA = "0x2B6A7B0", Offset = "0x2B69BB0", Length = "0x55E")]
	[Token(Token = "0x60001B5")]
	public void LoadXmlGameConfig(string xmlGameConfigPath) { }

	[Address(RVA = "0x2B6B980", Offset = "0x2B6AD80", Length = "0x260")]
	[Token(Token = "0x60001B6")]
	public static void SaveXmlGameConfig(string xmlGameConfigPath, Game xmlGameConfig) { }

	[Address(RVA = "0x2B6AD10", Offset = "0x2B6A110", Length = "0xC6D")]
	[Token(Token = "0x60001B7")]
	public void SaveXmlGameConfig(string xmlGameConfigPath) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
	[Token(Token = "0x60001AF")]
	public void set_ContentIdOverride(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
	[Token(Token = "0x60001B1")]
	public void set_EKBIDOverride(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
	[Token(Token = "0x60001AB")]
	public void set_MSAAppId(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
	[Token(Token = "0x60001A9")]
	public void set_SCID(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
	[Token(Token = "0x60001AD")]
	public void set_StoreId(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", False)]
	[Token(Token = "0x60001A7")]
	public void set_TitleId(string value) { }

	[Address(RVA = "0x2B6BBF0", Offset = "0x2B6AFF0", Length = "0x43")]
	[Token(Token = "0x60001B9")]
	public void SetLanguagePair(GameConfigLanguages language, bool isActive) { }

}

