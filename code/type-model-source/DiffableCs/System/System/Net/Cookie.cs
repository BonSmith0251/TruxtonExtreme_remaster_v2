namespace System.Net;

[Token(Token = "0x2000273")]
public sealed class Cookie
{
	[Token(Token = "0x40009E7")]
	internal static readonly Char[] PortSplitDelimiters; //Field offset: 0x0
	[Token(Token = "0x40009E8")]
	internal static readonly Char[] Reserved2Name; //Field offset: 0x8
	[Token(Token = "0x40009E9")]
	internal static readonly Char[] Reserved2Value; //Field offset: 0x10
	[Token(Token = "0x40009EA")]
	private static Comparer staticComparer; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009EB")]
	private string m_comment; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009EC")]
	private Uri m_commentUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009ED")]
	private CookieVariant m_cookieVariant; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009EE")]
	private bool m_discard; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009EF")]
	private string m_domain; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009F0")]
	private bool m_domain_implicit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009F1")]
	private DateTime m_expires; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009F2")]
	private string m_name; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009F3")]
	private string m_path; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009F4")]
	private bool m_path_implicit; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009F5")]
	private string m_port; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40009F6")]
	private bool m_port_implicit; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40009F7")]
	private Int32[] m_port_list; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40009F8")]
	private bool m_secure; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[OptionalField]
	[Token(Token = "0x40009F9")]
	private bool m_httpOnly; //Field offset: 0x71
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40009FA")]
	private DateTime m_timeStamp; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40009FB")]
	private string m_value; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40009FC")]
	private int m_version; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40009FD")]
	private string m_domainKey; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40009FE")]
	internal bool IsQuotedVersion; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40009FF")]
	internal bool IsQuotedDomain; //Field offset: 0x99

	[Token(Token = "0x17000367")]
	private string _Domain
	{
		[Address(RVA = "0x26BCCB0", Offset = "0x26BC0B0", Length = "0xB0")]
		[Token(Token = "0x600105F")]
		private get { } //Length: 176
	}

	[Token(Token = "0x1700036D")]
	private string _Path
	{
		[Address(RVA = "0x26BCD70", Offset = "0x26BC170", Length = "0x73")]
		[Token(Token = "0x6001069")]
		private get { } //Length: 115
	}

