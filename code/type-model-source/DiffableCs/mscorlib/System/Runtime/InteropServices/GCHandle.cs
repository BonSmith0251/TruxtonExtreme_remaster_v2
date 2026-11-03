namespace System.Runtime.InteropServices;

[ComVisible(True)]
[Token(Token = "0x200045A")]
public struct GCHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001229")]
	private IntPtr handle; //Field offset: 0x0

	[Token(Token = "0x170003F2")]
	public bool IsAllocated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x600204C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003F3")]
	public object Target
	{
		[Address(RVA = "0x1F360B0", Offset = "0x1F354B0", Length = "0x7F")]
		[Token(Token = "0x6002050")]
		 get { } //Length: 127
		[Address(RVA = "0x1F36130", Offset = "0x1F35530", Length = "0x59")]
		[Token(Token = "0x6002051")]
		 set { } //Length: 89
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6002049")]
	private GCHandle(IntPtr h) { }

	[Address(RVA = "0x1F36080", Offset = "0x1F35480", Length = "0x25")]
	[Token(Token = "0x600204A")]
	private GCHandle(object obj) { }

	[Address(RVA = "0x1F36050", Offset = "0x1F35450", Length = "0x2C")]
	[Token(Token = "0x600204B")]
	internal GCHandle(object value, GCHandleType type) { }

	[Address(RVA = "0x1F35CD0", Offset = "0x1F350D0", Length = "0xCD")]
	[Token(Token = "0x6002052")]
	public IntPtr AddrOfPinnedObject() { }

	[Address(RVA = "0x1F35DA0", Offset = "0x1F351A0", Length = "0x15")]
	[Token(Token = "0x6002054")]
	public static GCHandle Alloc(object value, GCHandleType type) { }

	[Address(RVA = "0x1F35DC0", Offset = "0x1F351C0", Length = "0xF")]
	[Token(Token = "0x6002053")]
	public static GCHandle Alloc(object value) { }

	[Address(RVA = "0x1F35DD0", Offset = "0x1F351D0", Length = "0x9")]
	[Token(Token = "0x600204F")]
	internal static bool CanDereferenceHandle(IntPtr handle) { }

	[Address(RVA = "0x1F35DE0", Offset = "0x1F351E0", Length = "0x5")]
	[Token(Token = "0x6002058")]
	private static bool CheckCurrentDomain(IntPtr handle) { }

	[Address(RVA = "0x1F35DF0", Offset = "0x1F351F0", Length = "0x81")]
	[Token(Token = "0x600205E")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1F35E90", Offset = "0x1F35290", Length = "0x75")]
	[Token(Token = "0x6002055")]
	public void Free() { }

	[Address(RVA = "0x1F35E80", Offset = "0x1F35280", Length = "0x5")]
	[Token(Token = "0x600205B")]
	private static void FreeHandle(IntPtr handle) { }

	[Address(RVA = "0x1F35F10", Offset = "0x1F35310", Length = "0xB1")]
	[Token(Token = "0x6002060")]
	public static GCHandle FromIntPtr(IntPtr value) { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x600204C")]
	public bool get_IsAllocated() { }

	[Address(RVA = "0x1F360B0", Offset = "0x1F354B0", Length = "0x7F")]
	[Token(Token = "0x6002050")]
	public object get_Target() { }

	[Address(RVA = "0x1F35FD0", Offset = "0x1F353D0", Length = "0x5")]
	[Token(Token = "0x600205C")]
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	[Address(RVA = "0x6041E0", Offset = "0x6035E0", Length = "0x7")]
	[Token(Token = "0x600205F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F35FE0", Offset = "0x1F353E0", Length = "0x13")]
	[Token(Token = "0x600204D")]
	internal static object GetRef(IntPtr handle) { }

	[Address(RVA = "0x1F36010", Offset = "0x1F35410", Length = "0x5")]
	[Token(Token = "0x6002059")]
	private static object GetTarget(IntPtr handle) { }

	[Address(RVA = "0x1F36000", Offset = "0x1F35400", Length = "0x5")]
	[Token(Token = "0x600205A")]
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x600205D")]
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002056")]
	public static IntPtr op_Explicit(GCHandle value) { }

	[Address(RVA = "0x1F35F10", Offset = "0x1F35310", Length = "0xB1")]
	[Token(Token = "0x6002057")]
	public static GCHandle op_Explicit(IntPtr value) { }

	[Address(RVA = "0x1F36130", Offset = "0x1F35530", Length = "0x59")]
	[Token(Token = "0x6002051")]
	public void set_Target(object value) { }

	[Address(RVA = "0x1F36020", Offset = "0x1F35420", Length = "0x23")]
	[Token(Token = "0x600204E")]
	internal static void SetRef(IntPtr handle, object value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002061")]
	public static IntPtr ToIntPtr(GCHandle value) { }

}

