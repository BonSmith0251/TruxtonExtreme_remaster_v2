namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[Token(Token = "0x200000A")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation
{
	[Token(Token = "0x200000B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x347AD50", Offset = "0x347A150", Length = "0x54")]
		[Token(Token = "0x6000037")]
		public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000016")]
	private UnityWebRequest <webRequest>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000005")]
	public internal UnityWebRequest webRequest
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000035")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000036")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2FC2460", Offset = "0x2FC1860", Length = "0x8")]
	[Token(Token = "0x6000034")]
	private UnityWebRequestAsyncOperation(IntPtr ptr) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000035")]
	public UnityWebRequest get_webRequest() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000036")]
	internal void set_webRequest(UnityWebRequest value) { }

}

