namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Touch Input Module")]
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
[Token(Token = "0x20000C5")]
public class TouchInputModule : PointerInputModule
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000360")]
	private Vector2 m_LastMousePosition; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000361")]
	private Vector2 m_MousePosition; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000362")]
	private PointerEventData m_InputPointerEvent; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	[SerializeField]
	[Token(Token = "0x4000363")]
	private bool m_ForceModuleActive; //Field offset: 0x80

	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	[Token(Token = "0x170001FC")]
	public bool allowActivationOnStandalone
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[Token(Token = "0x600076E")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
		[Token(Token = "0x600076F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001FD")]
	public bool forceModuleActive
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[Token(Token = "0x6000770")]
		 get { } //Length: 8
		[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
		[Token(Token = "0x6000771")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x3475290", Offset = "0x3474690", Length = "0x7")]
	[Token(Token = "0x600076D")]
	protected TouchInputModule() { }

	[Address(RVA = "0x3470A50", Offset = "0x346FE50", Length = "0x7")]
	[Token(Token = "0x600077A")]
	public virtual void DeactivateModule() { }

	[Address(RVA = "0x3473AF0", Offset = "0x3472EF0", Length = "0x168")]
	[Token(Token = "0x6000777")]
	private void FakeTouches() { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[Token(Token = "0x600076E")]
	public bool get_allowActivationOnStandalone() { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[Token(Token = "0x6000770")]
	public bool get_forceModuleActive() { }

	[Address(RVA = "0x3473C60", Offset = "0x3473060", Length = "0x40")]
	[Token(Token = "0x6000773")]
	public virtual bool IsModuleSupported() { }

	[Address(RVA = "0x3474B50", Offset = "0x3473F50", Length = "0x1B1")]
	[Token(Token = "0x6000776")]
	public virtual void Process() { }

	[Address(RVA = "0x3473CB0", Offset = "0x34730B0", Length = "0x79A")]
	[Token(Token = "0x6000778")]
	private void ProcessTouchEvents() { }

	[Address(RVA = "0x3474450", Offset = "0x3473850", Length = "0x6F3")]
	[Token(Token = "0x6000779")]
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[Token(Token = "0x600076F")]
	public void set_allowActivationOnStandalone(bool value) { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[Token(Token = "0x6000771")]
	public void set_forceModuleActive(bool value) { }

	[Address(RVA = "0x3474D10", Offset = "0x3474110", Length = "0x11E")]
	[Token(Token = "0x6000774")]
	public virtual bool ShouldActivateModule() { }

	[Address(RVA = "0x3474E30", Offset = "0x3474230", Length = "0x2AB")]
	[Token(Token = "0x600077B")]
	public virtual string ToString() { }

	[Address(RVA = "0x34750E0", Offset = "0x34744E0", Length = "0x162")]
	[Token(Token = "0x6000772")]
	public virtual void UpdateModule() { }

	[Address(RVA = "0x3475250", Offset = "0x3474650", Length = "0x36")]
	[Token(Token = "0x6000775")]
	private bool UseFakeInput() { }

}

