namespace Unity.XGamingRuntime;

[Token(Token = "0x2000005")]
public abstract class EquatableHandle : SafeHandle
{

	[Token(Token = "0x17000005")]
	public IntPtr Handle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B338E0", Offset = "0x2B32CE0", Length = "0x27")]
	[Token(Token = "0x600000E")]
	public EquatableHandle(IntPtr invalidHandleValue, bool ownsHandle, IntPtr handle) { }

	[Address(RVA = "0x2B33820", Offset = "0x2B32C20", Length = "0xA8")]
	[Token(Token = "0x6000010")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600000F")]
	public IntPtr get_Handle() { }

	[Address(RVA = "0x2B338D0", Offset = "0x2B32CD0", Length = "0xB")]
	[Token(Token = "0x6000011")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B33910", Offset = "0x2B32D10", Length = "0x20")]
	[Token(Token = "0x6000012")]
	public static bool op_Equality(EquatableHandle handle1, EquatableHandle handle2) { }

	[Address(RVA = "0x2B33930", Offset = "0x2B32D30", Length = "0x36")]
	[Token(Token = "0x6000013")]
	public static bool op_Inequality(EquatableHandle handle1, EquatableHandle handle2) { }

}

