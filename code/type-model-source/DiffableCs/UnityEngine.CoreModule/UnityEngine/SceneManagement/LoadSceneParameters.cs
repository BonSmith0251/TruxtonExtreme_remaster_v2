namespace UnityEngine.SceneManagement;

[Token(Token = "0x2000265")]
public struct LoadSceneParameters
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40007DD")]
	private LoadSceneMode m_LoadSceneMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40007DE")]
	private LocalPhysicsMode m_LocalPhysicsMode; //Field offset: 0x4

	[Address(RVA = "0xFD4710", Offset = "0xFD3B10", Length = "0xA")]
	[Token(Token = "0x6001888")]
	public LoadSceneParameters(LoadSceneMode mode) { }

}

