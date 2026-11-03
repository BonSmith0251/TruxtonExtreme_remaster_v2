namespace Mono.Btls;

[Token(Token = "0x200006F")]
internal class MonoBtlsBioMono : MonoBtlsBio
{
	[Token(Token = "0x2000073")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BioControlFunc : MulticastDelegate
	{

		[Address(RVA = "0x22BAD20", Offset = "0x22BA120", Length = "0xA6")]
		[Token(Token = "0x600019D")]
		public BioControlFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600019E")]
		public override long Invoke(IntPtr bio, ControlCommand command, long arg) { }

	}

	[Token(Token = "0x2000071")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BioReadFunc : MulticastDelegate
	{

		[Address(RVA = "0x22BADD0", Offset = "0x22BA1D0", Length = "0xA6")]
		[Token(Token = "0x6000199")]
		public BioReadFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x600019A")]
		public override int Invoke(IntPtr bio, IntPtr data, int dataLength, out int wantMore) { }

	}

	[Token(Token = "0x2000072")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BioWriteFunc : MulticastDelegate
	{

		[Address(RVA = "0x22BAE80", Offset = "0x22BA280", Length = "0xA6")]
		[Token(Token = "0x600019B")]
		public BioWriteFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600019C")]
		public override int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

	}

	[Token(Token = "0x2000070")]
	private enum ControlCommand : int
	{
		Flush = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000133")]
	private GCHandle handle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000134")]
	private IntPtr instance; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000135")]
	private BioReadFunc readFunc; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000136")]
	private BioWriteFunc writeFunc; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000137")]
	private BioControlFunc controlFunc; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000138")]
	private IntPtr readFuncPtr; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000139")]
	private IntPtr writeFuncPtr; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400013A")]
	private IntPtr controlFuncPtr; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400013B")]
	private IMonoBtlsBioMono backend; //Field offset: 0x60

	[Address(RVA = "0x22C0E30", Offset = "0x22C0230", Length = "0x469")]
	[Token(Token = "0x600018F")]
	public MonoBtlsBioMono(IMonoBtlsBioMono backend) { }

	[Address(RVA = "0x22C0340", Offset = "0x22BF740", Length = "0xA4")]
	[Token(Token = "0x6000198")]
	protected virtual void Close() { }

	[Address(RVA = "0x22C05B0", Offset = "0x22BF9B0", Length = "0x98")]
	[Token(Token = "0x6000192")]
	private long Control(ControlCommand command, long arg) { }

	[Address(RVA = "0x22C03F0", Offset = "0x22BF7F0", Length = "0x1BC")]
	[MonoPInvokeCallback(typeof(BioControlFunc))]
	[Token(Token = "0x6000197")]
	private static long Control(IntPtr instance, ControlCommand command, long arg) { }

	[Address(RVA = "0x22C12A0", Offset = "0x22C06A0", Length = "0xB2")]
	[Token(Token = "0x6000191")]
	private static void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	[Address(RVA = "0x22C1360", Offset = "0x22C0760", Length = "0x65")]
	[Token(Token = "0x6000190")]
	private static IntPtr mono_btls_bio_mono_new() { }

	[Address(RVA = "0x22C0900", Offset = "0x22BFD00", Length = "0x164")]
	[Token(Token = "0x6000193")]
	private int OnRead(IntPtr data, int dataLength, out int wantMore) { }

	[Address(RVA = "0x22C0650", Offset = "0x22BFA50", Length = "0x2A3")]
	[MonoPInvokeCallback(typeof(BioReadFunc))]
	[Token(Token = "0x6000194")]
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore) { }

	[Address(RVA = "0x22C0A70", Offset = "0x22BFE70", Length = "0x147")]
	[Token(Token = "0x6000195")]
	private int OnWrite(IntPtr data, int dataLength) { }

	[Address(RVA = "0x22C0BC0", Offset = "0x22BFFC0", Length = "0x263")]
	[MonoPInvokeCallback(typeof(BioWriteFunc))]
	[Token(Token = "0x6000196")]
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

}

