namespace Mono.Btls;

[Token(Token = "0x2000079")]
internal abstract class MonoBtlsObject : IDisposable
{
	[Token(Token = "0x200007A")]
	private abstract class MonoBtlsHandle : SafeHandle
	{

		[Token(Token = "0x1700005E")]
		public virtual bool IsInvalid
		{
			[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
			[Token(Token = "0x60001E4")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x22C3F90", Offset = "0x22C3390", Length = "0x8")]
		[Token(Token = "0x60001E3")]
		internal MonoBtlsHandle(IntPtr handle, bool ownsHandle) { }

		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x60001E4")]
		public virtual bool get_IsInvalid() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014A")]
	private MonoBtlsHandle handle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014B")]
	private Exception lastError; //Field offset: 0x18

	[Token(Token = "0x1700005C")]
	internal MonoBtlsHandle Handle
	{
		[Address(RVA = "0x22C4EA0", Offset = "0x22C42A0", Length = "0x1A")]
		[Token(Token = "0x60001D6")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x1700005D")]
	public bool IsValid
	{
		[Address(RVA = "0x22C4EC0", Offset = "0x22C42C0", Length = "0x33")]
		[Token(Token = "0x60001D7")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60001D5")]
	internal MonoBtlsObject(MonoBtlsHandle handle) { }

	[Address(RVA = "0x22C4810", Offset = "0x22C3C10", Length = "0x182")]
	[Token(Token = "0x60001DA")]
	protected void CheckError(bool ok, string callerName = null) { }

	[Address(RVA = "0x22C49A0", Offset = "0x22C3DA0", Length = "0xE")]
	[Token(Token = "0x60001DB")]
	protected void CheckError(int ret, string callerName = null) { }

	[Address(RVA = "0x22C49B0", Offset = "0x22C3DB0", Length = "0x1F8")]
	[Token(Token = "0x60001DC")]
	protected private void CheckLastError(string callerName = null) { }

	[Address(RVA = "0x22C4BB0", Offset = "0x22C3FB0", Length = "0x99")]
	[Token(Token = "0x60001D8")]
	protected void CheckThrow() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001DF")]
	protected override void Close() { }

	[Address(RVA = "0x22C4C50", Offset = "0x22C4050", Length = "0xDB")]
	[Token(Token = "0x60001E0")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x22C4D30", Offset = "0x22C4130", Length = "0x56")]
	[Token(Token = "0x60001E1")]
	public override void Dispose() { }

	[Address(RVA = "0x22C4D90", Offset = "0x22C4190", Length = "0x5A")]
	[Token(Token = "0x60001E2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x22C4DF0", Offset = "0x22C41F0", Length = "0x78")]
	[Token(Token = "0x60001DE")]
	protected void FreeDataPtr(IntPtr data) { }

	[Address(RVA = "0x22C4EA0", Offset = "0x22C42A0", Length = "0x1A")]
	[Token(Token = "0x60001D6")]
	internal MonoBtlsHandle get_Handle() { }

	[Address(RVA = "0x22C4EC0", Offset = "0x22C42C0", Length = "0x33")]
	[Token(Token = "0x60001D7")]
	public bool get_IsValid() { }

	[Address(RVA = "0x22C4F00", Offset = "0x22C4300", Length = "0x78")]
	[Token(Token = "0x60001DD")]
	private static void mono_btls_free(IntPtr data) { }

	[Address(RVA = "0x22C4E70", Offset = "0x22C4270", Length = "0x26")]
	[Token(Token = "0x60001D9")]
	protected Exception SetException(Exception ex) { }

}

