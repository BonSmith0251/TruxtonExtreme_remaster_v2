namespace UnityEngine.Rendering;

[Token(Token = "0x20000C6")]
internal class DebugUpdater : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000C7")]
	private sealed class <DoAfterInputModuleUpdated>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000286")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000287")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000288")]
		public Action action; //Field offset: 0x20

		[Token(Token = "0x170000A8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000769")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000A9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600076B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000766")]
		public <DoAfterInputModuleUpdated>d__9(int <>1__state) { }

		[Address(RVA = "0x2BEA550", Offset = "0x2BE9950", Length = "0xF7")]
		[Token(Token = "0x6000768")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000769")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600076B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2BEA650", Offset = "0x2BE9A50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600076A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000767")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C8")]
	private sealed class <RefreshRuntimeUINextFrame>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000289")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400028A")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170000AA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600076F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000AB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000771")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600076C")]
		public <RefreshRuntimeUINextFrame>d__15(int <>1__state) { }

		[Address(RVA = "0x2BEA690", Offset = "0x2BE9A90", Length = "0xB0")]
		[Token(Token = "0x600076E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600076F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000771")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2BEA750", Offset = "0x2BE9B50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000770")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600076D")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000283")]
	private static DebugUpdater s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000284")]
	private ScreenOrientation m_Orientation; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000285")]
	private bool m_RuntimeUiWasVisibleLastFrame; //Field offset: 0x24

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000765")]
	public DebugUpdater() { }

	[Address(RVA = "0x2BE18D0", Offset = "0x2BE0CD0", Length = "0x243")]
	[Token(Token = "0x6000760")]
	private void AssignDefaultActions() { }

	[Address(RVA = "0x2BE1B20", Offset = "0x2BE0F20", Length = "0x109")]
	[Token(Token = "0x600075F")]
	private void CheckInputModuleExists() { }

	[Address(RVA = "0x2BE1C30", Offset = "0x2BE1030", Length = "0x129")]
	[Token(Token = "0x6000761")]
	private void CreateDebugEventSystem() { }

	[Address(RVA = "0x2BE1D60", Offset = "0x2BE1160", Length = "0x18B")]
	[Token(Token = "0x6000762")]
	private void DestroyDebugEventSystem() { }

	[Address(RVA = "0x2BE1EF0", Offset = "0x2BE12F0", Length = "0x189")]
	[Token(Token = "0x600075B")]
	private static void DisableRuntime() { }

	[Address(RVA = "0x2BE2080", Offset = "0x2BE1480", Length = "0x67")]
	[IteratorStateMachine(typeof(<DoAfterInputModuleUpdated>d__9))]
	[Token(Token = "0x600075E")]
	private IEnumerator DoAfterInputModuleUpdated(Action action) { }

	[Address(RVA = "0x2BE20F0", Offset = "0x2BE14F0", Length = "0x189")]
	[Token(Token = "0x600075A")]
	private static void EnableRuntime() { }

	[Address(RVA = "0x2BE2280", Offset = "0x2BE1680", Length = "0x2A8")]
	[Token(Token = "0x600075D")]
	private void EnsureExactlyOneEventSystem() { }

	[Address(RVA = "0x2BE2530", Offset = "0x2BE1930", Length = "0xB3")]
	[Token(Token = "0x600075C")]
	internal static void HandleInternalEventSystemComponents(bool uiEnabled) { }

	[Address(RVA = "0x2BE25F0", Offset = "0x2BE19F0", Length = "0x4B")]
	[IteratorStateMachine(typeof(<RefreshRuntimeUINextFrame>d__15))]
	[Token(Token = "0x6000764")]
	private static IEnumerator RefreshRuntimeUINextFrame() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::AfterSceneLoad (0))]
	[Token(Token = "0x6000758")]
	private static void RuntimeInit() { }

	[Address(RVA = "0x2BE2640", Offset = "0x2BE1A40", Length = "0x30B")]
	[Token(Token = "0x6000759")]
	internal static void SetEnabled(bool enabled) { }

	[Address(RVA = "0x2BE2950", Offset = "0x2BE1D50", Length = "0x3F6")]
	[Token(Token = "0x6000763")]
	private void Update() { }

}

