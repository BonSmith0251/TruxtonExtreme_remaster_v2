namespace Mono.Btls;

[Token(Token = "0x2000096")]
internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject
{
	[Token(Token = "0x2000097")]
	public class BoringX509LookupMonoHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x60002B1")]
		public BoringX509LookupMonoHandle(IntPtr handle) { }

		[Address(RVA = "0x25F9200", Offset = "0x25F8600", Length = "0x7B")]
		[Token(Token = "0x60002B2")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000098")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BySubjectFunc : MulticastDelegate
	{

		[Address(RVA = "0x25F94D0", Offset = "0x25F88D0", Length = "0xA6")]
		[Token(Token = "0x60002B3")]
		public BySubjectFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60002B4")]
		public override int Invoke(IntPtr instance, IntPtr name, out IntPtr x509_ptr) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001BA")]
	private GCHandle gch; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001BB")]
	private IntPtr instance; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001BC")]
	private BySubjectFunc bySubjectFunc; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001BD")]
	private IntPtr bySubjectFuncPtr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001BE")]
	private MonoBtlsX509Lookup lookup; //Field offset: 0x40

	[Token(Token = "0x17000070")]
	internal BoringX509LookupMonoHandle Handle
	{
		[Address(RVA = "0x2604330", Offset = "0x2603730", Length = "0x71")]
		[Token(Token = "0x60002A7")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x26040A0", Offset = "0x26034A0", Length = "0x280")]
	[Token(Token = "0x60002AB")]
	internal MonoBtlsX509LookupMono() { }

	[Address(RVA = "0x2603C00", Offset = "0x2603000", Length = "0x113")]
	[Token(Token = "0x60002AD")]
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	[Address(RVA = "0x2603D20", Offset = "0x2603120", Length = "0x89")]
	[Token(Token = "0x60002B0")]
	protected virtual void Close() { }

	[Address(RVA = "0x2604330", Offset = "0x2603730", Length = "0x71")]
	[Token(Token = "0x60002A7")]
	internal BoringX509LookupMonoHandle get_Handle() { }

	[Address(RVA = "0x2603DB0", Offset = "0x26031B0", Length = "0x5E")]
	[Token(Token = "0x60002AC")]
	internal void Install(MonoBtlsX509Lookup lookup) { }

	[Address(RVA = "0x26043B0", Offset = "0x26037B0", Length = "0x78")]
	[Token(Token = "0x60002AA")]
	private static int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	[Address(RVA = "0x2604430", Offset = "0x2603830", Length = "0x93")]
	[Token(Token = "0x60002A9")]
	private static void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	[Address(RVA = "0x26044D0", Offset = "0x26038D0", Length = "0x65")]
	[Token(Token = "0x60002A8")]
	private static IntPtr mono_btls_x509_lookup_mono_new() { }

	[Token(Token = "0x60002AE")]
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	[Address(RVA = "0x2603E10", Offset = "0x2603210", Length = "0x28D")]
	[MonoPInvokeCallback(typeof(BySubjectFunc))]
	[Token(Token = "0x60002AF")]
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) { }

}

