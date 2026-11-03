namespace System.Net;

[Token(Token = "0x20002B2")]
public class ServicePointManager
{
	[Token(Token = "0x20002B3")]
	public class SPKey
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B5D")]
		private Uri uri; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B5E")]
		private Uri proxy; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B5F")]
		private bool use_connect; //Field offset: 0x20

		[Token(Token = "0x170003F2")]
		public bool UsesProxy
		{
			[Address(RVA = "0x25C9600", Offset = "0x25C8A00", Length = "0x50")]
			[Token(Token = "0x6001239")]
			 get { } //Length: 80
		}

		[Address(RVA = "0x1F29340", Offset = "0x1F28740", Length = "0x61")]
		[Token(Token = "0x6001238")]
		public SPKey(Uri uri, Uri proxy, bool use_connect) { }

		[Address(RVA = "0x25C9410", Offset = "0x25C8810", Length = "0x10F")]
		[Token(Token = "0x600123B")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x25C9600", Offset = "0x25C8A00", Length = "0x50")]
		[Token(Token = "0x6001239")]
		public bool get_UsesProxy() { }

		[Address(RVA = "0x25C9520", Offset = "0x25C8920", Length = "0xD6")]
		[Token(Token = "0x600123A")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x4000B4F")]
	private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints; //Field offset: 0x0
	[Token(Token = "0x4000B50")]
	private static ICertificatePolicy policy; //Field offset: 0x8
	[Token(Token = "0x4000B51")]
	private static int defaultConnectionLimit; //Field offset: 0x10
	[Token(Token = "0x4000B52")]
	private static int maxServicePointIdleTime; //Field offset: 0x14
	[Token(Token = "0x4000B53")]
	private static int maxServicePoints; //Field offset: 0x18
	[Token(Token = "0x4000B54")]
	private static int dnsRefreshTimeout; //Field offset: 0x1C
	[Token(Token = "0x4000B55")]
	private static bool _checkCRL; //Field offset: 0x20
	[Token(Token = "0x4000B56")]
	private static SecurityProtocolType _securityProtocol; //Field offset: 0x24
	[Token(Token = "0x4000B57")]
	private static bool expectContinue; //Field offset: 0x28
	[Token(Token = "0x4000B58")]
	private static bool useNagle; //Field offset: 0x29
	[Token(Token = "0x4000B59")]
	private static ServerCertValidationCallback server_cert_cb; //Field offset: 0x30
	[Token(Token = "0x4000B5A")]
	private static bool tcp_keepalive; //Field offset: 0x38
	[Token(Token = "0x4000B5B")]
	private static int tcp_keepalive_time; //Field offset: 0x3C
	[Token(Token = "0x4000B5C")]
	private static int tcp_keepalive_interval; //Field offset: 0x40

	[MonoTODO("CRL checks not implemented")]
	[Token(Token = "0x170003ED")]
	public static bool CheckCertificateRevocationList
	{
		[Address(RVA = "0x25CA0C0", Offset = "0x25C94C0", Length = "0x4F")]
		[Token(Token = "0x6001230")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170003EE")]
	public static int DnsRefreshTimeout
	{
		[Address(RVA = "0x25CA110", Offset = "0x25C9510", Length = "0x4E")]
		[Token(Token = "0x6001231")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170003EF")]
	public static SecurityProtocolType SecurityProtocol
	{
		[Address(RVA = "0x25CA160", Offset = "0x25C9560", Length = "0x4E")]
		[Token(Token = "0x6001232")]
		 get { } //Length: 78
		[Address(RVA = "0x25CA290", Offset = "0x25C9690", Length = "0x53")]
		[Token(Token = "0x6001233")]
		 set { } //Length: 83
	}

	[Token(Token = "0x170003F1")]
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		[Address(RVA = "0x25CA200", Offset = "0x25C9600", Length = "0x84")]
		[Token(Token = "0x6001235")]
		 get { } //Length: 132
	}

	[Token(Token = "0x170003F0")]
	internal static ServerCertValidationCallback ServerCertValidationCallback
	{
		[Address(RVA = "0x25CA1B0", Offset = "0x25C95B0", Length = "0x4F")]
		[Token(Token = "0x6001234")]
		internal get { } //Length: 79
	}

	[Address(RVA = "0x25C9FB0", Offset = "0x25C93B0", Length = "0x10B")]
	[Token(Token = "0x600122E")]
	private static ServicePointManager() { }

	[Address(RVA = "0x25C9650", Offset = "0x25C8A50", Length = "0x875")]
	[Token(Token = "0x6001236")]
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	[Address(RVA = "0x25CA0C0", Offset = "0x25C94C0", Length = "0x4F")]
	[Token(Token = "0x6001230")]
	public static bool get_CheckCertificateRevocationList() { }

	[Address(RVA = "0x25CA110", Offset = "0x25C9510", Length = "0x4E")]
	[Token(Token = "0x6001231")]
	public static int get_DnsRefreshTimeout() { }

	[Address(RVA = "0x25CA160", Offset = "0x25C9560", Length = "0x4E")]
	[Token(Token = "0x6001232")]
	public static SecurityProtocolType get_SecurityProtocol() { }

	[Address(RVA = "0x25CA200", Offset = "0x25C9600", Length = "0x84")]
	[Token(Token = "0x6001235")]
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	[Address(RVA = "0x25CA1B0", Offset = "0x25C95B0", Length = "0x4F")]
	[Token(Token = "0x6001234")]
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	[Address(RVA = "0x25C9ED0", Offset = "0x25C92D0", Length = "0x4F")]
	[Token(Token = "0x600122F")]
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	[Address(RVA = "0x25C9F20", Offset = "0x25C9320", Length = "0x8D")]
	[Token(Token = "0x6001237")]
	internal static void RemoveServicePoint(ServicePoint sp) { }

	[Address(RVA = "0x25CA290", Offset = "0x25C9690", Length = "0x53")]
	[Token(Token = "0x6001233")]
	public static void set_SecurityProtocol(SecurityProtocolType value) { }

}

