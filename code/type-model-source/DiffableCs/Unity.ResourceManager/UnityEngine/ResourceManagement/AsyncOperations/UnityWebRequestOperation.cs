namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200008A")]
internal class UnityWebRequestOperation : AsyncOperationBase<UnityWebRequest>
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000190")]
	private UnityWebRequest m_UWR; //Field offset: 0x98

	[Address(RVA = "0x2E53C40", Offset = "0x2E53040", Length = "0x1E3")]
	[Token(Token = "0x6000399")]
	public UnityWebRequestOperation(UnityWebRequest webRequest) { }

	[Address(RVA = "0x2E53BA0", Offset = "0x2E52FA0", Length = "0x97")]
	[CompilerGenerated]
	[Token(Token = "0x600039B")]
	private void <Execute>b__2_0(AsyncOperation request) { }

	[Address(RVA = "0x2E53B00", Offset = "0x2E52F00", Length = "0x9C")]
	[Token(Token = "0x600039A")]
	protected virtual void Execute() { }

}

