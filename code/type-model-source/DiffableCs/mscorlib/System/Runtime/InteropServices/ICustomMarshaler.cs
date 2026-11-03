namespace System.Runtime.InteropServices;

[Token(Token = "0x2000443")]
public interface ICustomMarshaler
{

	[Token(Token = "0x6002023")]
	public void CleanUpManagedData(object ManagedObj) { }

	[Token(Token = "0x6002022")]
	public void CleanUpNativeData(IntPtr pNativeData) { }

	[Token(Token = "0x6002024")]
	public int GetNativeDataSize() { }

	[Token(Token = "0x6002021")]
	public IntPtr MarshalManagedToNative(object ManagedObj) { }

	[Token(Token = "0x6002020")]
	public object MarshalNativeToManaged(IntPtr pNativeData) { }

}

