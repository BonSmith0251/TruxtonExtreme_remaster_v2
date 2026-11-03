namespace UnityEngine.UI;

[Token(Token = "0x2000004")]
public class AnimationTriggers
{
	[Token(Token = "0x4000006")]
	private const string kDefaultNormalAnimName = "Normal"; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	private const string kDefaultHighlightedAnimName = "Highlighted"; //Field offset: 0x0
	[Token(Token = "0x4000008")]
	private const string kDefaultPressedAnimName = "Pressed"; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	private const string kDefaultSelectedAnimName = "Selected"; //Field offset: 0x0
	[Token(Token = "0x400000A")]
	private const string kDefaultDisabledAnimName = "Disabled"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private string m_NormalTrigger; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private string m_HighlightedTrigger; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	private string m_PressedTrigger; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	[Token(Token = "0x400000E")]
	private string m_SelectedTrigger; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	[Token(Token = "0x400000F")]
	private string m_DisabledTrigger; //Field offset: 0x30

	[Token(Token = "0x17000005")]
	public string disabledTrigger
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000002")]
	public string highlightedTrigger
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000006")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000001")]
	public string normalTrigger
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000004")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000003")]
	public string pressedTrigger
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000008")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000004")]
	public string selectedTrigger
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600000A")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x31D0EE0", Offset = "0x31D02E0", Length = "0xEB")]
	[Token(Token = "0x600000D")]
	public AnimationTriggers() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600000B")]
	public string get_disabledTrigger() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000005")]
	public string get_highlightedTrigger() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000003")]
	public string get_normalTrigger() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000007")]
	public string get_pressedTrigger() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000009")]
	public string get_selectedTrigger() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600000C")]
	public void set_disabledTrigger(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000006")]
	public void set_highlightedTrigger(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000004")]
	public void set_normalTrigger(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000008")]
	public void set_pressedTrigger(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600000A")]
	public void set_selectedTrigger(string value) { }

}

