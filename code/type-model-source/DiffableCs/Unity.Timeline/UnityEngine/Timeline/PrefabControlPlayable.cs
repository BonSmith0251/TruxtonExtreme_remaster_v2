namespace UnityEngine.Timeline;

[Token(Token = "0x200005B")]
public class PrefabControlPlayable : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000153")]
	private GameObject m_Instance; //Field offset: 0x10

	[Token(Token = "0x170000CB")]
	public GameObject prefabInstance
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002FC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000302")]
	public PrefabControlPlayable() { }

	[Address(RVA = "0x2F42290", Offset = "0x2F41690", Length = "0x14E")]
	[Token(Token = "0x60002FB")]
	public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60002FC")]
	public GameObject get_prefabInstance() { }

	[Address(RVA = "0x2F423E0", Offset = "0x2F417E0", Length = "0x2DA")]
	[Token(Token = "0x60002FD")]
	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) { }

	[Address(RVA = "0x2F426C0", Offset = "0x2F41AC0", Length = "0x91")]
	[Token(Token = "0x6000300")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F42760", Offset = "0x2F41B60", Length = "0x76")]
	[Token(Token = "0x60002FF")]
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F427E0", Offset = "0x2F41BE0", Length = "0xCC")]
	[Token(Token = "0x60002FE")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x2F428B0", Offset = "0x2F41CB0", Length = "0x28C")]
	[Token(Token = "0x6000301")]
	private static void SetHideFlagsRecursive(GameObject gameObject) { }

}

