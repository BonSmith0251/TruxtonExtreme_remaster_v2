namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x200021D")]
public class ButtonControl : AxisControl
{
	[Token(Token = "0x4000C0F")]
	internal static float s_GlobalDefaultButtonPressPoint; //Field offset: 0x0
	[Token(Token = "0x4000C11")]
	internal const float kMinButtonPressPoint = 0.0001; //Field offset: 0x0
	[Token(Token = "0x4000C10")]
	internal static float s_GlobalDefaultButtonReleaseThreshold; //Field offset: 0x4
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000C09")]
	private bool m_NeedsToCheckFramePress; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000C0A")]
	private uint m_UpdateCountLastPressed; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000C0B")]
	private uint m_UpdateCountLastReleased; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000C0C")]
	private bool m_LastUpdateWasPress; //Field offset: 0x13C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x13D")]
	[Token(Token = "0x4000C0D")]
	private bool <needsToCheckFramePress>k__BackingField; //Field offset: 0x13D
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000C0E")]
	public float pressPoint; //Field offset: 0x140

	[Token(Token = "0x170005B0")]
	public bool isPressed
	{
		[Address(RVA = "0x290D7D0", Offset = "0x290CBD0", Length = "0x5E")]
		[Token(Token = "0x6001402")]
		 get { } //Length: 94
	}

	[Token(Token = "0x170005AE")]
	internal bool needsToCheckFramePress
	{
		[Address(RVA = "0x290D830", Offset = "0x290CC30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60013FD")]
		internal get { } //Length: 8
		[Address(RVA = "0x1D0F6A0", Offset = "0x1D0EAA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60013FE")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170005AF")]
	public float pressPointOrDefault
	{
		[Address(RVA = "0x290D840", Offset = "0x290CC40", Length = "0x56")]
		[Token(Token = "0x60013FF")]
		 get { } //Length: 86
	}

	[Token(Token = "0x170005B1")]
	public bool wasPressedThisFrame
	{
		[Address(RVA = "0x290D8A0", Offset = "0x290CCA0", Length = "0xFB")]
		[Token(Token = "0x6001404")]
		 get { } //Length: 251
	}

	[Token(Token = "0x170005B2")]
	public bool wasReleasedThisFrame
	{
		[Address(RVA = "0x290D9A0", Offset = "0x290CDA0", Length = "0xF2")]
		[Token(Token = "0x6001405")]
		 get { } //Length: 242
	}

	[Address(RVA = "0x290D720", Offset = "0x290CB20", Length = "0xAF")]
	[Token(Token = "0x6001400")]
	public ButtonControl() { }

	[Address(RVA = "0x290D560", Offset = "0x290C960", Length = "0x11F")]
	[Token(Token = "0x6001403")]
	private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) { }

	[Address(RVA = "0x290D7D0", Offset = "0x290CBD0", Length = "0x5E")]
	[Token(Token = "0x6001402")]
	public bool get_isPressed() { }

	[Address(RVA = "0x290D830", Offset = "0x290CC30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60013FD")]
	internal bool get_needsToCheckFramePress() { }

	[Address(RVA = "0x290D840", Offset = "0x290CC40", Length = "0x56")]
	[Token(Token = "0x60013FF")]
	public float get_pressPointOrDefault() { }

	[Address(RVA = "0x290D8A0", Offset = "0x290CCA0", Length = "0xFB")]
	[Token(Token = "0x6001404")]
	public bool get_wasPressedThisFrame() { }

	[Address(RVA = "0x290D9A0", Offset = "0x290CDA0", Length = "0xF2")]
	[Token(Token = "0x6001405")]
	public bool get_wasReleasedThisFrame() { }

	[Address(RVA = "0x290C1E0", Offset = "0x290B5E0", Length = "0x11A")]
	[Token(Token = "0x6001401")]
	public bool IsValueConsideredPressed(float value) { }

	[Address(RVA = "0x1D0F6A0", Offset = "0x1D0EAA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60013FE")]
	private void set_needsToCheckFramePress(bool value) { }

	[Address(RVA = "0x290D680", Offset = "0x290CA80", Length = "0x90")]
	[Token(Token = "0x6001406")]
	internal void UpdateWasPressed() { }

}

