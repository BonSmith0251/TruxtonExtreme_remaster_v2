namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Toggle Group", 31)]
[DisallowMultipleComponent]
[Token(Token = "0x2000078")]
public class ToggleGroup : UIBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private sealed class <>c
	{
		[Token(Token = "0x400025A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400025B")]
		public static Predicate<Toggle> <>9__13_0; //Field offset: 0x8
		[Token(Token = "0x400025C")]
		public static Func<Toggle, Boolean> <>9__14_0; //Field offset: 0x10

		[Address(RVA = "0x345F570", Offset = "0x345E970", Length = "0x67")]
		[Token(Token = "0x6000501")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000502")]
		public <>c() { }

		[Address(RVA = "0x345F550", Offset = "0x345E950", Length = "0x1A")]
		[Token(Token = "0x6000504")]
		internal bool <ActiveToggles>b__14_0(Toggle x) { }

		[Address(RVA = "0x345F550", Offset = "0x345E950", Length = "0x1A")]
		[Token(Token = "0x6000503")]
		internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000258")]
	private bool m_AllowSwitchOff; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000259")]
	protected List<Toggle> m_Toggles; //Field offset: 0x28

	[Token(Token = "0x17000151")]
	public bool allowSwitchOff
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60004F3")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60004F4")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x345EA80", Offset = "0x345DE80", Length = "0x77")]
	[Token(Token = "0x60004F5")]
	protected ToggleGroup() { }

	[Address(RVA = "0x345DD50", Offset = "0x345D150", Length = "0x111")]
	[Token(Token = "0x60004FE")]
	public IEnumerable<Toggle> ActiveToggles() { }

	[Address(RVA = "0x345DE70", Offset = "0x345D270", Length = "0x14C")]
	[Token(Token = "0x60004FD")]
	public bool AnyTogglesOn() { }

	[Address(RVA = "0x345DFC0", Offset = "0x345D3C0", Length = "0x40B")]
	[Token(Token = "0x60004FC")]
	public void EnsureValidState() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60004F3")]
	public bool get_allowSwitchOff() { }

	[Address(RVA = "0x345E3D0", Offset = "0x345D7D0", Length = "0x6D")]
	[Token(Token = "0x60004FF")]
	public Toggle GetFirstActiveToggle() { }

	[Address(RVA = "0x345E440", Offset = "0x345D840", Length = "0x254")]
	[Token(Token = "0x60004F9")]
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = true) { }

	[Address(RVA = "0x345E6A0", Offset = "0x345DAA0", Length = "0x1F")]
	[Token(Token = "0x60004F7")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x345E6C0", Offset = "0x345DAC0", Length = "0xD6")]
	[Token(Token = "0x60004FB")]
	public void RegisterToggle(Toggle toggle) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60004F4")]
	public void set_allowSwitchOff(bool value) { }

	[Address(RVA = "0x345E7A0", Offset = "0x345DBA0", Length = "0x10A")]
	[Token(Token = "0x6000500")]
	public void SetAllTogglesOff(bool sendCallback = true) { }

	[Address(RVA = "0x345E6A0", Offset = "0x345DAA0", Length = "0x1F")]
	[Token(Token = "0x60004F6")]
	protected virtual void Start() { }

	[Address(RVA = "0x345E8B0", Offset = "0x345DCB0", Length = "0x7C")]
	[Token(Token = "0x60004FA")]
	public void UnregisterToggle(Toggle toggle) { }

	[Address(RVA = "0x345E930", Offset = "0x345DD30", Length = "0x14B")]
	[Token(Token = "0x60004F8")]
	private void ValidateToggleIsInGroup(Toggle toggle) { }

}

