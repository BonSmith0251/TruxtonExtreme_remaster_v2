namespace UnityEngine.UIElements;

[Token(Token = "0x200029D")]
public class KeyboardNavigationManipulator : Manipulator
{
	[CompilerGenerated]
	[Token(Token = "0x200029E")]
	private struct <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A68")]
		public KeyDownEvent evt; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A67")]
	private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; //Field offset: 0x18

	[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
	[Token(Token = "0x6001237")]
	public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action) { }

	[Address(RVA = "0x34045A0", Offset = "0x34039A0", Length = "0xD4")]
	[CompilerGenerated]
	[Token(Token = "0x600123F")]
	internal static KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(ref <>c__DisplayClass4_0 unnamed_param_0) { }

	[Address(RVA = "0x338CD10", Offset = "0x338C110", Length = "0x19")]
	[Token(Token = "0x600123E")]
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	[Address(RVA = "0x3404180", Offset = "0x3403580", Length = "0x94")]
	[Token(Token = "0x600123A")]
	internal void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x3404290", Offset = "0x3403690", Length = "0x21")]
	[Token(Token = "0x600123B")]
	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	[Address(RVA = "0x34042C0", Offset = "0x34036C0", Length = "0xC7")]
	[Token(Token = "0x600123D")]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[Address(RVA = "0x3404390", Offset = "0x3403790", Length = "0x21")]
	[Token(Token = "0x600123C")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x34043C0", Offset = "0x34037C0", Length = "0x1DA")]
	[Token(Token = "0x6001238")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x34046A0", Offset = "0x3403AA0", Length = "0x1DA")]
	[Token(Token = "0x6001239")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}