	[Token(Token = "0x17000371")]
	private string _Port
	{
		[Address(RVA = "0x26BCDF0", Offset = "0x26BC1F0", Length = "0xAB")]
		[Token(Token = "0x6001071")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000377")]
	private string _Version
	{
		[Address(RVA = "0x26BCEA0", Offset = "0x26BC2A0", Length = "0xEB")]
		[Token(Token = "0x600107A")]
		private get { } //Length: 235
	}

	[Token(Token = "0x17000362")]
	public string Comment
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001058")]
		 get { } //Length: 5
		[Address(RVA = "0x2318F70", Offset = "0x2318370", Length = "0x23")]
		[Token(Token = "0x6001059")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000363")]
	public Uri CommentUri
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600105A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000365")]
	public bool Discard
	{
		[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
		[Token(Token = "0x600105C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000366")]
	public string Domain
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600105D")]
		 get { } //Length: 5
		[Address(RVA = "0x26BCF90", Offset = "0x26BC390", Length = "0x63")]
		[Token(Token = "0x600105E")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000368")]
	internal bool DomainImplicit
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6001060")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[Token(Token = "0x6001061")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000375")]
	internal string DomainKey
	{
		[Address(RVA = "0x26BCBD0", Offset = "0x26BBFD0", Length = "0x13")]
		[Token(Token = "0x6001077")]
		internal get { } //Length: 19
	}

	[Token(Token = "0x17000369")]
	public bool Expired
	{
		[Address(RVA = "0x26BCBF0", Offset = "0x26BBFF0", Length = "0xB3")]
		[Token(Token = "0x6001062")]
		 get { } //Length: 179
	}

	[Token(Token = "0x1700036A")]
	public DateTime Expires
	{
		[Address(RVA = "0x1BBC1C0", Offset = "0x1BBB5C0", Length = "0x5")]
		[Token(Token = "0x6001063")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000364")]
	public bool HttpOnly
	{
		[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
		[Token(Token = "0x600105B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700036B")]
	public string Name
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001064")]
		 get { } //Length: 5
		[Address(RVA = "0x26BD000", Offset = "0x26BC400", Length = "0x15D")]
		[Token(Token = "0x6001065")]
		 set { } //Length: 349
	}

	[Token(Token = "0x1700036C")]
	public string Path
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001067")]
		 get { } //Length: 5
		[Address(RVA = "0x26BD160", Offset = "0x26BC560", Length = "0x40")]
		[Token(Token = "0x6001068")]
		 set { } //Length: 64
	}

	[Token(Token = "0x1700036E")]
	internal bool Plain
	{
		[Address(RVA = "0x253C5D0", Offset = "0x253B9D0", Length = "0x8")]
		[Token(Token = "0x600106A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700036F")]
	public string Port
	{
		[Address(RVA = "0x26BD1B0", Offset = "0x26BC5B0", Length = "0x4AE")]
		[Token(Token = "0x600106F")]
		 set { } //Length: 1198
	}

	[Token(Token = "0x17000370")]
	internal Int32[] PortList
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001070")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000372")]
	public bool Secure
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x6001072")]
		 get { } //Length: 5
		[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
		[Token(Token = "0x6001073")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000373")]
	public string Value
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6001074")]
		 get { } //Length: 8
		[Address(RVA = "0x26BD660", Offset = "0x26BCA60", Length = "0x38")]
		[Token(Token = "0x6001075")]
		 set { } //Length: 56
	}

	[Token(Token = "0x17000374")]
	internal CookieVariant Variant
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6001076")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000376")]
	public int Version
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[Token(Token = "0x6001078")]
		 get { } //Length: 7
		[Address(RVA = "0x26BD6A0", Offset = "0x26BCAA0", Length = "0x74")]
		[Token(Token = "0x6001079")]
		 set { } //Length: 116
	}

	[Address(RVA = "0x26BC5F0", Offset = "0x26BB9F0", Length = "0x1A8")]
	[Token(Token = "0x600107F")]
	private static Cookie() { }

	[Address(RVA = "0x26BC7A0", Offset = "0x26BBBA0", Length = "0x15E")]
	[Token(Token = "0x6001056")]
	public Cookie() { }

	[Address(RVA = "0x26BC900", Offset = "0x26BBD00", Length = "0x2C5")]
	[Token(Token = "0x6001057")]
	public Cookie(string name, string value) { }

	[Address(RVA = "0x26BAA60", Offset = "0x26B9E60", Length = "0x1A5")]
	[Token(Token = "0x600106B")]
	internal Cookie Clone() { }

	[Address(RVA = "0x26BAC10", Offset = "0x26BA010", Length = "0x83")]
	[Token(Token = "0x600106E")]
	private static bool DomainCharsTest(string name) { }

	[Address(RVA = "0x26BACA0", Offset = "0x26BA0A0", Length = "0x10C")]
	[Token(Token = "0x600107C")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x26BCCB0", Offset = "0x26BC0B0", Length = "0xB0")]
	[Token(Token = "0x600105F")]
	private string get__Domain() { }

	[Address(RVA = "0x26BCD70", Offset = "0x26BC170", Length = "0x73")]
	[Token(Token = "0x6001069")]
	private string get__Path() { }

	[Address(RVA = "0x26BCDF0", Offset = "0x26BC1F0", Length = "0xAB")]
	[Token(Token = "0x6001071")]
	private string get__Port() { }

	[Address(RVA = "0x26BCEA0", Offset = "0x26BC2A0", Length = "0xEB")]
	[Token(Token = "0x600107A")]
	private string get__Version() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001058")]
	public string get_Comment() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600105D")]
	public string get_Domain() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6001060")]
	internal bool get_DomainImplicit() { }

	[Address(RVA = "0x26BCBD0", Offset = "0x26BBFD0", Length = "0x13")]
	[Token(Token = "0x6001077")]
	internal string get_DomainKey() { }

	[Address(RVA = "0x26BCBF0", Offset = "0x26BBFF0", Length = "0xB3")]
	[Token(Token = "0x6001062")]
	public bool get_Expired() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001064")]
	public string get_Name() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001067")]
	public string get_Path() { }

	[Address(RVA = "0x253C5D0", Offset = "0x253B9D0", Length = "0x8")]
	[Token(Token = "0x600106A")]
	internal bool get_Plain() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001070")]
	internal Int32[] get_PortList() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x6001072")]
	public bool get_Secure() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6001074")]
	public string get_Value() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6001076")]
	internal CookieVariant get_Variant() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x6001078")]
	public int get_Version() { }

	[Address(RVA = "0x26BADB0", Offset = "0x26BA1B0", Length = "0x4F")]
	[Token(Token = "0x600107B")]
	internal static IComparer GetComparer() { }

	[Address(RVA = "0x26BAE00", Offset = "0x26BA200", Length = "0x1BD")]
	[Token(Token = "0x600107D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26BAFC0", Offset = "0x26BA3C0", Length = "0xFE")]
	[Token(Token = "0x6001066")]
	internal bool InternalSetName(string value) { }

	[Address(RVA = "0x26BB0C0", Offset = "0x26BA4C0", Length = "0x5C")]
	[Token(Token = "0x600106C")]
	private static bool IsDomainEqualToHost(string domain, string host) { }

	[Address(RVA = "0x2318F70", Offset = "0x2318370", Length = "0x23")]
	[Token(Token = "0x6001059")]
	public void set_Comment(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600105A")]
	public void set_CommentUri(Uri value) { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[Token(Token = "0x600105C")]
	public void set_Discard(bool value) { }

	[Address(RVA = "0x26BCF90", Offset = "0x26BC390", Length = "0x63")]
	[Token(Token = "0x600105E")]
	public void set_Domain(string value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[Token(Token = "0x6001061")]
	internal void set_DomainImplicit(bool value) { }

	[Address(RVA = "0x1BBC1C0", Offset = "0x1BBB5C0", Length = "0x5")]
	[Token(Token = "0x6001063")]
	public void set_Expires(DateTime value) { }

	[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
	[Token(Token = "0x600105B")]
	public void set_HttpOnly(bool value) { }

	[Address(RVA = "0x26BD000", Offset = "0x26BC400", Length = "0x15D")]
	[Token(Token = "0x6001065")]
	public void set_Name(string value) { }

	[Address(RVA = "0x26BD160", Offset = "0x26BC560", Length = "0x40")]
	[Token(Token = "0x6001068")]
	public void set_Path(string value) { }

	[Address(RVA = "0x26BD1B0", Offset = "0x26BC5B0", Length = "0x4AE")]
	[Token(Token = "0x600106F")]
	public void set_Port(string value) { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[Token(Token = "0x6001073")]
	public void set_Secure(bool value) { }

	[Address(RVA = "0x26BD660", Offset = "0x26BCA60", Length = "0x38")]
	[Token(Token = "0x6001075")]
	public void set_Value(string value) { }

	[Address(RVA = "0x26BD6A0", Offset = "0x26BCAA0", Length = "0x74")]
	[Token(Token = "0x6001079")]
	public void set_Version(int value) { }

	[Address(RVA = "0x26BB120", Offset = "0x26BA520", Length = "0x4C0")]
	[Token(Token = "0x600107E")]
	public virtual string ToString() { }

	[Address(RVA = "0x26BB5F0", Offset = "0x26BA9F0", Length = "0xFFF")]
	[Token(Token = "0x600106D")]
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

}

