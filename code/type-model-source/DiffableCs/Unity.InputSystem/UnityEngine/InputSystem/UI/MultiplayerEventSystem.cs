namespace UnityEngine.InputSystem.UI;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/UISupport.html#multiplayer-uis")]
[Token(Token = "0x200011F")]
public class MultiplayerEventSystem : EventSystem
{
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40006A9")]
	[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
	private GameObject m_PlayerRoot; //Field offset: 0x60

	[Token(Token = "0x170003A2")]
	public GameObject playerRoot
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000DCF")]
		 get { } //Length: 5
		[Address(RVA = "0x29E1430", Offset = "0x29E0830", Length = "0x25")]
		[Token(Token = "0x6000DD0")]
		 set { } //Length: 37
	}

	[Address(RVA = "0x29E13E0", Offset = "0x29E07E0", Length = "0x49")]
	[Token(Token = "0x6000DD5")]
	public MultiplayerEventSystem() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000DCF")]
	public GameObject get_playerRoot() { }

	[Address(RVA = "0x29E1230", Offset = "0x29E0630", Length = "0x99")]
	[Token(Token = "0x6000DD3")]
	private void InitializePlayerRoot() { }

	[Address(RVA = "0x29E12D0", Offset = "0x29E06D0", Length = "0x7")]
	[Token(Token = "0x6000DD2")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x29E12E0", Offset = "0x29E06E0", Length = "0x1F")]
	[Token(Token = "0x6000DD1")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x29E1430", Offset = "0x29E0830", Length = "0x25")]
	[Token(Token = "0x6000DD0")]
	public void set_playerRoot(GameObject value) { }

	[Address(RVA = "0x29E1300", Offset = "0x29E0700", Length = "0xD6")]
	[Token(Token = "0x6000DD4")]
	protected virtual void Update() { }

}

