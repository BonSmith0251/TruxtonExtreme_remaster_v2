namespace Unity.Burst;

[Token(Token = "0x200002B")]
public interface IFunctionPointer
{

	[Obsolete("This method will be removed in a future version of Burst")]
	[Token(Token = "0x60000DB")]
	public IFunctionPointer FromIntPtr(IntPtr ptr) { }

}

