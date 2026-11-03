namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000059")]
public class InstanceProvider : IInstanceProvider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FB")]
	private Dictionary<GameObject, AsyncOperationHandle`1<GameObject>> m_InstanceObjectToPrefabHandle; //Field offset: 0x10

	[Address(RVA = "0x2E41970", Offset = "0x2E40D70", Length = "0x77")]
	[Token(Token = "0x6000209")]
	public InstanceProvider() { }

	[Address(RVA = "0x2E41690", Offset = "0x2E40A90", Length = "0xB8")]
	[Token(Token = "0x6000207")]
	public override GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	[Address(RVA = "0x2E41750", Offset = "0x2E40B50", Length = "0x210")]
	[Token(Token = "0x6000208")]
	public override void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

}

