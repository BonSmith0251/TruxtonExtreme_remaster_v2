namespace System.Net;

[Token(Token = "0x200028D")]
internal class ServerCertValidationCallback
{
	[Token(Token = "0x200028E")]
	private class CallbackContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A69")]
		internal readonly object request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A6A")]
		internal readonly X509Certificate certificate; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A6B")]
		internal readonly X509Chain chain; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A6C")]
		internal readonly SslPolicyErrors sslPolicyErrors; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000A6D")]
		internal bool result; //Field offset: 0x2C

		[Address(RVA = "0x26B3D20", Offset = "0x26B3120", Length = "0x73")]
		[Token(Token = "0x600112A")]
		internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A67")]
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A68")]
	private readonly ExecutionContext m_Context; //Field offset: 0x18

	[Token(Token = "0x1700039C")]
	internal RemoteCertificateValidationCallback ValidationCallback
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001127")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x26CD610", Offset = "0x26CCA10", Length = "0x7C")]
	[Token(Token = "0x6001126")]
	internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback) { }

	[Address(RVA = "0x26CD3F0", Offset = "0x26CC7F0", Length = "0xA8")]
	[Token(Token = "0x6001128")]
	internal void Callback(object state) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001127")]
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	[Address(RVA = "0x26CD4A0", Offset = "0x26CC8A0", Length = "0x16A")]
	[Token(Token = "0x6001129")]
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

