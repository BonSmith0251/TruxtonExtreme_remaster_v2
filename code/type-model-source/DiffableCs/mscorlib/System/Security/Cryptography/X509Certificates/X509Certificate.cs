namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000336")]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D90")]
	private X509CertificateImpl impl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D91")]
	private Byte[] lazyCertHash; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D92")]
	private Byte[] lazySerialNumber; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D93")]
	private string lazyIssuer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D94")]
	private string lazySubject; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D95")]
	private string lazyKeyAlgorithm; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D96")]
	private Byte[] lazyKeyAlgorithmParameters; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D97")]
	private Byte[] lazyPublicKey; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D98")]
	private DateTime lazyNotBefore; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D99")]
	private DateTime lazyNotAfter; //Field offset: 0x58

	[Token(Token = "0x1700029B")]
	internal X509CertificateImpl Impl
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001A02")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000299")]
	public string Issuer
	{
		[Address(RVA = "0x1EF6750", Offset = "0x1EF5B50", Length = "0xA5")]
		[Token(Token = "0x60019E8")]
		 get { } //Length: 165
	}

	[Token(Token = "0x1700029C")]
	internal bool IsValid
	{
		[Address(RVA = "0x1EF6730", Offset = "0x1EF5B30", Length = "0x20")]
		[Token(Token = "0x6001A03")]
		internal get { } //Length: 32
	}

	[Token(Token = "0x1700029A")]
	public string Subject
	{
		[Address(RVA = "0x1EF6800", Offset = "0x1EF5C00", Length = "0xA5")]
		[Token(Token = "0x60019E9")]
		 get { } //Length: 165
	}

	[Address(RVA = "0x1EF6100", Offset = "0x1EF5500", Length = "0x78")]
	[Token(Token = "0x60019DF")]
	public X509Certificate() { }

	[Address(RVA = "0x1EF6240", Offset = "0x1EF5640", Length = "0x156")]
	[Token(Token = "0x60019E0")]
	public X509Certificate(Byte[] data) { }

	[Address(RVA = "0x1EF60E0", Offset = "0x1EF54E0", Length = "0x1A")]
	[Token(Token = "0x60019E1")]
	public X509Certificate(Byte[] rawData, string password) { }

	[Address(RVA = "0x1EF63A0", Offset = "0x1EF57A0", Length = "0x38F")]
	[Token(Token = "0x60019E2")]
	public X509Certificate(Byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x1EF6180", Offset = "0x1EF5580", Length = "0xB3")]
	[Token(Token = "0x60019E3")]
	internal X509Certificate(X509CertificateImpl impl) { }

	[Address(RVA = "0x1EF5EE0", Offset = "0x1EF52E0", Length = "0x1A4")]
	[Token(Token = "0x60019E4")]
	public X509Certificate(X509Certificate cert) { }

	[Address(RVA = "0x1EF6090", Offset = "0x1EF5490", Length = "0x45")]
	[Token(Token = "0x60019E5")]
	public X509Certificate(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EF4750", Offset = "0x1EF3B50", Length = "0x16")]
	[Token(Token = "0x60019EA")]
	public override void Dispose() { }

	[Address(RVA = "0x1EF4770", Offset = "0x1EF3B70", Length = "0x19")]
	[Token(Token = "0x60019EB")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1EF4790", Offset = "0x1EF3B90", Length = "0x106")]
	[Token(Token = "0x60019ED")]
	public override bool Equals(X509Certificate other) { }

	[Address(RVA = "0x1EF48A0", Offset = "0x1EF3CA0", Length = "0x8D")]
	[Token(Token = "0x60019EC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1EF4930", Offset = "0x1EF3D30", Length = "0x1BF")]
	[Token(Token = "0x60019EE")]
	public override Byte[] Export(X509ContentType contentType, string password) { }

	[Address(RVA = "0x1EF4AF0", Offset = "0x1EF3EF0", Length = "0x160")]
	[Token(Token = "0x60019FE")]
	protected static string FormatDate(DateTime date) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001A02")]
	internal X509CertificateImpl get_Impl() { }

	[Address(RVA = "0x1EF6750", Offset = "0x1EF5B50", Length = "0xA5")]
	[Token(Token = "0x60019E8")]
	public string get_Issuer() { }

	[Address(RVA = "0x1EF6730", Offset = "0x1EF5B30", Length = "0x20")]
	[Token(Token = "0x6001A03")]
	internal bool get_IsValid() { }

	[Address(RVA = "0x1EF6800", Offset = "0x1EF5C00", Length = "0xA5")]
	[Token(Token = "0x60019E9")]
	public string get_Subject() { }

	[Address(RVA = "0x1EF4D10", Offset = "0x1EF4110", Length = "0xAB")]
	[Token(Token = "0x60019EF")]
	public override Byte[] GetCertHash() { }

	[Address(RVA = "0x1EF4C60", Offset = "0x1EF4060", Length = "0xAB")]
	[Token(Token = "0x60019F0")]
	public override string GetCertHashString() { }

	[Address(RVA = "0x1EF4DC0", Offset = "0x1EF41C0", Length = "0xB5")]
	[Token(Token = "0x60019F3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1EF4F30", Offset = "0x1EF4330", Length = "0xA5")]
	[Token(Token = "0x60019F4")]
	public override string GetKeyAlgorithm() { }

	[Address(RVA = "0x1EF4E80", Offset = "0x1EF4280", Length = "0xAB")]
	[Token(Token = "0x60019F5")]
	public override Byte[] GetKeyAlgorithmParameters() { }

	[Address(RVA = "0x1EF4FE0", Offset = "0x1EF43E0", Length = "0xE3")]
	[Token(Token = "0x60019FC")]
	internal DateTime GetNotAfter() { }

	[Address(RVA = "0x1EF50D0", Offset = "0x1EF44D0", Length = "0xE3")]
	[Token(Token = "0x60019FD")]
	internal DateTime GetNotBefore() { }

	[Address(RVA = "0x1EF51C0", Offset = "0x1EF45C0", Length = "0xAB")]
	[Token(Token = "0x60019F6")]
	public override Byte[] GetPublicKey() { }

	[Address(RVA = "0x1EF5270", Offset = "0x1EF4670", Length = "0x7B")]
	[Token(Token = "0x60019F2")]
	public override Byte[] GetRawCertData() { }

	[Address(RVA = "0x1EF52F0", Offset = "0x1EF46F0", Length = "0x62")]
	[Token(Token = "0x60019F1")]
	private Byte[] GetRawCertHash() { }

	[Address(RVA = "0x1EF5360", Offset = "0x1EF4760", Length = "0x62")]
	[Token(Token = "0x60019F9")]
	private Byte[] GetRawSerialNumber() { }

	[Address(RVA = "0x1EF5480", Offset = "0x1EF4880", Length = "0xE1")]
	[Token(Token = "0x60019F7")]
	public override Byte[] GetSerialNumber() { }

	[Address(RVA = "0x1EF53D0", Offset = "0x1EF47D0", Length = "0xAB")]
	[Token(Token = "0x60019F8")]
	public override string GetSerialNumberString() { }

	[Address(RVA = "0x1EF5570", Offset = "0x1EF4970", Length = "0x3D")]
	[Token(Token = "0x6001A01")]
	internal void ImportHandle(X509CertificateImpl impl) { }

	[Address(RVA = "0x1EF55B0", Offset = "0x1EF49B0", Length = "0x17C")]
	[Token(Token = "0x60019DE")]
	public override void Reset() { }

	[Address(RVA = "0x1EF5730", Offset = "0x1EF4B30", Length = "0x3E")]
	[Token(Token = "0x60019E7")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1EF5770", Offset = "0x1EF4B70", Length = "0x3E")]
	[Token(Token = "0x60019E6")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EF57B0", Offset = "0x1EF4BB0", Length = "0x54")]
	[Token(Token = "0x6001A04")]
	internal void ThrowIfInvalid() { }

	[Address(RVA = "0x1EF5810", Offset = "0x1EF4C10", Length = "0x16")]
	[Token(Token = "0x60019FA")]
	public virtual string ToString() { }

	[Address(RVA = "0x1EF5830", Offset = "0x1EF4C30", Length = "0x51C")]
	[Token(Token = "0x60019FB")]
	public override string ToString(bool fVerbose) { }

	[Address(RVA = "0x1EF5D50", Offset = "0x1EF5150", Length = "0x110")]
	[Token(Token = "0x60019FF")]
	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x1EF5E70", Offset = "0x1EF5270", Length = "0x63")]
	[Token(Token = "0x6001A00")]
	private void VerifyContentType(X509ContentType contentType) { }

}

